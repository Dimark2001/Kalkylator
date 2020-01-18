using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using  System.Collections.Generic;

namespace Calculator
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class FormSelectGraph : Form
	{
		Thread th;
		List<Thread> threadList = new List<Thread>();
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
		void exitButtonClick(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			
			th = new Thread(exit);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			foreach (Thread t in threadList) {
				t.Abort();
			}
			this.Close();
		}
		void startButtonClick(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
//			FormSquare form = new FormSquare();
			
			switch (pressedRb.TabIndex) {
				case 5: th = new Thread(CosRun);
						break;
				case 6: th = new Thread(SinRun);
						break;
				case 7: th = new Thread(SqaureRun);
						break;
				case 8: th = new Thread(LineRun);
						break;
				default: th = new Thread(SqaureRun);
						break;
				
			}
			
			
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			threadList.Add(th);
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
			pressedRb = rb;
			
		}
		
	}
}
