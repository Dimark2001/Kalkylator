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
		
		private	Pen pen = new Pen(Color.Blue);
		private Pen pe = new Pen(Color.Red);
		
		private float Y(float y)
		{
			float wy = (float)this.Height;
				
				return  - y;
		}
		private void drawSin(Graphics g, int wx, int wy)
		{
			int ky = (int)(0.75 * wy/2); //Масштаб по Y, 1 - 75% высоты окна
			int kx = 1;			// Коэффициент по Х на будущее
			float ox = -kx*(wx/2); // Левая граница окна, минимальное значение
			float oy = ky * (float)Math.Sin(ox*Math.PI/180); // Перврое значения
			float cx, cy; // Текущие значения
			const float sx = 1.0F; //шаг по х в градусах
			for (cx = ox; cx < wx/2; cx += sx)
			{
				float x = (cx + sx);
				cy = ky * (float)Math.Sin(x*Math.PI/180);
			    g.DrawLine(pen, ox, Y(oy), cx, Y(cy));
				ox = cx;
				oy = cy;
				cx += sx;
			}
		}
		private void drawCos(Graphics g, int wx, int wy)
		{
			int ky = (int)(0.75 * wy/2); //Масштаб по Y, 1 - 75% высоты окна
			int kx = 1;			// Коэффициент по Х на будущее
			float ox = -kx*(wx/2); // Левая граница окна, минимальное значение
			float oy = ky * (float)Math.Cos(ox*Math.PI/180); // Перврое значения
			float cx, cy; // Текущие значения
			const float sx = 1.0F; //шаг по х в градусах
			for (cx = ox; cx < wx/2; cx += sx)
			{
				float x = (cx + sx);
				cy = ky * (float)Math.Cos(x*Math.PI/180);
			    g.DrawLine(pen, ox, Y(oy), cx, Y(cy));
				ox = cx;
				oy = cy;
				cx += sx;
			}
		}
		void Graphics()
		{
			Graphics g = this.CreateGraphics();

			g.Clear(Color.White);
			int wy = this.Height;
			int wx = this.Width;
			int ky = (int)(0.75 * wy/2); //Масштаб по Y, 1 - 75% высоты окна
			int kx = 1;
			g.TranslateTransform((float)wx/2, (float)wy/2);
			
			if (this.sinCheckBox.Checked)
			{
				drawSin(g, wx, wy);
			}
			
			
			if (this.cosCheckBox.Checked)
			{
				drawCos(g, wx, wy);
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
		void SinCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			Graphics();
		}
		void CosCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			Graphics();
		}
	}
}
