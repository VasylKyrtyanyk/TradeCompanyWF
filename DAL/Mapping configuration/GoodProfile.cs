using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace DAL.Mapping_configuration
{
	public class GoodProfile : Profile
	{
		public GoodProfile()
		{
			CreateMap<tblGood, GoodDTO>().ReverseMap();
		}
	}
}
