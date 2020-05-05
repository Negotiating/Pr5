using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR5_1_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private double function(double x)
		{
			try
			{
				if (x == -2) { throw new Exception(); }
				else return 3 / (Math.Abs(Math.Pow(x, 3) + 8));
			}
			catch
			{
				throw;
			}
		}
		private void calculate2_Click(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(border1.Text);
			double b = Convert.ToDouble(border2.Text);
			double h = Convert.ToDouble(step.Text);
			try
			{
				if (h <= 0) throw new Exception();
			}
			catch
			{
				MessageBox.Show("Некорректное значение шага");
			}
			string rez = "";
			for (double i = a; i <= b; i += h)
			{
				try
				{
					rez+= $"y({i}) = {function(i)}"+"\n";
				}
				catch
				{
					rez += $"y({i}) = error"+"\n";
				}
			}
			tabel.Text = rez;
		}

		private void border1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
			{
				e.Handled = true;
			}
		}
	}
}
