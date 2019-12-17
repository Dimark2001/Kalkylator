using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Thread th;
		
		double pi = Math.PI;
		float a, b;
		int count;
		bool znak = true;
		private void calculate()
        {
            switch(count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
 
                default:
                    break;
            }
 
        }
		public MainForm()
		{

			InitializeComponent();

		}
		void exit(object obj)
		{
			Application.Run(new Form6());
		}
		void Button13Click(object sender, System.EventArgs e)
		{
			th = new Thread(exit);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 1;
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 2;
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 3;
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 4;
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 5;
		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 6;
		}
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 7;
		}
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 8;
		}
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 9;
		}
		void Button0Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 0;
		}
		void PointClick(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + ",";
		}
		void SumClick(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
		}
		void DifClick(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
		}
		void MulClick(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
		}
		void DivClick(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
		}

		void CClick(object sender, EventArgs e)
		{
			textBox1.Text = "";
            label1.Text = "";
		}
		void CeClick(object sender, EventArgs e)
		{
			int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
		}
		void ZnakkClick(object sender, EventArgs e)
		{
			if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text=textBox1.Text.Replace("-", "");
                znak = true;
            }
		}
		void Button10Click(object sender, EventArgs e)
		{
			calculate();
            label1.Text = "";
		}
		void Button16Click(object sender, EventArgs e)
		{
			string text1 = textBox1.Text;
            double a = Convert.ToDouble (text1);
            a=Math.Sqrt(a);
            textBox1.Text = a.ToString();
		}
		void Button11Click(object sender, EventArgs e)
		{
			string text1 = textBox1.Text;
			double a = Convert.ToDouble (text1);
			a = a*a;
			textBox1.Text = a.ToString();
		}
		void Button15Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + pi;
		}
		void Button12Click(object sender, EventArgs e)
		{
			string text1 = textBox1.Text;
			double a = Convert.ToDouble (text1);
			a = a*a*a;
			textBox1.Text = a.ToString();
		}
	}
}