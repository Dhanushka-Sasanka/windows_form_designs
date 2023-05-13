namespace FirstWindowsFormApplication
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			label2 = new Label();
			LOGIN = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(33, 126);
			label1.Name = "label1";
			label1.Size = new Size(93, 18);
			label1.TabIndex = 0;
			label1.Text = "USERNAME";
			label1.Click += label1_Click;
			// 
			// txtUserName
			// 
			txtUserName.AllowDrop = true;
			txtUserName.BackColor = SystemColors.Window;
			txtUserName.BorderStyle = BorderStyle.FixedSingle;
			txtUserName.Cursor = Cursors.Hand;
			txtUserName.Location = new Point(33, 147);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(259, 23);
			txtUserName.TabIndex = 1;
			txtUserName.TextChanged += textBox1_TextChanged;
			// 
			// txtPassword
			// 
			txtPassword.AllowDrop = true;
			txtPassword.BackColor = SystemColors.Window;
			txtPassword.BorderStyle = BorderStyle.FixedSingle;
			txtPassword.Cursor = Cursors.Hand;
			txtPassword.Location = new Point(33, 206);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(259, 23);
			txtPassword.TabIndex = 3;
			txtPassword.TextChanged += textBox2_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(33, 185);
			label2.Name = "label2";
			label2.Size = new Size(97, 18);
			label2.TabIndex = 2;
			label2.Text = "PASSWORD";
			label2.Click += label2_Click;
			// 
			// LOGIN
			// 
			LOGIN.BackColor = Color.CadetBlue;
			LOGIN.FlatStyle = FlatStyle.Popup;
			LOGIN.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
			LOGIN.ForeColor = Color.White;
			LOGIN.Location = new Point(172, 255);
			LOGIN.Name = "LOGIN";
			LOGIN.Size = new Size(120, 33);
			LOGIN.TabIndex = 4;
			LOGIN.Text = "LOGIN";
			LOGIN.UseVisualStyleBackColor = false;
			LOGIN.Click += LOGIN_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(640, 366);
			Controls.Add(LOGIN);
			Controls.Add(txtPassword);
			Controls.Add(label2);
			Controls.Add(txtUserName);
			Controls.Add(label1);
			Name = "Form1";
			Text = "LoginForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtUserName;
		private TextBox txtPassword;
		private Label label2;
		private Button LOGIN;
	}
}