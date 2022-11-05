using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Model;
using Models = Salary_management.Model;

namespace Salary_management.Controller.Infrastructure.Repositories
{
    public class RepositoryAuth : Repository
	{
		public bool CheckUserExist(string username, string password)
			=> Context.Auths.Any(a => a.Username == username && a.Password == password);

		public bool CheckUsernameExists(string username)
			=> Context.Auths.Any(a => a.Username == username);

		public Result<Auth> InsertUser(string username, string password)
		{
			if (CheckUsernameExists(username))
				return new Result<Auth> { Success = false, ErrorMessage = "Username already exists." };

			var userAuth = new Models.Auth { Username = username, Password = password };
			Context.Auths.Add(userAuth);
			Context.SaveChanges(); 
			return new Result<Auth> { Success = true, Payload = userAuth };
		}
	}
}
