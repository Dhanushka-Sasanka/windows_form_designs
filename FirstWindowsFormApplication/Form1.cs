namespace FirstWindowsFormApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void LOGIN_Click(object sender, EventArgs e)
		{
			var username = txtUserName.Text;
			var password = txtPassword.Text;




			if (username == "ADMIN" && password == "1234")
			{
				Dashboard dashboard = new Dashboard();
				this.Hide();
				dashboard.Show();

			}
			else
			{

				MessageBox.Show("Opps Invalid Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}
	}
}