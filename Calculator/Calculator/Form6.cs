using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		Thread th;
		public Form6()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void open()
		{
			Application.Run(new Form4());
		}
		void open1()
		{
			Application.Run(new MainForm());
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			th = new Thread(open);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			th = new Thread(open1);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void Button3Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
