namespace TradeCompanyWF
{
	partial class ProductForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
			this.ProductPictureBox = new System.Windows.Forms.PictureBox();
			this.SortList = new System.Windows.Forms.ComboBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.Reviews = new System.Windows.Forms.TableLayoutPanel();
			this.DetailsLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ProductPictureBox
			// 
			this.ProductPictureBox.Location = new System.Drawing.Point(12, 12);
			this.ProductPictureBox.Name = "ProductPictureBox";
			this.ProductPictureBox.Size = new System.Drawing.Size(166, 166);
			this.ProductPictureBox.TabIndex = 0;
			this.ProductPictureBox.TabStop = false;
			// 
			// SortList
			// 
			this.SortList.FormattingEnabled = true;
			this.SortList.Items.AddRange(new object[] {
            "Sort By Login",
            "Sort By Date"});
			this.SortList.Location = new System.Drawing.Point(227, 12);
			this.SortList.Name = "SortList";
			this.SortList.Size = new System.Drawing.Size(123, 21);
			this.SortList.TabIndex = 1;
			this.SortList.SelectedIndexChanged += new System.EventHandler(this.SortList_SelectedIndexChanged);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(252, 65);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 2;
			this.SearchButton.Text = "Ok";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchTextBox.Location = new System.Drawing.Point(239, 39);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
			this.SearchTextBox.TabIndex = 3;
			this.SearchTextBox.Text = "Search";
			this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
			// 
			// Reviews
			// 
			this.Reviews.ColumnCount = 1;
			this.Reviews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Reviews.Dock = System.Windows.Forms.DockStyle.Right;
			this.Reviews.Location = new System.Drawing.Point(356, 0);
			this.Reviews.Name = "Reviews";
			this.Reviews.RowCount = 4;
			this.Reviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.Reviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
			this.Reviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
			this.Reviews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
			this.Reviews.Size = new System.Drawing.Size(438, 438);
			this.Reviews.TabIndex = 4;
			// 
			// DetailsLabel
			// 
			this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DetailsLabel.Location = new System.Drawing.Point(9, 287);
			this.DetailsLabel.Name = "DetailsLabel";
			this.DetailsLabel.Size = new System.Drawing.Size(330, 142);
			this.DetailsLabel.TabIndex = 5;
			this.DetailsLabel.Text = "DetailsLabel";
			this.DetailsLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(9, 181);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(169, 30);
			this.NameLabel.TabIndex = 6;
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(794, 438);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.DetailsLabel);
			this.Controls.Add(this.Reviews);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SortList);
			this.Controls.Add(this.ProductPictureBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProductForm";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ProductPictureBox;
		private System.Windows.Forms.ComboBox SortList;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.TableLayoutPanel Reviews;
		private System.Windows.Forms.Label DetailsLabel;
		private System.Windows.Forms.Label NameLabel;
	}
}