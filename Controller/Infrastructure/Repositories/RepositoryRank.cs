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

		public Rank MapToEntity(InputRank inputRank)
		{
			return new Rank
			{
				Name = inputRank.Name,
				Milestone = inputRank.Milestone,
				Coefficient = inputRank.Coefficient
			};
		}

		public Models.Rank MapToModel(Rank rank)
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
