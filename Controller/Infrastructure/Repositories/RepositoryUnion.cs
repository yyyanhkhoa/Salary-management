using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryUnion : Repository
	{
		public bool CheckUnionExist(string name)
			=> Context.Unions.Any(a => a.Name == name);

		public Result<Models.Union> InsertUnion(string name)
		{
			if (CheckUnionExist(name))
				return new Result<Models.Union> { Success = false, ErrorMessage = "Union with this name already exists." };

			var union = new Models.Union { Name = name };
			Context.Unions.Add(union);
			Context.SaveChanges();
			return new Result<Models.Union> { Success = true, Payload = union };
		}

		public Models.Union GetUnionDetail(string id)
		{
			return MapToModel(Context.Unions.Where(u => u.Id == id).First());
		}

		/// <summary>
		/// Lấy thông tin các đoàn thể theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả đoàn thể
		/// </summary>
		/// <param name="searchString"></param>
		/// <returns></returns>
		public List<Models.Union> GetUnions(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Unions.Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Unions.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.Id, $"%{keyword}%")
				)
				.Select(e => MapToModel(e)).ToList();
			}
		}


		private static Models.Union MapToModel(Union entity)
		{
			return new Models.Union
			{
				Id = entity.Id,
				Name = entity.Name
			};
		}
	}
}
