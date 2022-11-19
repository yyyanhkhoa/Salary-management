using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Migrations;
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

		public Result<Auth> InsertUser(string username, string password, Role role)
		{
			if (CheckUsernameExists(username))
				return new() { Success = false, ErrorMessage = "Username already exists." };

			var userAuth = new Models.Auth { Username = username, Password = password, Role = role};
			Context.Auths.Add(userAuth);
			Context.SaveChanges(); 
			return new Result<Auth> { Success = true, Payload = userAuth };
		}
		public void DeleteUser(int id)
		{
			var user = new Auth { Id = id };
			Context.Auths.Attach(user);
			Context.Auths.Remove(user);
			Context.SaveChanges();
		}

		public Result<Auth> Login(string username, string password)
		{
			var auth = Context.Auths.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
			if (auth == null)
			{
				return new() { Success = false, ErrorMessage = "Username or Password is incorrect." };
			}
			return new()
			{
				Success = true,
				Payload = new() { Username = auth.Username, Password = auth.Password, Role = auth.Role, Id = auth.Id }
			};
		}
	}
}
