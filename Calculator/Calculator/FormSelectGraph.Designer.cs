/*
 * Created by SharpDevelop.
 * User: User
 * Date: 08.12.2019
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class FormSelectGraph
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		System.Windows.Forms.RadioButton pressedRb = new System.Windows.Forms.RadioButton();
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
			this.cosRadioBtn = new System.Windows.Forms.RadioButton();
			this.sinRadioBtn = new System.Windows.Forms.RadioButton();
			this.squareRadioBtn = new System.Windows.Forms.RadioButton();
			this.lineRadioBtn = new System.Windows.Forms.RadioButton();
			this.startButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выберите режим";
			// 
			// cosRadioBtn
			// 
			this.cosRadioBtn.AutoSize = true;
			this.cosRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(100)));
			this.cosRadioBtn.Location = new System.Drawing.Point(1, 41);
			this.cosRadioBtn.Name = "cosRadioBtn";
			this.cosRadioBtn.Size = new System.Drawing.Size(189, 21);
			this.cosRadioBtn.TabIndex = 5;
			this.cosRadioBtn.TabStop = true;
			this.cosRadioBtn.Text = "Построение косинуса";
			this.cosRadioBtn.UseVisualStyleBackColor = true;
			this.cosRadioBtn.Click += new System.EventHandler(this.graphSelectRadioButtonClick);
			// 
			// sinRadioBtn
			// 
			this.sinRadioBtn.AutoSize = true;
			this.sinRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(100)));
			this.sinRadioBtn.Location = new System.Drawing.Point(1, 79);
			this.sinRadioBtn.Name = "sinRadioBtn";
			this.sinRadioBtn.Size = new System.Drawing.Size(172, 21);
			this.sinRadioBtn.TabIndex = 6;
			this.sinRadioBtn.TabStop = true;
			this.sinRadioBtn.Text = "Построение синуса";
			this.sinRadioBtn.UseVisualStyleBackColor = true;
			this.sinRadioBtn.Click += new System.EventHandler(this.graphSelectRadioButtonClick);
			// 
			// squareRadioBtn
			// 
			this.squareRadioBtn.AutoSize = true;
			this.squareRadioBtn.Checked = true;
			this.squareRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(100)));
			this.squareRadioBtn.Location = new System.Drawing.Point(1, 123);
			this.squareRadioBtn.Name = "squareRadioBtn";
			this.squareRadioBtn.Size = new System.Drawing.Size(195, 21);
			this.squareRadioBtn.TabIndex = 7;
			this.squareRadioBtn.TabStop = true;
			this.squareRadioBtn.Text = "Псотроение параболы";
			this.squareRadioBtn.UseVisualStyleBackColor = true;
			this.squareRadioBtn.Click += new System.EventHandler(this.graphSelectRadioButtonClick);
			// 
			// lineRadioBtn
			// 
			this.lineRadioBtn.AutoSize = true;
			this.lineRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(100)));
			this.lineRadioBtn.Location = new System.Drawing.Point(1, 169);
			this.lineRadioBtn.Name = "lineRadioBtn";
			this.lineRadioBtn.Size = new System.Drawing.Size(262, 21);
			this.lineRadioBtn.TabIndex = 8;
			this.lineRadioBtn.TabStop = true;
			this.lineRadioBtn.Text = "Построение линейной функции";
			this.lineRadioBtn.UseVisualStyleBackColor = true;
			this.lineRadioBtn.Click += new System.EventHandler(this.graphSelectRadioButtonClick);
			// 
			// startButton
			// 
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startButton.Location = new System.Drawing.Point(20, 193);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(85, 23);
			this.startButton.TabIndex = 9;
			this.startButton.Text = "Построить";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exitButton.Location = new System.Drawing.Point(152, 193);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(85, 23);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "Выход";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormSelectGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 218);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.lineRadioBtn);
			this.Controls.Add(this.squareRadioBtn);
			this.Controls.Add(this.sinRadioBtn);
			this.Controls.Add(this.cosRadioBtn);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormSelectGraph";
			this.ShowIcon = false;
			this.Text = "Графопостроитель";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton cosRadioBtn;
		private System.Windows.Forms.RadioButton sinRadioBtn;
		private System.Windows.Forms.RadioButton squareRadioBtn;
		private System.Windows.Forms.RadioButton lineRadioBtn;
	}
}
