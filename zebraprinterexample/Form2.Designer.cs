namespace zebraprinterexample
{
	partial class Form2
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
			this.group = new System.Windows.Forms.Label();
			this.numberOfLabel = new System.Windows.Forms.Label();
			this.numberOfLabelText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.startLabelText = new System.Windows.Forms.TextBox();
			this.settingOKButton = new System.Windows.Forms.Button();
			this.groupText = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// group
			// 
			this.group.AutoSize = true;
			this.group.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.group.Location = new System.Drawing.Point(12, 106);
			this.group.Name = "group";
			this.group.Size = new System.Drawing.Size(117, 35);
			this.group.TabIndex = 8;
			this.group.Text = "组      别";
			// 
			// numberOfLabel
			// 
			this.numberOfLabel.AutoSize = true;
			this.numberOfLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.numberOfLabel.Location = new System.Drawing.Point(12, 172);
			this.numberOfLabel.Name = "numberOfLabel";
			this.numberOfLabel.Size = new System.Drawing.Size(117, 35);
			this.numberOfLabel.TabIndex = 9;
			this.numberOfLabel.Text = "例      数";
			// 
			// numberOfLabelText
			// 
			this.numberOfLabelText.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
			this.numberOfLabelText.Location = new System.Drawing.Point(155, 175);
			this.numberOfLabelText.Name = "numberOfLabelText";
			this.numberOfLabelText.Size = new System.Drawing.Size(109, 36);
			this.numberOfLabelText.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 35);
			this.label1.TabIndex = 11;
			this.label1.Text = "起始号码";
			// 
			// startLabelText
			// 
			this.startLabelText.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
			this.startLabelText.Location = new System.Drawing.Point(155, 42);
			this.startLabelText.Name = "startLabelText";
			this.startLabelText.Size = new System.Drawing.Size(109, 36);
			this.startLabelText.TabIndex = 12;
			// 
			// settingOKButton
			// 
			this.settingOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.settingOKButton.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.settingOKButton.Location = new System.Drawing.Point(18, 245);
			this.settingOKButton.Name = "settingOKButton";
			this.settingOKButton.Size = new System.Drawing.Size(246, 60);
			this.settingOKButton.TabIndex = 13;
			this.settingOKButton.Text = "确定";
			this.settingOKButton.UseVisualStyleBackColor = true;
			this.settingOKButton.Click += new System.EventHandler(this.settingOKButton_Click);
			// 
			// groupText
			// 
			this.groupText.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
			this.groupText.FormattingEnabled = true;
			this.groupText.Items.AddRange(new object[] {
            "肺组",
            "胃肠组",
            "盆组",
            "头颈组"});
			this.groupText.Location = new System.Drawing.Point(155, 109);
			this.groupText.Name = "groupText";
			this.groupText.Size = new System.Drawing.Size(109, 36);
			this.groupText.TabIndex = 14;
			this.groupText.Text = "选择组别";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 326);
			this.Controls.Add(this.groupText);
			this.Controls.Add(this.settingOKButton);
			this.Controls.Add(this.startLabelText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numberOfLabelText);
			this.Controls.Add(this.numberOfLabel);
			this.Controls.Add(this.group);
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "打印设置";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label group;
		private System.Windows.Forms.Label numberOfLabel;
		private System.Windows.Forms.TextBox numberOfLabelText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox startLabelText;
		private System.Windows.Forms.Button settingOKButton;
		private System.Windows.Forms.ComboBox groupText;
	}
}