using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace DAL.Mapping_configuration
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			CreateMap<tblCategory, CategoryDTO>().ReverseMap();

		}
	}
}
