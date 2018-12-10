using BussniessLogic.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace TradeCompanyWF
{
	public partial class MenuForm : Form
	{
		protected UserDTO _user;
		protected IEntityBL _entityBL;
		List<GoodDTO> _goods;
		List<PictureBox> _pictureBoxes;
		List<CategoryDTO> _categories;


		public MenuForm(IEntityBL entityBL, UserDTO user)
		{
			InitializeComponent();
			_user = user;
			_entityBL = entityBL;
			_goods = new List<GoodDTO>();
			_pictureBoxes = new List<PictureBox>();
			_categories = _entityBL.GetCategories();
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{
			UserNameLabel.Text = _user.first_name;
		}

		private void LogOut_Click(object sender, EventArgs e)
		{
			this.Close();
			Hide();
			var loginForm = Program.Container.Resolve<LoginForm>();

			loginForm.ShowDialog();
		}

		private void laptopButton_Click(object sender, EventArgs e)
		{

			CategoryPanel.Controls.Clear();
			CategoryPanel.ColumnCount = 3;
			//CategoryPanel.RowCount = 2;
			_goods = _entityBL.GetGoodByCategory(_categories[0]);
			List<int> res = new List<int>();
			int i = 0;
			foreach (GoodDTO g in _goods)
			{
				res.Add(g.id);
				PictureBox p = new PictureBox();
				string url = g.photo_url;
				p.Image = Image.FromFile(url);
				p.Size = new Size(120, 150);
				p.SizeMode = PictureBoxSizeMode.Zoom;
				p.Name = Convert.ToString(g.id);
				p.MouseClick += new MouseEventHandler(picture_click);
				_pictureBoxes.Add(p);
				CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				CategoryPanel.Controls.Add(p);

			}
		}

		private void picture_click(object sender, MouseEventArgs e)
		{
			PictureBox p = (PictureBox)(sender);
			int s = int.Parse(p.Name);

			var good = _entityBL.GetGoodById(s);

			//if (good != null)
			//{

			//	var productForm = Program.Container.Resolve<ProductForm>(new ParameterOverride("good", good));
			//	productForm.ShowDialog();
			//}
		}

		private void PhoneButton_Click(object sender, EventArgs e)
		{
			CategoryPanel.Controls.Clear();
			CategoryPanel.ColumnCount = 3;
			//CategoryPanel.RowCount = 2;
			_goods = _entityBL.GetGoodByCategory(_categories[1]);
			List<int> res = new List<int>();
			int i = 0;
			foreach (GoodDTO g in _goods)
			{
				res.Add(g.id);
				PictureBox p = new PictureBox();
				string url = g.photo_url;
				p.Image = Image.FromFile(url);
				p.Size = new Size(120, 150);
				p.SizeMode = PictureBoxSizeMode.Zoom;
				p.Name = Convert.ToString(g.id);
				p.MouseClick += new MouseEventHandler(picture_click);
				_pictureBoxes.Add(p);
				CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
				CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
				CategoryPanel.Controls.Add(p);
			}
		}

	}
}
