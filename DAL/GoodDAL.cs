using AutoMapper;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using TradeCompany.Database;

namespace DAL
{
	public class GoodDAL:companyEntities,IGoodDAL
	{
		readonly IMapper _mapper;

		public GoodDAL()
		{
			var config = new AutoMapper.MapperConfiguration(c => c.AddProfiles(typeof(GoodDAL)));
			_mapper = config.CreateMapper();
		}

		public int AddProd(GoodDTO prod)
		{
			if (prod != null)
			{
				using (var db = new companyEntities())
				{
					db.tblGoods.Add(_mapper.Map<tblGood>(prod));
					db.SaveChanges();
					return prod.id;
				}
			}

			return 0;
		}

		public GoodDTO GetGoodById(int id)
		{
			using (var entities = new GoodDAL())
			{
				var good = entities.tblGoods.FirstOrDefault(c => c.id == id);
				return _mapper.Map<GoodDTO>(good);
			}

		}

		public List<GoodDTO> GetAllProduct()
		{
			List<GoodDTO> products = new List<GoodDTO>();

			using (var entities = new GoodDAL())
			{
				products = _mapper.Map<List<GoodDTO>>(entities.tblGoods).ToList();
			}
			return products;
		}


		public List<GoodDTO> GetGoodByCategory(CategoryDTO categoryDTO)
		{
			List<GoodDTO> products = new List<GoodDTO>();
			using (var entities = new GoodDAL())
			{
				products = _mapper.Map<List<GoodDTO>>(entities.tblGoods.Where(c => c.category_id == categoryDTO.id)).ToList();
			}
			return products;

		}


		public GoodDTO UpdateProd(GoodDTO productToUpdate)
		{
			using (var db = new companyEntities())
			{
				var prod = db.tblGoods.FirstOrDefault(u => u.id == productToUpdate.id);
				return _mapper.Map<GoodDTO>(prod);
			}
		}


	}
}
