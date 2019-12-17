using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{	
		public Form1()
		{
			InitializeComponent();
		}
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			
		}
		void Graphics()
		{
			Graphics g = this.CreateGraphics();
			Pen pen = new Pen(Color.Blue);
			Pen pe = new Pen(Color.Red);
			g.Clear(Color.White);
			g.TranslateTransform(0.0F, 250.0F);
			
			float x = int.Parse(textBox1.Text);
			int y = 0;
        {
            for (var i = 0; i < 3600; i++)
            {
                var dy = 100*(float)Math.Cos(i * Math.PI / 180);
                g.DrawLine(pen, x, y, ++x, y + dy);
            }
        }
        	g.DrawLine(pe, 180, -1000, 180, 1000);
			g.DrawLine(pe, -1000, 0, 1000, 0);
		}
		void Button1Click(object sender, EventArgs e)
		{
			Graphics();
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
