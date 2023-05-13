namespace FirstWindowsFormApplication
{
	partial class Dashboard
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
			mainPanel = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			button1 = new Button();
			button2 = new Button();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(210, 56);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(670, 390);
			mainPanel.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(button1);
			flowLayoutPanel1.Controls.Add(button2);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(0, 53);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(204, 410);
			flowLayoutPanel1.TabIndex = 4;
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(3, 3);
			button1.Name = "button1";
			button1.Size = new Size(201, 45);
			button1.TabIndex = 0;
			button1.Text = "DASHBOARD";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.FlatStyle = FlatStyle.Popup;
			button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			button2.Location = new Point(3, 54);
			button2.Name = "button2";
			button2.Size = new Size(201, 45);
			button2.TabIndex = 1;
			button2.Text = "EMPLOYEE   ";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(893, 463);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(mainPanel);
			Name = "Dashboard";
			Text = "Dashboard";
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel mainPanel;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button button1;
		private Button button2;
	}
}