namespace zebraprinterexample
{
	partial class Form4
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
			this.barcodeXText = new System.Windows.Forms.TextBox();
			this.barcodePosition = new System.Windows.Forms.GroupBox();
			this.barcodeYText = new System.Windows.Forms.TextBox();
			this.barcodeX = new System.Windows.Forms.Label();
			this.barcodeY = new System.Windows.Forms.Label();
			this.numberPosition = new System.Windows.Forms.GroupBox();
			this.numberY = new System.Windows.Forms.Label();
			this.numberX = new System.Windows.Forms.Label();
			this.numberYText = new System.Windows.Forms.TextBox();
			this.numberXText = new System.Windows.Forms.TextBox();
			this.labelSettingButton = new System.Windows.Forms.Button();
			this.barcodePosition.SuspendLayout();
			this.numberPosition.SuspendLayout();
			this.SuspendLayout();
			// 
			// barcodeXText
			// 
			this.barcodeXText.Location = new System.Drawing.Point(19, 59);
			this.barcodeXText.Name = "barcodeXText";
			this.barcodeXText.Size = new System.Drawing.Size(71, 25);
			this.barcodeXText.TabIndex = 0;
			// 
			// barcodePosition
			// 
			this.barcodePosition.Controls.Add(this.barcodeY);
			this.barcodePosition.Controls.Add(this.barcodeX);
			this.barcodePosition.Controls.Add(this.barcodeYText);
			this.barcodePosition.Controls.Add(this.barcodeXText);
			this.barcodePosition.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.barcodePosition.Location = new System.Drawing.Point(37, 41);
			this.barcodePosition.Name = "barcodePosition";
			this.barcodePosition.Size = new System.Drawing.Size(235, 132);
			this.barcodePosition.TabIndex = 4;
			this.barcodePosition.TabStop = false;
			this.barcodePosition.Text = "条码位置";
			// 
			// barcodeYText
			// 
			this.barcodeYText.Location = new System.Drawing.Point(135, 59);
			this.barcodeYText.Name = "barcodeYText";
			this.barcodeYText.Size = new System.Drawing.Size(71, 25);
			this.barcodeYText.TabIndex = 1;
			// 
			// barcodeX
			// 
			this.barcodeX.AutoSize = true;
			this.barcodeX.Location = new System.Drawing.Point(43, 36);
			this.barcodeX.Name = "barcodeX";
			this.barcodeX.Size = new System.Drawing.Size(18, 20);
			this.barcodeX.TabIndex = 2;
			this.barcodeX.Text = "X";
			// 
			// barcodeY
			// 
			this.barcodeY.AutoSize = true;
			this.barcodeY.Location = new System.Drawing.Point(163, 36);
			this.barcodeY.Name = "barcodeY";
			this.barcodeY.Size = new System.Drawing.Size(17, 20);
			this.barcodeY.TabIndex = 3;
			this.barcodeY.Text = "Y";
			// 
			// numberPosition
			// 
			this.numberPosition.Controls.Add(this.numberY);
			this.numberPosition.Controls.Add(this.numberX);
			this.numberPosition.Controls.Add(this.numberYText);
			this.numberPosition.Controls.Add(this.numberXText);
			this.numberPosition.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.numberPosition.Location = new System.Drawing.Point(37, 205);
			this.numberPosition.Name = "numberPosition";
			this.numberPosition.Size = new System.Drawing.Size(235, 132);
			this.numberPosition.TabIndex = 5;
			this.numberPosition.TabStop = false;
			this.numberPosition.Text = "数字位置";
			// 
			// numberY
			// 
			this.numberY.AutoSize = true;
			this.numberY.Location = new System.Drawing.Point(163, 36);
			this.numberY.Name = "numberY";
			this.numberY.Size = new System.Drawing.Size(17, 20);
			this.numberY.TabIndex = 3;
			this.numberY.Text = "Y";
			// 
			// numberX
			// 
			this.numberX.AutoSize = true;
			this.numberX.Location = new System.Drawing.Point(43, 36);
			this.numberX.Name = "numberX";
			this.numberX.Size = new System.Drawing.Size(18, 20);
			this.numberX.TabIndex = 2;
			this.numberX.Text = "X";
			// 
			// numberYText
			// 
			this.numberYText.Location = new System.Drawing.Point(135, 59);
			this.numberYText.Name = "numberYText";
			this.numberYText.Size = new System.Drawing.Size(71, 25);
			this.numberYText.TabIndex = 1;
			// 
			// numberXText
			// 
			this.numberXText.Location = new System.Drawing.Point(19, 59);
			this.numberXText.Name = "numberXText";
			this.numberXText.Size = new System.Drawing.Size(71, 25);
			this.numberXText.TabIndex = 0;
			// 
			// labelSettingButton
			// 
			this.labelSettingButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.labelSettingButton.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
			this.labelSettingButton.Location = new System.Drawing.Point(56, 362);
			this.labelSettingButton.Name = "labelSettingButton";
			this.labelSettingButton.Size = new System.Drawing.Size(198, 65);
			this.labelSettingButton.TabIndex = 6;
			this.labelSettingButton.Text = "确定";
			this.labelSettingButton.UseVisualStyleBackColor = true;
			this.labelSettingButton.Click += new System.EventHandler(this.labelSettingButton_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 450);
			this.Controls.Add(this.labelSettingButton);
			this.Controls.Add(this.numberPosition);
			this.Controls.Add(this.barcodePosition);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form4";
			this.Text = "条码设置";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.barcodePosition.ResumeLayout(false);
			this.barcodePosition.PerformLayout();
			this.numberPosition.ResumeLayout(false);
			this.numberPosition.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox barcodeXText;
		private System.Windows.Forms.GroupBox barcodePosition;
		private System.Windows.Forms.Label barcodeY;
		private System.Windows.Forms.Label barcodeX;
		private System.Windows.Forms.TextBox barcodeYText;
		private System.Windows.Forms.GroupBox numberPosition;
		private System.Windows.Forms.Label numberY;
		private System.Windows.Forms.Label numberX;
		private System.Windows.Forms.TextBox numberYText;
		private System.Windows.Forms.TextBox numberXText;
		private System.Windows.Forms.Button labelSettingButton;
	}
}