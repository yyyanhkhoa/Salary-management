using Microsoft.EntityFrameworkCore;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryQualification : Repository
	{
		public bool CheckQualificationExist(int id)
			=> Context.Qualifications.Any(p => p.Id == id);

		public bool CheckNameExist(string name)
			=> Context.Qualifications.Any(p => p.Name == name);

		public Result<Models.Qualification> InsertQualification(InputQualification inputQualification)
		{
			if (CheckNameExist(inputQualification.Name))
			{
				return new Result<Models.Qualification> { Success = false, ErrorMessage = "Qualification with this name already exists." };
			}

			var qualification = MapToEntity(inputQualification);
			Context.Qualifications.Add(qualification);
			Context.SaveChanges();

			return new Result<Models.Qualification> { Success = true, Payload = GetQualificationDetail(qualification.Id) };
		}

		public Models.Qualification GetQualificationDetail(int id)
		{
			return MapToModel(Context.Qualifications.Where(p => p.Id == id).Include(p => p.Expertise).First());
		}

		public Result<Models.Qualification> FixQualification(int id, InputQualification input)
		{
			var qualification = MapToEntity(input);
			qualification.Id = id;
			Context.Qualifications.Update(qualification);
			Context.SaveChanges();

			return new() { Success = true, Payload = GetQualificationDetail(qualification.Id) };
		}

		public void DeleteQualification(int id)
		{
			var qualification = new Qualification { Id = id };
			Context.Qualifications.Attach(qualification);
			Context.Qualifications.Remove(qualification);
			Context.SaveChanges();
		}

		public List<Models.Qualification> GetQualifications(string keyword)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				return Context.Qualifications.Include(p => p.Expertise)
							  .Select(e => MapToModel(e)).ToList();
			}
			else
			{
				return Context.Qualifications.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") 
				)
				.Include(p => p.Expertise)
				.Select(e => MapToModel(e)).ToList();
			}
		}

		public int GetLatestYearAtQualificationAllowance(int qualificationId)
		{
			var lastestQah = Context.QualificationAllowanceHistories.Where(qah => qah.QualificationId == qualificationId)
						  .OrderByDescending(uh => uh.Year)
						  .FirstOrDefault();

			return lastestQah != null ? lastestQah.Year : DateTime.Now.Year;
		}

        public Result<List<Models.QualificationAllowanceTimeline>> GetQualificationAllowanceTimeline(int qualificationId, int? yearFrom = null, int? yearTo = null)
		{
			var query = Context.QualificationAllowanceHistories.Where(uh => uh.QualificationId == qualificationId);
			if (yearFrom != null && yearTo != null)
			{
				query = query.Where(h => h.Year >= yearFrom && h.Year <= yearTo);
			}
			else if (yearFrom != null)
			{
				query = query.Where(h => h.Year >= yearFrom);
			}
			else if (yearTo != null)
			{
				query = query.Where(h => h.Year <= yearTo);
			}

			return new()
			{
				Success = true,
				Payload = query.OrderBy(h => h.Year)
							   .Select(ph => MapToTimelineModel(ph))
							   .ToList()
			};
		}

		private static Models.QualificationAllowanceTimeline MapToTimelineModel(QualificationAllowanceHistory qah)
		{
			return new Models.QualificationAllowanceTimeline
			{
				Id = qah.Id,
				Year = qah.Year,
				Allowance = qah.Allowance
			};
		}
		private static Qualification MapToEntity(InputQualification input)
		{
			return new Qualification
			{
				Name = input.Name,
				ExpertiseId = input.ExpertiseId
			};
		}

		private static Models.Qualification MapToModel(Qualification entity)
		{
			return new Models.Qualification
			{
				Id = entity.Id,
				Name = entity.Name,
				ExpertiseId = entity.ExpertiseId,
				Expertise = new Models.Expertise
				{
					Id = entity.Expertise.Id,
					Name = entity.Expertise.Name
				}
			};
		}
	}
}
