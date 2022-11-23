using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Salary_management.Model;
using Salary_management.Infrastructure.Entities;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryExpertise : Repository
	{
		public bool CheckExpertiseExist(string name)
			=> Context.Expertises.Any(a => a.Name == name);

		public Result<Models.Expertise> InsertExpertise(string name)
		{
			if (CheckExpertiseExist(name))
				return new Result<Models.Expertise> { Success = false, ErrorMessage = "Expertise with this name already exists." };

			var expertise = new Expertise() { Name = name };
			Context.Expertises.Add(expertise);
			Context.SaveChanges();
			return new Result<Models.Expertise> { Success = true, Payload = MapToModel(expertise)};
		}

		private static Models.Expertise MapToModel(Expertise expertise)
		{
			return new Models.Expertise
			{
				Id = expertise.Id,
				Name = expertise.Name
			};
		}

		public Models.Expertise GetExpertiseDetail(int id)
		{
			return MapToModel(Context.Expertises.Where(u => u.Id == id).First());
		}

		/// <summary>
		/// Lấy thông tin các đoàn thể theo từ khóa, nếu từ khóa trống thì lấy thông tin của tất cả đoàn thể
		/// </summary>
		/// <param name="searchString"></param>
		/// <returns></returns>
		public List<Models.Expertise> GetExpertises(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Expertises.Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Expertises.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%")
				)
				.Select(e => MapToModel(e)).ToList();
			}
		}

		public Result<Models.Expertise> FixExpertise(int id, string name)
		{
			var expertise = new Expertise() { Id = id, Name = name };
			Context.Expertises.Update(expertise);
			Context.SaveChanges();

			return new() { Success = true, Payload = MapToModel(expertise) };
		}

		public void DeleteExpertise(int id)
		{
			var expertise = new Expertise { Id = id };
			Context.Expertises.Attach(expertise);
			Context.Expertises.Remove(expertise);
			Context.SaveChanges();
		}
	}
}
