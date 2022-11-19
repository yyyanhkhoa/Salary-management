using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryRank : Repository
	{
		public bool CheckRankExist(string name)
			=> Context.Unions.Any(a => a.Name == name);

		public Result<Models.Rank> InsertRank(InputRank inputRank)
		{
			if (CheckRankExist(inputRank.Name))
				return new Result<Models.Rank> { Success = false, ErrorMessage = "Rank with this name already exists." };

			Rank rank = MapToEntity(inputRank);
			Context.Ranks.Add(rank);
			Context.SaveChanges();
			return new Result<Models.Rank> { Success = true, Payload = MapToModel(rank) };
		}

        public List<Models.Rank> GetRank(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return Context.Ranks.Take(20).Select(e => Map(e)).ToList();
            }
            else
            {
                return Context.Ranks.Where(
                    e => EF.Functions.Like(e.Name, $"%{keyword}%") ||
                         EF.Functions.Like(e.Id.ToString(), $"%{keyword}%")
                )
                    .Select(e => Map(e)).ToList();
            }
        }

		public Models.Rank GetRankDetail(int rankId)
		{
			return MapToModel(Context.Ranks.Where(r => r.Id == rankId).First());
		}

		public Result<Models.Rank> FixRank(int rankId, InputRank inputRank)
		{
			if (CheckRankExist(inputRank.Name))
				return new Result<Models.Rank> { Success = false, ErrorMessage = "Rank with this name already exists." };

			var rank = MapToEntity(inputRank);
			rank.Id = rankId;
			Context.Ranks.Update(rank);
			Context.SaveChanges();

			return new Result<Models.Rank> { Success = true, Payload = MapToModel(rank)};
		}

		public void DeleteRank(int rankId)
		{
			var rank = new Rank { Id = rankId };
			Context.Ranks.Attach(rank);
			Context.Ranks.Remove(rank);
			Context.SaveChanges();
		}

		private static Models.Rank Map(Rank input)
		{
			return new Models.Rank
			{
				Id = input.Id,
				Name = input.Name,
				Milestone = input.Milestone,
				Coefficient = input.Coefficient
			};
		}

		private Rank MapToEntity(InputRank inputRank)
		{
			return new Rank
			{
				Name = inputRank.Name,
				Milestone = inputRank.Milestone,
				Coefficient = inputRank.Coefficient
			};
		}

		private Models.Rank MapToModel(Rank rank)
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
