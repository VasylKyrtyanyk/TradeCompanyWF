using BussniessLogic.Interfaces;
using DAL;
using DTO;
using System.Collections.Generic;

namespace BussniessLogic
{
	public class EntityBL:IEntityBL
	{
		private UserDAL _userDAL;
		private GoodDAL _goodDAL;
		private FeedBackDAL _feedBackDAL;
		private CategoryDAL _categoryDAL;

		public EntityBL()
		{
			_userDAL = new UserDAL();
			_goodDAL = new GoodDAL();
			_feedBackDAL = new FeedBackDAL();
			_categoryDAL = new CategoryDAL();
		}

		public List<GoodDTO> GetProduct()
		{
			List<GoodDTO> goods = _goodDAL.GetAllProduct();
			return goods;
		}

		public List<FeedBackDTO> GetAllFeedBackByProduct(int Id)
		{
			List<FeedBackDTO> list = _feedBackDAL.GetFeedbackByGoodsId(Id);
			return list;
		}

		public CategoryDTO GetCategoryById(int id)
		{
			return _categoryDAL.GetCategoryById(id);
		}

		public int Login(string email, string pass)
		{
			_userDAL.Login(email, pass);
			return _userDAL.Login(email, pass);
		}

		public UserDTO GetUserById(int id)
		{
			return _userDAL.GetUserById(id);
		}

		public List<CategoryDTO> GetCategories()
		{
			List<CategoryDTO> list = _categoryDAL.GetCategories();
			return list;
		}

		public List<FeedBackDTO> GetFeedbackByGoodsId(int GoodId)
		{
			List<FeedBackDTO> list = _feedBackDAL.GetFeedbackByGoodsId(GoodId);
			return list;
		}

		public List<GoodDTO> GetGoodByCategory(CategoryDTO categoryDTO)
		{
			List<GoodDTO> goods = _goodDAL.GetGoodByCategory(categoryDTO);

			return goods;
		}

		public GoodDTO GetGoodById(int id)
		{
			return _goodDAL.GetGoodById(id);
		}

		public List<FeedBackDTO> SortFeedBacks(List<FeedBackDTO> feed, int type)
		{
			return _feedBackDAL.SortFeedBacks(feed, type);
		}

		public List<FeedBackDTO> SearchFeedBackLogin(List<FeedBackDTO> feeds, string name)
		{
			return _feedBackDAL.SearchFeedBackLogin(feeds, name);
		}

		public UserDTO UpdateUser(UserDTO userToUpdate)
		{
			return _userDAL.UpdateUser(userToUpdate);
		}

		public GoodDTO UpdateProd(GoodDTO prod)
		{
			return _goodDAL.UpdateProd(prod);
		}

		public List<UserDTO> GetUsers()
		{
			return _userDAL.GetUsers();
		}


		public int AddUser(UserDTO user)
		{
			return _userDAL.AddUser(user);
		}

		public int AddProd(GoodDTO prod)
		{
			return _goodDAL.AddProd(prod);
		}

	}
}
