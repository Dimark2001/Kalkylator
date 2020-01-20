/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27.11.2019
 * Time: 17:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System.Diagnostics;
namespace Calculator
{
	partial class FormCosinus
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.sinCheckBox = new System.Windows.Forms.CheckBox();
			this.cosCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(2, 450);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "X";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(25, 450);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(33, 20);
			this.textBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(64, 450);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "построить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(364, 433);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Выход";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// sinCheckBox
			// 
			this.sinCheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sinCheckBox.Checked = true;
			this.sinCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sinCheckBox.Location = new System.Drawing.Point(12, 2);
			this.sinCheckBox.Name = "sinCheckBox";
			this.sinCheckBox.Size = new System.Drawing.Size(66, 24);
			this.sinCheckBox.TabIndex = 7;
			this.sinCheckBox.Text = "sin";
			this.sinCheckBox.UseVisualStyleBackColor = false;
			this.sinCheckBox.UseWaitCursor = true;
			this.sinCheckBox.CheckedChanged += new System.EventHandler(this.SinCheckBoxCheckedChanged);
			// 
			// cosCheckBox
			// 
			this.cosCheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cosCheckBox.Location = new System.Drawing.Point(96, 2);
			this.cosCheckBox.Name = "cosCheckBox";
			this.cosCheckBox.Size = new System.Drawing.Size(66, 24);
			this.cosCheckBox.TabIndex = 8;
			this.cosCheckBox.Text = "cos";
			this.cosCheckBox.UseVisualStyleBackColor = false;
			this.cosCheckBox.CheckedChanged += new System.EventHandler(this.CosCheckBoxCheckedChanged);
			// 
			// FormCosinus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(699, 479);
			this.Controls.Add(this.sinCheckBox);
			this.Controls.Add(this.cosCheckBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "FormCosinus";
			this.ShowIcon = false;
			this.Text = "Sin";
			this.Activated += new System.EventHandler(this.FormCosinusShown);
			this.Load += new System.EventHandler(this.FormCosinusLoad);
			this.Shown += new System.EventHandler(this.FormCosinusShown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCosinusPaint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private System.Windows.Forms.CheckBox sinCheckBox;
		private System.Windows.Forms.CheckBox cosCheckBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;

		
		void FormCosinusLoad(object sender, System.EventArgs e)
		{
			
		}
		
	}
}
