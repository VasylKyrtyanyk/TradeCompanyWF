using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
	public interface IGoodDAL
	{
		GoodDTO GetGoodById(int id);
		List<GoodDTO> GetAllProduct();
		List<GoodDTO> GetGoodByCategory(CategoryDTO categoryDTO);
		GoodDTO UpdateProd(GoodDTO productToUpdate);
		int AddProd(GoodDTO prod);
	}
}
