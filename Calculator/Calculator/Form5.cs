/*
 * Created by SharpDevelop.
 * User: Intel
 * Date: 11.12.2019
 * Time: 19:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}
		void Graphics()
		{
			Graphics g = this.CreateGraphics();
			Pen pen = new Pen(Color.Blue);
			Pen pe = new Pen(Color.Red);
			g.Clear(Color.White);
			g.TranslateTransform(250.0F, 250.0F);
			
			int x = int.Parse(textBox1.Text);
			int y = 2*x;
			g.DrawLine(pen, x, y, -x, -y);
				
				
			g.DrawLine(pe, 0, -1000, 0, 1000);
			g.DrawLine(pe, -1000, 0, 1000, 0);
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
		
		}
		void Button3Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
