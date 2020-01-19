using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class FormCosinus : Form
	{	
		public FormCosinus()
		{
			InitializeComponent();
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.cosLayout);
			Graphics();
		}
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
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
//			Debug.WriteLine("draw!");
//			Debug.WriteLine("y=" + wy.ToString());
			g.TranslateTransform((float)wx/2, (float)wy/2);
			//g.RotateTransform(180F);
			
			
			//зеркалируем относительно Х, чтов Y вверх рос
//		g.ScaleTransform(1, -1);
			
//			float a = float.Parse(textBox1.Text);
//			float b = float.Parse(textBox11.Text);
			// не Parabola y = ax^2 +b
			
			int ky = (int)(0.75 * wy/2); //200;
			int kx = 1;			
			float ox = -kx*(wx/2), oy = ky * (float)Math.Sin(ox*Math.PI/180); // Предыдущие значения
			float cx = ox, cy; // Текущие значения
			float sx = 1.0F; //Math.PI/180;
			
			while (true)
			{
				float x = (cx + sx);
				cy = ky * (float)Math.Sin(x*Math.PI/180);
				if ( cx > wx/2) break;
			    g.DrawLine(pen, ox, Y(oy), cx, Y(cy));
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
			
			for (int i = 45; i < wx/2-10; i += 45) {
				g.DrawLine(pe, i, 5, i, -5);
				g.DrawLine(pe, -i, 5, -i, -5);
				int t = (int)(i / kx);
				int tt = -t;
				g.DrawString(t.ToString(), Font, Brushes.Black, i-5, 16);
				g.DrawString(tt.ToString(), Font, Brushes.Black, -i-5, 16);
			}
			for (int i = 0; i < wy/2-20; i += ky) {
				g.DrawLine(pe, -5, i, 5, i);
				g.DrawLine(pe, -5, -i, 5, -i);
				int t = (int)(i / ky);
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
//		g.ScaleTransform(1, -1);
			for (int i=0; i<n; i++)
			{
				string s = string.Join("",c[i]);
				g.RotateTransform(angleStep);
				g.DrawString(s, f, Brushes.Black, 0, -60);
			}
			g.ResetTransform();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		private void cosLayout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
		    int wy = this.Height;
			int wx = this.Width;
//			Debug.WriteLine("x=" + wx.ToString());
//			Debug.WriteLine("y=" + wy.ToString());
			Button1Click(sender, e);
		}
	    void FormCosinusShown(object sender, System.EventArgs e)
		{
			Graphics();
		}
	    void FormCosinusPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Debug.WriteLine("Paint");
			Graphics();
		}
	}
}
