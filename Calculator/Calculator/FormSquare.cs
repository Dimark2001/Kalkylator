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
	public partial class FormSquare : Form
	{
	
		public FormSquare()
		{
			InitializeComponent();
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SquareLayout);
			Graphics();
		}
		void Form3Load(object sender, System.EventArgs e)
		{
		
		}
		private float Y(float y)
		{
			float wy = (float)this.Height;
				
				return  - y;
		}
		void Graphics()
		{
			Graphics g = this.CreateGraphics();
			Pen pen = new Pen(Color.Blue);
			Pen pe = new Pen(Color.Red);
			g.Clear(Color.White);
			
			int wy = this.Height;
			int wx = this.Width;
			float a = float.Parse(textBox1.Text);
			float b = float.Parse(textBox11.Text);
			// Parabola y = ax^2 +b
			float cx = 0F, cy; // Текущие значения
			float ox = 0.0F, oy = 0.0F; // Предыдущие значения
			float sx = 1.0F;
			int k = 50;	
			g.TranslateTransform((float)wx/2, (float)wy/2);
			while (true)
			{
				float x = (cx + sx) / k;
				cy = k * (a* x * x + b);
				if (cy > wy/2 || cx > wx/2) break;
			    g.DrawLine(pen, ox, Y(oy), cx, Y(cy));
			    g.DrawLine(pen, -ox, Y(oy), -cx, Y(cy)); // т.к. симметричная
				ox = cx;
				cx += sx;
				oy = cy;				
			}
			
			g.DrawLine(pe, 0, Y(-wy/2), 0, Y(wy/2));
			g.DrawLine(pe, 0, Y(wy/2), 20, Y(wy/2-20));
			g.DrawLine(pe, 0, Y(wy/2), -20, Y(wy/2-20));
			g.DrawLine(pe, -wx/2, 0, wx/2, 0);
			g.DrawLine(pe, wx/2-8, 0, wx/2-30, -20);
			g.DrawLine(pe, wx/2-8, 0, wx/2-30, 20);
			
			for (int i = k; i < wx/2-20; i += k) {
				g.DrawLine(pe, i, 5, i, -5);
				g.DrawLine(pe, -i, 5, -i, -5);
				int t = (int)(i / k);
				int tt = -t;
				g.DrawString(t.ToString(), Font, Brushes.Black, i-5, 16);
				g.DrawString(tt.ToString(), Font, Brushes.Black, -i-5, 16);
			}
			for (int i = 0; i < wy/2-20; i += k) {
				g.DrawLine(pe, -5, i, 5, i);
				g.DrawLine(pe, -5, -i, 5, -i);
				int t = (int)(i / k);
				int tt = -t;
				g.DrawString(t.ToString(), Font, Brushes.Black, -20, -i - 10);
				g.DrawString(tt.ToString(), Font, Brushes.Black, -20, i - 10);
			}
			
			string name = "Лёшик балбес ";
			int n = name.Length;
			float angleStep = 360 / n;
			Char[] c;
			c = name.ToCharArray(0,name.Length);
			Font f  = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			for (int i=0; i<n; i++)
			{
				string s = string.Join("",c[i]);
				g.RotateTransform(angleStep);
				g.DrawString(s, f, Brushes.Black, 0, -60);
			}
			g.ResetTransform();
			
		}
		void Button1Click(object sender, System.EventArgs e)
		{			
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	    private void SquareLayout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
		    int wy = this.Height;
			int wx = this.Width;
			Debug.WriteLine("x=" + wx.ToString());
			Debug.WriteLine("y=" + wy.ToString());
			Button1Click(sender, e);
		}
	    void FormSquareShown(object sender, System.EventArgs e)
		{
			Graphics();
		}
		
		void FormSquarePaint(object sender, PaintEventArgs e)
		{
			Graphics();
		}
	}
}
