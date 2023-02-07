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
using Salary_management.Infrastructure.Entities.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryFamily : Repository
	{
		public bool CheckEmployeeExist(string id)
			=> Context.Employees.Any(e => e.Id == id);

		public Result<Models.Family> InsertFamily(InputFamily inputFamily)
		{
			if (!CheckEmployeeExist(inputFamily.EmployeeId))
				return new Result<Models.Family> { Success = false, ErrorMessage = "Employee with this id do not exist." };

			Family family = MapToEntity(inputFamily);
			Context.Families.Add(family);
			Context.SaveChanges();
			var famEnitity = Context.Families.Where(f => f.Id == family.Id).Include(e => e.Employee).FirstOrDefault();
			return new Result<Models.Family> { Success = true, Payload = MapToModel(famEnitity) };
		}

		/// <summary>
		/// Lấy thông tin các thân nhân theo tên hoặc theo id của nhân viên, nếu từ khóa trống thì lấy thông tin của tất cả thân nhân
		/// </summary>
		/// <param name="keyword">tên thân nhân hoặc mã nhân viên mà thân nhân đó thuộc</param>
		/// <param name="relativeType">loại thân nhân muốn lấy, nếu để null thì sẽ lấy hết tất cả loại thân nhân</param>
		/// <returns></returns>
		public List<Models.Family> GetFamilies(string keyword, RelativeType? relativeType = null)
		{
			if (string.IsNullOrWhiteSpace(keyword))
			{
				if (relativeType == null)
				{
					return Context.Families.Include(f => f.Employee).Select(e => MapToModel(e)).ToList();
				}
				else
				{
					return Context.Families.Where(f => f.RelativeType == relativeType)
						.Include(f => f.Employee)
						.Select(e => MapToModel(e)).ToList();
				}

			}
			else
			{
				var query = Context.Families.Where(
					e => EF.Functions.ILike(e.Name, $"%{keyword}%") ||
						 EF.Functions.ILike(e.EmployeeId, $"%{keyword}%")
				);

				if (relativeType != null)
				{
					query = query.Where(f => f.RelativeType == relativeType);
				}

				return query.Include(f => f.Employee).Select(e => MapToModel(e)).ToList();
			}
		}
		public List<Models.Family> GetFamiliesByEmployee(string EmployeeId)
    {
         return Context.Families.Where(e => e.EmployeeId == EmployeeId).Include(f => f.Employee).Select(f => MapToModel(f)).ToList();
    }
   
    public Models.Family GetFamilyDetail(int id)
    {
       return MapToModel(Context.Families.Where(e => e.Id == id).Include(f => f.Employee).First()!);
    }

    public Result<Models.Family> FixFamily(int FamilyId, InputFamily inputFamily)
		{
			var Family = MapToEntity(inputFamily);
			Family.Id = FamilyId;
			Context.Families.Update(Family);
			Context.SaveChanges();

			var famEnitity = Context.Families.Where(f => f.Id == Family.Id).Include(e => e.Employee).FirstOrDefault();
			return new Result<Models.Family> { Success = true, Payload = MapToModel(famEnitity) };
		}


		public void DeleteFamily(int id)
		{
			var family = new Family { Id = id };
			Context.Families.Attach(family);
			Context.Families.Remove(family);
			Context.SaveChanges();
        }


		private static Family MapToEntity(InputFamily inputFamily)
		{
			return new Family
			{
				Name = inputFamily.Name,
				DateOfBirth = inputFamily.DateOfBirth,
				Occupation = inputFamily.Occupation,
				RelativeType = inputFamily.RelativeType,
				EmployeeId = inputFamily.EmployeeId
			};
		}

		private static Models.Family MapToModel(Family family)
		{
			return new Models.Family
			{
				Id = family.Id,
				EmployeeId = family.EmployeeId,
				EmployeeName = family.Employee.Name,
				Name = family.Name,
				DateOfBirth = family.DateOfBirth,
				Occupation = family.Occupation,
				RelativeType = family.RelativeType
			};
		}
    }
}
