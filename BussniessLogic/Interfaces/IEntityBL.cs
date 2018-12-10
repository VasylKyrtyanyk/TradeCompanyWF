using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLogic.Interfaces
{
	public interface IEntityBL
	{
		List<GoodDTO> GetProduct();
		List<FeedBackDTO> GetAllFeedBackByProduct(int Id);
		CategoryDTO GetCategoryById(int id);
		int Login(string email, string pass);
		UserDTO GetUserById(int id);
		List<CategoryDTO> GetCategories();
		List<FeedBackDTO> GetFeedbackByGoodsId(int GoodId);

		List<GoodDTO> GetGoodByCategory(CategoryDTO categoryDTO);
		GoodDTO GetGoodById(int id);
		List<FeedBackDTO> SearchFeedBackLogin(List<FeedBackDTO> feeds, string name);
		List<FeedBackDTO> SortFeedBacks(List<FeedBackDTO> feed, int type);
		List<UserDTO> GetUsers();
		int AddUser(UserDTO user);
	}
}
