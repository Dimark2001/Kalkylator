using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		Thread th;
		public Form4()
		{
			InitializeComponent();
		}
		void exit(object obj)
		{
			Application.Run(new Form6());
		}
		void open(object obj)
		{
			Application.Run(new Form1());
		}
		void open1(object obj)
		{
			Application.Run(new Form2());
		}
		void open2(object obj)
		{
			Application.Run(new Form3());
		}
		void open3(object obj)
		{
			Application.Run(new Form5());
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			th = new Thread(exit);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void RadioButton4Click(object sender, System.EventArgs e)
		{
			th = new Thread(open3);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		void RadioButton3Click(object sender, System.EventArgs e)
		{
			th = new Thread(open2);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		void RadioButton2Click(object sender, System.EventArgs e)
		{
			th = new Thread(open1);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		void RadioButton1Click(object sender, System.EventArgs e)
		{
			th = new Thread(open);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		
	}
}
