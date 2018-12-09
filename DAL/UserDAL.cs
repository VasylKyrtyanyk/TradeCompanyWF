using AutoMapper;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TradeCompany.Database;

namespace DAL
{
	public class UserDAL:companyEntities,IUserDAL
	{
		readonly IMapper _mapper;

		public UserDAL()
		{
			var config = new AutoMapper.MapperConfiguration(c => c.AddProfiles(typeof(UserDAL)));
			_mapper = config.CreateMapper();
		}

		public int AddUser(UserDTO user)
		{
			if (user != null)
			{
				using (var db = new companyEntities())
				{
					db.tblUsers.Add(_mapper.Map<tblUser>(user));
					db.SaveChanges();
					return user.id;
				}
			}

			return 0;
		}

		public int DeleteUserById(int id)
		{

			using (var db = new companyEntities())
			{
				tblUser user = _mapper.Map<tblUser>(GetUserById(id));
				if (user != null)
				{
					db.Entry(user).State = EntityState.Deleted;
					db.SaveChanges();
					return 1;
				}
				return 0;

			}
		}

		public List<UserDTO> GetUsers()
		{
			List<UserDTO> users = new List<UserDTO>();

			using (var entities = new companyEntities())
			{
				users = _mapper.Map<List<UserDTO>>(entities.tblUsers).ToList();
			}
			return users;
		}

		public UserDTO GetUserById(int id)
		{
			using (var entities = new companyEntities())
			{
				var us = entities.tblUsers.FirstOrDefault(c => c.id == id);
				return _mapper.Map<UserDTO>(us);

			}
		}

		public int Login(string email, string pass)
		{
			int res = -1;
			string passHash = GetHash(pass);
			using (var entities = new companyEntities())
			{
				var user = entities.tblUsers.Where(u => u.email == email && u.password == passHash).FirstOrDefault();
				if (user != null)
				{
					res = user.id;
					user.Is_Login = true;
					SaveChanges();
					return res;
				}
			}

			return res;
		}

		public UserDTO UpdateUser(UserDTO userToupdate)
		{
			using (var db = new companyEntities())
			{
				var user = db.tblUsers.FirstOrDefault(u => u.id == userToupdate.id);
				user.email = userToupdate.email;
				user.first_name = userToupdate.first_name;
				user.last_name = userToupdate.last_name;
				user.Is_Login = true;
				user.password = userToupdate.password;
				return _mapper.Map<UserDTO>(user);
			}
		}

		private string GetHash(string key)
		{
			var alg = SHA256.Create();
			byte[] bytes = alg.ComputeHash(Encoding.UTF8.GetBytes(key));

			StringBuilder builder = new StringBuilder();
			foreach (byte b in bytes)
			{
				builder.Append(b.ToString("x2"));
			}
			return builder.ToString();
		}

	}
}
