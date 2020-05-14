namespace zebraprinterexample
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.printerName = new System.Windows.Forms.Label();
			this.printerNameText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// printerName
			// 
			this.printerName.AutoSize = true;
			this.printerName.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
			this.printerName.Location = new System.Drawing.Point(65, 21);
			this.printerName.Name = "printerName";
			this.printerName.Size = new System.Drawing.Size(112, 27);
			this.printerName.TabIndex = 0;
			this.printerName.Text = "打印机名称";
			// 
			// printerNameText
			// 
			this.printerNameText.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.printerNameText.Location = new System.Drawing.Point(12, 63);
			this.printerNameText.Name = "printerNameText";
			this.printerNameText.Size = new System.Drawing.Size(231, 25);
			this.printerNameText.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
			this.button1.Location = new System.Drawing.Point(70, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 186);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.printerNameText);
			this.Controls.Add(this.printerName);
			this.Name = "Form3";
			this.Text = "打印机设置";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label printerName;
		private System.Windows.Forms.TextBox printerNameText;
		private System.Windows.Forms.Button button1;
	}
}