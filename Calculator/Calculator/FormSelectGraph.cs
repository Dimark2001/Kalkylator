using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class FormSelectGraph : Form
	{
		Thread th;
		public FormSelectGraph()
		{
			InitializeComponent();
		}
		void exit(object obj)
		{
			Application.Run(new Form6());
		}
		void CosRun(object obj)
		{
			Application.Run(new FormCosinus());
		}
		void SinRun(object obj)
		{
			Application.Run(new FormSinus());
		}
		void SqaureRun(object obj)
		{
			Application.Run(new FormSquare());
		}
		void LineRun(object obj)
		{
			Application.Run(new FormLine());
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			
			th = new Thread(exit);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void startButtonClick(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			
			th = new Thread(exit);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}
		void lineRadioButtonClick(object sender, System.EventArgs e)
		{
			FormSinus form = new FormSinus();
			
//			th = new Thread(new ThreadStart(form.Graphics()));
//			th.SetApartmentState(ApartmentState.STA);
//			th.Start();
			
		}
		void squareRadioButtonClick(object sender, System.EventArgs e)
		{
			FormSquare form = new FormSquare();
			form.ShowDialog(); // Application.Run(form);
//			th = new Thread(open2);
//			th.SetApartmentState(ApartmentState.STA);
//			th.Start();
			
		}
		void sinRadioButtonClick(object sender, System.EventArgs e)
		{
			th = new Thread(SinRun);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		void cosRadioButtonClick(object sender, System.EventArgs e)
		{
			th = new Thread(CosRun);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			
		}
		
	}
}
