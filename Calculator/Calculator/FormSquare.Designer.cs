﻿/*
 * Created by SharpDevelop.
 * User: Intel
 * Date: 11.12.2019
 * Time: 19:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class FormSquare
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "a";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(12, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 20);
			this.label11.TabIndex = 5;
			this.label11.Text = "b";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(26, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(33, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "1,0";
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(26, 26);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(33, 20);
			this.textBox11.TabIndex = 5;
			this.textBox11.Text = "0";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Построить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitButton.Location = new System.Drawing.Point(12, 79);
			this.exitButton.Name = "button2";
			this.exitButton.Size = new System.Drawing.Size(87, 23);
			this.exitButton.TabIndex = 8;
			this.exitButton.Text = "Выход";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// FormSquare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(492, 473);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "FormSquare";
			this.ShowIcon = false;
			this.Text = "Парабола";
			this.Activated += new System.EventHandler(this.FormSquareShown);
			this.Load += new System.EventHandler(this.FormSquareLoad);
			this.Shown += new System.EventHandler(this.FormSquareShown);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Button button1;
		
		
		
		void FormSquareActivated(object sender, System.EventArgs e)
		{
			
		}
		
		void FormSquareLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
