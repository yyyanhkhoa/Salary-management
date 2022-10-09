using Salary_management.Controller.Infrastructure.Data;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
	public class RepositoryAuth : Repository
	{
		public bool CheckUserExist(string username, string password)
			=> Context.Auths.Any(a => a.Username == username && a.Password == password);

		public bool CheckUsernameExists(string username)
			=> Context.Auths.Any(a => a.Username == username);

		public Result<Models.Auth> InsertUser(string username, string password)
		{
			if (!CheckUsernameExists(username))
				return new Result<Models.Auth> { Success = false, ErrorMessage = "Username already exists." };

			var userAuth = new Models.Auth { Username = username, Password = password };
			Context.Auths.Add(userAuth);
			Context.SaveChanges(); 
			return new Result<Models.Auth> { Success = true, Payload = userAuth };
		}
	}
}
