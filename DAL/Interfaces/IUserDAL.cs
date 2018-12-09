using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
	public interface IUserDAL
	{
		int AddUser(UserDTO user);
		int DeleteUserById(int id);
		List<UserDTO> GetUsers();
		UserDTO GetUserById(int id);
		int Login(string email, string pass);
		UserDTO UpdateUser(UserDTO userToupdate);
	}
}
