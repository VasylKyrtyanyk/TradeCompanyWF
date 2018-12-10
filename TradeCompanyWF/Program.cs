using AutoMapper;
using BussniessLogic;
using BussniessLogic.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Mapping_configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace TradeCompanyWF
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		public static UnityContainer Container { get; set; }

		[STAThread]
		static void Main()
		{

			ConfigureUnity();
			InitializeAutoMapper();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var loginForm = Container.Resolve<LoginForm>();
			Application.Run(loginForm);
		}




		private static void ConfigureUnity()
		{
			Container = new UnityContainer();
			Container.RegisterType<IUserDAL, UserDAL>();
			Container.RegisterType<IGoodDAL, GoodDAL>();
			Container.RegisterType<ICategoryDAL, CategoryDAL>();
			Container.RegisterType<IEntityBL, EntityBL>();

			var config = new MapperConfiguration(c => c.AddProfiles(typeof(UserDAL).Assembly));
			Container.RegisterInstance(config.CreateMapper());


		}



		public static MapperConfiguration InitializeAutoMapper()
		{
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new GoodProfile());
				cfg.AddProfile(new CategoryProfile());
			});
			Container.RegisterInstance<IMapper>(config.CreateMapper());
			return config;
		}
	}
}
