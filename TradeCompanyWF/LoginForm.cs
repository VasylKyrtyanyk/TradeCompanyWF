using BussniessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity.Resolution;
using Unity;

namespace TradeCompanyWF
{
	public partial class LoginForm : Form
	{
		protected IEntityBL _entityBL;

		public LoginForm(IEntityBL entityBL)
		{
			InitializeComponent();
			_entityBL = entityBL;
			EmailTextBox.Text = "admin@com.ua";
			PassTextBox.Text = "admin";
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(EmailTextBox.Text) || String.IsNullOrWhiteSpace(PassTextBox.Text))
			{
				MessageBox.Show("You must enter password and login", "Warning!!!");
				EmailTextBox.Text = "";
				PassTextBox.Text = "";
				return;
			}
			else
			{
				var res = _entityBL.Login(EmailTextBox.Text, PassTextBox.Text);

				var user = _entityBL.GetUserById(res);

				if (user != null)
				{
					var MarketForm = Program.Container.Resolve<MenuForm>(new ParameterOverride("user", user));
					DialogResult = DialogResult.OK;
					MarketForm.ShowDialog();
					this.Close();
					return;
				}
			}
			MessageBox.Show("Incorrect password or login!!!", "Error");
		}
	}
}
