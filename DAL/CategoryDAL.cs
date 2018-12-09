using AutoMapper;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using TradeCompany.Database;

namespace DAL
{
	public class CategoryDAL : companyEntities,ICategoryDAL
	{

		IMapper _mapper;

		public CategoryDAL()
		{
			var config = new AutoMapper.MapperConfiguration(c => c.AddProfiles(typeof(CategoryDAL)));
			_mapper = config.CreateMapper();
		}

		public List<CategoryDTO> GetCategories()
		{
			List<CategoryDTO> category = new List<CategoryDTO>();

			using (var entities = new CategoryDAL())
			{
				category = _mapper.Map<List<CategoryDTO>>(entities.tblCategories).ToList();
			}
			return category;
		}


		public CategoryDTO GetCategoryById(int id)
		{
			using (var entities = new CategoryDAL())
			{
				var cat = entities.tblCategories.FirstOrDefault(c => c.id == id);
				return _mapper.Map<CategoryDTO>(cat);
			}
		}

	}
}
