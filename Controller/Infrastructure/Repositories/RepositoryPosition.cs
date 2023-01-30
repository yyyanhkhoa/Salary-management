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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryPosition : Repository
	{
		public bool CheckPositionExist(string id)
			=> Context.Positions.Any(p => p.Id == id);

		public bool CheckNameExist(string name)
			=> Context.Positions.Any(p => p.Name == name);

		public bool CheckRankExist(int id)
			=> Context.Ranks.Any(r => r.Id == id);

		public Result<Models.Position> InsertPosition(InputPosition inputPosition)
		{
			if (CheckPositionExist(inputPosition.Id))
			{
				return new Result<Models.Position> { Success = false, ErrorMessage = "Position with this id already exists." };
			}

			if (CheckNameExist(inputPosition.Name))
			{
				return new Result<Models.Position> { Success = false, ErrorMessage = "Position with this name already exists." };
			}

			if (!CheckRankExist(inputPosition.RankId))
			{
				return new Result<Models.Position> { Success = false, ErrorMessage = "Rank with this id do not exist." };
			}

			Position position = MapToEntity(inputPosition);
			Context.Positions.Add(position);
			Context.SaveChanges();
			return new Result<Models.Position> { Success = true, Payload = ConnectWithRank(position) };
		}

		public Models.Position GetPositionDetail(string positionId)
		{
			return MapToModel(Context.Positions.Include(p => p.Rank).Where(p => p.Id == positionId).First());
		}

		public Result<Models.Position> FixPosition(string id, InputPosition input)
		{
			var position = MapToEntity(input);
			position.Id = id;
			Context.Positions.Update(position);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetPositionDetail(id) };
		}

		public void DeletePosition(string id)
		{
			var position = new Position { Id = id };
			Context.Positions.Attach(position);
			Context.Positions.Remove(position);
			Context.SaveChanges();
		}

		public List<Models.Position> GetPositions(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Positions.Include(p => p.Rank)
							  .Take(20).Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Positions.Include(p => p.Rank).Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
				.Select(e => MapToModel(e)).ToList();
			}
		}

		public Result<List<Models.PositionTimeline>> GetTimeline(string positionId, DateOnly? from = null, DateOnly? to = null)
		{
			var query = Context.PositionHistories.Where(uh => uh.PositionId == positionId);
			query = Helper.GetTimelineByDateRange(query, from, to);

			return new()
			{
				Success = true,
				Payload = query.Include(uh => uh.Employee)
							   .Select(ph => MapToTimelineModel(ph))
							   .ToList()
			};
		}

		private static Models.PositionTimeline MapToTimelineModel(PositionHistory entity)
		{
			return new Models.PositionTimeline
			{
				Id = entity.Id,
				EmployeeName = entity.Employee.Name,
				PositionId = entity.PositionId,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				EmployeeId = entity.EmployeeId
			};
		}

		private static Position MapToEntity(InputPosition inputPosition)
		{
			return new Position
			{
				Id = inputPosition.Id,
                Name = inputPosition.Name,
				BaseSalary = inputPosition.BaseSalary,
				RankId = inputPosition.RankId,
				Description = inputPosition.Description,
			};
		}

		private static Models.Position MapToModel(Position inputPosition)
		{
			return new Models.Position
			{
				Id = inputPosition.Id,
				Name = inputPosition.Name,
				BaseSalary = inputPosition.BaseSalary,
				Description = inputPosition.Description,
				Rank = new Models.Rank
				{
					Id = inputPosition.Rank.Id,
					Name = inputPosition.Rank.Name,
					Milestone = inputPosition.Rank.Milestone,
					Coefficient = inputPosition.Rank.Coefficient
				}
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
        private Models.Position ConnectWithRank(Position postion)
        {
            return new Models.Position
            {
                Id = postion.Id,
                Name = postion.Name,
                BaseSalary = postion.BaseSalary,
                Rank = MapRankToModel(Context.Ranks.Where(r => r.Id == postion.RankId).FirstOrDefault()!)
            };
        }
    }

}
