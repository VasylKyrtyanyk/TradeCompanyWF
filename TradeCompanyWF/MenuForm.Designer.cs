namespace TradeCompanyWF
{
	partial class MenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.UserPictureBox = new System.Windows.Forms.PictureBox();
			this.PhoneButton = new System.Windows.Forms.Button();
			this.laptopButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CategoryPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LogOut = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LogOut);
			this.panel1.Controls.Add(this.UserNameLabel);
			this.panel1.Controls.Add(this.UserPictureBox);
			this.panel1.Controls.Add(this.PhoneButton);
			this.panel1.Controls.Add(this.laptopButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 119);
			this.panel1.TabIndex = 0;
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserNameLabel.Location = new System.Drawing.Point(3, 70);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(100, 25);
			this.UserNameLabel.TabIndex = 5;
			this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UserPictureBox
			// 
			this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
			this.UserPictureBox.Location = new System.Drawing.Point(34, 21);
			this.UserPictureBox.Name = "UserPictureBox";
			this.UserPictureBox.Size = new System.Drawing.Size(41, 46);
			this.UserPictureBox.TabIndex = 4;
			this.UserPictureBox.TabStop = false;
			// 
			// PhoneButton
			// 
			this.PhoneButton.Location = new System.Drawing.Point(373, 51);
			this.PhoneButton.Name = "PhoneButton";
			this.PhoneButton.Size = new System.Drawing.Size(75, 23);
			this.PhoneButton.TabIndex = 2;
			this.PhoneButton.Text = "Phone\'s";
			this.PhoneButton.UseVisualStyleBackColor = true;
			// 
			// laptopButton
			// 
			this.laptopButton.Location = new System.Drawing.Point(292, 51);
			this.laptopButton.Name = "laptopButton";
			this.laptopButton.Size = new System.Drawing.Size(75, 23);
			this.laptopButton.TabIndex = 1;
			this.laptopButton.Text = "laptop\'s";
			this.laptopButton.UseVisualStyleBackColor = true;
			this.laptopButton.Click += new System.EventHandler(this.laptopButton_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(255, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Categories";
			// 
			// CategoryPanel
			// 
			this.CategoryPanel.BackColor = System.Drawing.SystemColors.HighlightText;
			this.CategoryPanel.ColumnCount = 2;
			this.CategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CategoryPanel.Location = new System.Drawing.Point(0, 137);
			this.CategoryPanel.Name = "CategoryPanel";
			this.CategoryPanel.RowCount = 2;
			this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CategoryPanel.Size = new System.Drawing.Size(784, 324);
			this.CategoryPanel.TabIndex = 1;
			// 
			// LogOut
			// 
			this.LogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut.BackgroundImage")));
			this.LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.LogOut.Location = new System.Drawing.Point(705, 3);
			this.LogOut.Name = "LogOut";
			this.LogOut.Size = new System.Drawing.Size(55, 45);
			this.LogOut.TabIndex = 6;
			this.LogOut.UseVisualStyleBackColor = true;
			this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.CategoryPanel);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MenuForm";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.MenuForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox UserPictureBox;
		private System.Windows.Forms.Button PhoneButton;
		private System.Windows.Forms.Button laptopButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label UserNameLabel;
		private System.Windows.Forms.TableLayoutPanel CategoryPanel;
		private System.Windows.Forms.Button LogOut;
	}
}