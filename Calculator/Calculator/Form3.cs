/*
 * Created by SharpDevelop.
 * User: Intel
 * Date: 11.12.2019
 * Time: 19:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		void Form3Load(object sender, System.EventArgs e)
		{
		}
		void Graphics()
		{
			Graphics g = this.CreateGraphics();
			Pen pen = new Pen(Color.Blue);
			Pen pe = new Pen(Color.Red);
			g.Clear(Color.White);
			g.TranslateTransform(250.0F, 250.0F);
			
			float y;
			int q = int.Parse(textBox1.Text);
			int a = q *(-1);
			
			if (q < 0)
			{
				for (int x = q; x < a; x++)
				{
					y = (x * x)*0.2F;
					g.DrawLine(pen, x, y, x, y + y/4);
				}
			}
			else
			{
				for (int x = q; x > a; x--)
				{
					y = -(x * x)*0.2F;
					g.DrawLine(pen, x, y, x, y + y/4);
				}
			}
			
			g.DrawLine(pe, 0, -1000, 0, 1000);
			g.DrawLine(pe, -1000, 0, 1000, 0);
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
