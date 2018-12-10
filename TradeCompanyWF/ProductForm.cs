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
	public partial class ProductForm : Form
	{
		protected IEntityBL _entityBL;
		protected GoodDTO _good;
		protected List<FeedBackDTO> _feedBacks;
		protected List<TextBox> _text;

		public ProductForm(IEntityBL entityBL, GoodDTO good)
		{
			InitializeComponent();
			_entityBL = entityBL;
			_good = good;
			_text = new List<TextBox>();

			ProductPictureBox.Size = new Size(120, 150);
			ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			ProductPictureBox.Image = Image.FromFile(_good.photo_url);
			NameLabel.Text = _good.name;
			this.Text = _good.name;
			DetailsLabel.Text = _good.details;
			_feedBacks = _entityBL.GetAllFeedBackByProduct(_good.id);

		}

		private void SortList_SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(SortList.SelectedIndex.ToString());
			List<FeedBackDTO> _feedBacks1 = _entityBL.SortFeedBacks(_feedBacks, SortList.SelectedIndex + 1);
			Reviews.Controls.Clear();

			foreach (FeedBackDTO feed in _feedBacks1)
			{
				Label label = new Label();
				label.Size = new Size(600, 1000);
				label.Text = feed.text + $"\n {_entityBL.GetUserById(feed.user_id).first_name} {_entityBL.GetUserById(feed.user_id).last_name} \n {feed.Date.ToString()}";
				Reviews.Controls.Add(label);
			}
		}

		private void SearchTextBox_Click(object sender, EventArgs e)
		{
			SearchTextBox.Text = "";
		}


		private void ProductForm_Load(object sender, EventArgs e)
		{
			foreach (FeedBackDTO feed in _feedBacks)
			{
				Label label = new Label();
				label.Size = new Size(400, 1000);
				label.Text = feed.text + $"\n {_entityBL.GetUserById(feed.user_id).first_name} {_entityBL.GetUserById(feed.user_id).last_name} \n {feed.Date.ToString()}";
				Reviews.Controls.Add(label);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			string name = SearchTextBox.Text;
			List<FeedBackDTO> _feedBacks1 = _entityBL.SearchFeedBackLogin(_feedBacks, name);
			Reviews.Controls.Clear();

			foreach (FeedBackDTO feed in _feedBacks1)
			{
				Label label = new Label();
				label.Size = new Size(600, 1000);
				label.Text = feed.text + $"\n {_entityBL.GetUserById(feed.user_id).first_name} {_entityBL.GetUserById(feed.user_id).last_name} \n {feed.Date.ToString()}";
				Reviews.Controls.Add(label);
			}
		}
	}
}
