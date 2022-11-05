using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryPosition : Repository
	{
		public bool CheckPositionExist(string name)
			=> Context.Ranks.Any(p => p.Name == name);

		public bool CheckRankExist(int id)
			=> Context.Ranks.Any(r => r.Id == id);


		public Result<Models.Position> InsertPosition(InputPosition inputPosition)
		{
			if (CheckPositionExist(inputPosition.Name))
				return new Result<Models.Position> { Success = false, ErrorMessage = "Position with this name already exists." };

			if (!CheckRankExist(inputPosition.RankId))
				return new Result<Models.Position> { Success = false, ErrorMessage = "Rank with this id do not exist." };

			Position position = MapToEntity(inputPosition);
			Context.Positions.Add(position);
			Context.SaveChanges();
			return new Result<Models.Position> { Success = true, Payload = MapToModel(position)};
		}

		public List<Models.Position> GetPositions(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Positions.Take(20).Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Positions.Include(p => p.Rank).Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
				.Select(e => MapToEntity(e)).ToList();
			}
		}

		private static Position MapToEntity(InputPosition inputPosition)
		{
			return new Position
			{
				Id = inputPosition.Id,
				Name = inputPosition.Name,
				BaseSalary = inputPosition.BaseSalary,
				RankId = inputPosition.RankId
			};
		}

		private static Models.Position MapToEntity(Position inputPosition)
		{
			return new Models.Position
			{
				Id = inputPosition.Id,
				Name = inputPosition.Name,
				BaseSalary = inputPosition.BaseSalary,
				Rank = new Models.Rank
				{
					Id = inputPosition.Rank.Id,
					Name = inputPosition.Rank.Name,
					Milestone = inputPosition.Rank.Milestone,
					Coefficient = inputPosition.Rank.Coefficient
				}
			};
		}

		private Models.Position MapToModel(Position postion)
		{
			return new Models.Position
			{
				Id = postion.Id,
				Name = postion.Name,
				BaseSalary = postion.BaseSalary,
				Rank = MapRankToModel(Context.Ranks.Where(r => r.Id == postion.RankId).FirstOrDefault()!)
			};
		}

		private static Models.Rank MapRankToModel(Rank rank)
		{
			return new Models.Rank
			{
				Id = rank.Id,
				Name = rank.Name,
				Milestone = rank.Milestone,
				Coefficient = rank.Coefficient
			};
		}
	}
}
