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
			//FormSquare form = new FormSquare();
			//form.ShowDialog();
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
//			FormSquare form = new FormSquare();
			th = new Thread(SqaureRun);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
//			this.Close();
		}
		void graphSelectRadioButtonClick(object sender, System.EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (rb == null)
		    {
		        MessageBox.Show("Sender is not a RadioButton");
		        return;
		    }

//			th = new Thread(new ThreadStart(form.Graphics()));
//			th.SetApartmentState(ApartmentState.STA);
//			th.Start();
			
		}
		
	}
}
