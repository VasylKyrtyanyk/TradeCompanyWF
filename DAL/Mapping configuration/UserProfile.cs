using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace DAL.Mapping_configuration
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<tblUser, UserDTO>().ReverseMap();
		}
	}
}
