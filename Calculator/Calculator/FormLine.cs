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
	public partial class FormLine : Form
	{
		public FormLine()
		{
			InitializeComponent();
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.linLayout);
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
			g.TranslateTransform((float)wx/2, (float)wy/2);
			
			int ky = (int)(0.75 * wy/2); //200;
			int kx = (int)(0.75 * wx/2);
			float alfa = 0.0F;			
			float ox = (float) Math.Sin(alfa);
			float oy = ky * (float)Math.Cos(alfa); // Предыдущие значения
			float cx = ox, cy; // Текущие значения
			int k;
			int fi;
			k = this.trackBar1.Value;
			fi = this.trackBar2.Value;
			for (alfa = 0; alfa < 720; alfa++)
			{
				 
				cx = (float)Math.Sin(alfa*Math.PI/180)*kx;
				cy = (float)Math.Cos(k*(alfa + fi) *Math.PI/180)*ky;
				if ( cx > wx/2) break;
			    g.DrawLine(pen, ox, Y(oy), cx, Y(cy));
				ox = cx;
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
		private void linLayout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
//		    int wy = this.Height;
//			int wx = this.Width;
			Button1Click(sender, e);
		}
	    void FormLineShown(object sender, System.EventArgs e)
		{
			Graphics();
		}
	    void FormLinePaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics();
		}
	
		
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			Graphics();
		}
		
		void TrackBar2ValueChanged(object sender, EventArgs e)
		{
			Graphics();
		}
	}
}
