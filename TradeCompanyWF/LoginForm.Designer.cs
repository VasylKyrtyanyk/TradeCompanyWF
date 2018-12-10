namespace TradeCompanyWF
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.PassTextBox = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(146, 106);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
			this.EmailTextBox.TabIndex = 0;
			// 
			// PassTextBox
			// 
			this.PassTextBox.Location = new System.Drawing.Point(146, 132);
			this.PassTextBox.Name = "PassTextBox";
			this.PassTextBox.PasswordChar = '*';
			this.PassTextBox.Size = new System.Drawing.Size(100, 20);
			this.PassTextBox.TabIndex = 1;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(160, 158);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.PassTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(400, 300);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox PassTextBox;
		private System.Windows.Forms.Button LoginButton;
	}
}