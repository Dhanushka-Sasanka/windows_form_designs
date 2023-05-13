using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FirstWindowsFormApplication
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormEmployee employeeForm = new FormEmployee();

			/*Form2 frmMyForm = (Form2)Application.OpenForms["formName"];
			frmMyForm.Show();*/


			employeeForm.TopLevel = false;
			employeeForm.TopMost = true;
			mainPanel.Controls.Add(employeeForm);
			employeeForm.Show();


		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
