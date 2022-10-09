using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	internal class RepositoryUnit : Repository
	{
		public bool CheckUnitExists(string name)
			=> Context.Units.Any(u => u.Name == name);

		public Result<Models.Unit> InsertUnit(UnitInput input)
		{
			if (CheckUnitExists(input.Name))
				return new() { Success = false, ErrorMessage = "This unit already exists" };

			var unit = Map(input);
			Context.Units.Add(unit);
			Context.SaveChanges();

			return new Result<Models.Unit> { Success = true, Payload = unit };
		}

		private static Models.Unit Map(UnitInput input)
		{
			return new Models.Unit
			{
				Name = input.Name,
				Address = input.Address,
				PhoneNumber = input.PhoneNumber,
				DateFounded = input.DateFounded
			};
		}
	}
}
