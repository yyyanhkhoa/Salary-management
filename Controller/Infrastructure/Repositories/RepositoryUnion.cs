using Salary_management.Controller.Infrastructure.Data;
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
	}
}
