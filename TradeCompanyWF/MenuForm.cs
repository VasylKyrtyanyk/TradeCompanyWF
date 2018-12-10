using BussniessLogic.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeCompanyWF
{
	public partial class MenuForm : Form
	{
		protected UserDTO _user;
		protected IEntityBL _entityBL;

		public MenuForm(IEntityBL entityBL, UserDTO user)
		{
			InitializeComponent();
			_user = user;
			_entityBL = entityBL;
		}
	}
}
