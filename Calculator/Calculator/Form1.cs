using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnexit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btndot_Click(object sender, EventArgs e)
		{
			txtstore.Text += ".";
		}

		private void btnzero_Click(object sender, EventArgs e)
		{
			txtstore.Text += "0";

		}

		private void btnone_Click(object sender, EventArgs e)
		{
			txtstore.Text += "1";

		}

		private void btntwo_Click(object sender, EventArgs e)
		{
			txtstore.Text += "2";

		}

		private void btnthree_Click(object sender, EventArgs e)
		{
			txtstore.Text += "3";

		}

		private void btnfour_Click(object sender, EventArgs e)
		{
			txtstore.Text += "4";

		}

		private void btnfive_Click(object sender, EventArgs e)
		{
			txtstore.Text += "5";

		}

		private void btnsix_Click(object sender, EventArgs e)
		{
			txtstore.Text += "6";

		}

		private void btnseven_Click(object sender, EventArgs e)
		{
			txtstore.Text += "7";

		}

		private void btneight_Click(object sender, EventArgs e)
		{
			txtstore.Text += "8";

		}

		private void btnnine_Click(object sender, EventArgs e)
		{
			txtstore.Text += "9";

		}

		private void btnclear_Click(object sender, EventArgs e)
		{
			txtstore.Clear();
			txtresult.Clear();
		}


		float num;
		int count;
		private void btnminus_Click(object sender, EventArgs e)
		{
			if (txtstore.Text != "")
			{
				num = float.Parse(txtstore.Text);
				txtresult.Text =txtstore.Text +"-";
				txtstore.Clear();
				count = 1;
			}
		}

		private void btnplus_Click(object sender, EventArgs e)
		{
			if (txtstore.Text != "")
			{
				num = float.Parse(txtstore.Text);
				txtresult.Text =txtstore.Text + "+";
				txtstore.Clear();
				count = 2;
			}
		}

		private void btnmulti_Click(object sender, EventArgs e)
		{
			if (txtstore.Text != "")
			{
				num = float.Parse(txtstore.Text);
				txtresult.Text = txtstore.Text + "x";
				txtstore.Clear();
				count = 3;
			}
		}

		private void btndiv_Click(object sender, EventArgs e)
		{
			if (txtstore.Text != "")
			{
				num = float.Parse(txtstore.Text);
				txtresult.Text = txtstore.Text + "/" ;
				txtstore.Clear();
				count = 4;
			}
		}

		private void btnmod_Click(object sender, EventArgs e)
		{
			if (txtstore.Text != "")
			{
				num = float.Parse(txtstore.Text);
				txtresult.Text =  txtstore.Text + "%";
				txtstore.Clear();
				count = 5;
			}
		}

		private void btnequal_Click(object sender, EventArgs e)
		{
			float answer;
			switch (count)
			{
				case 1:
					answer = num - float.Parse(txtstore.Text);
					txtresult.Text = txtresult.Text + txtstore.Text + "=" + answer;
					txtstore.Text = answer.ToString();
					break;
				case 2:
					answer = num + float.Parse(txtstore.Text);
					txtresult.Text = txtresult.Text + txtstore.Text + "=" + answer;
					txtstore.Text = answer.ToString();
					break;
				case 3:
					answer = num * float.Parse(txtstore.Text);
					txtresult.Text = txtresult.Text + txtstore.Text + "=" + answer;
					txtstore.Text = answer.ToString();
					break;
				case 4:
					answer = num / float.Parse(txtstore.Text);
					txtresult.Text = txtresult.Text + txtstore.Text + "=" + answer;
					txtstore.Text = answer.ToString();
					break;
				case 5:
					answer = num % float.Parse(txtstore.Text);
					txtresult.Text = txtresult.Text + txtstore.Text + "=" + answer;
					txtstore.Text = answer.ToString();
					break;
				default:
					break;
			}
		}
	}
}
