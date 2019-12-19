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
using System.Diagnostics;

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
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form3Layout); 
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
			//g.TranslateTransform(450.0F, 250.0F);
			
			int wy = this.Height;
			int wx = this.Width;
			Debug.WriteLine("x=" + wx.ToString());
			Debug.WriteLine("y=" + wy.ToString());
			g.TranslateTransform((float)wx/2, (float)wy/2);
			//g.RotateTransform(180F);
			
			
			//зеркалируем относительно Х, чтов Y вверх рос
			g.ScaleTransform(1, -1);
			
			float a = float.Parse(textBox1.Text);
			float b = float.Parse(textBox11.Text);
			// Parabola y = ax^2 +b
			float cx = 0F, cy; // Текущие щ=значения
			float ox = 0.0F, oy = 0.0F; // Предыдущие значения
			float sx = 0.1F;			
			while (true)
			{
				cy = a* (cx + sx) * (cx + sx) + b;
				if (cy > wy/2) break;
				g.DrawLine(pen, ox, oy, cx, cy);
				g.DrawLine(pen, -ox, oy, -cx, cy); // т.к. симметричная
				ox = cx;
				cx += sx;
				oy = cy;
				
			}
			
			g.DrawLine(pe, 0, -wy/2, 0, wy/2);
			g.DrawLine(pe, 0, wy/2, 20, wy/2-20);
			g.DrawLine(pe, 0, wy/2, -20, wy/2-20);
			g.DrawLine(pe, -wx/2, 0, wx/2, 0);
			g.DrawLine(pe, wx/2-8, 0, wx/2-30, -20);
			g.DrawLine(pe, wx/2-8, 0, wx/2-30, 20);
			
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	    private void Form3Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
		    int wy = this.Height;
			int wx = this.Width;
			Debug.WriteLine("x=" + wx.ToString());
			Debug.WriteLine("y=" + wy.ToString());
			Graphics();
		}
	}
}
