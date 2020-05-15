namespace zebraprinterexample
{
	partial class Form1
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
			this.printLabel = new System.Windows.Forms.Button();
			this.printSummary = new System.Windows.Forms.Button();
			this.startLabel = new System.Windows.Forms.Label();
			this.stopLabel = new System.Windows.Forms.Label();
			this.startLabelText = new System.Windows.Forms.Label();
			this.stopLabelText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.group = new System.Windows.Forms.Label();
			this.numberOfLabel = new System.Windows.Forms.Label();
			this.groupText = new System.Windows.Forms.Label();
			this.numberOfLabelText = new System.Windows.Forms.Label();
			this.settingLabel = new System.Windows.Forms.Button();
			this.printerButton = new System.Windows.Forms.Button();
			this.labelSetting = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// printLabel
			// 
			this.printLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.printLabel.Location = new System.Drawing.Point(37, 284);
			this.printLabel.Name = "printLabel";
			this.printLabel.Size = new System.Drawing.Size(228, 56);
			this.printLabel.TabIndex = 0;
			this.printLabel.Text = "打印标签";
			this.printLabel.UseVisualStyleBackColor = true;
			this.printLabel.Click += new System.EventHandler(this.buttonSEND_Click);
			// 
			// printSummary
			// 
			this.printSummary.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.printSummary.Location = new System.Drawing.Point(37, 346);
			this.printSummary.Name = "printSummary";
			this.printSummary.Size = new System.Drawing.Size(228, 56);
			this.printSummary.TabIndex = 1;
			this.printSummary.Text = "当日总表";
			this.printSummary.UseVisualStyleBackColor = true;
			this.printSummary.Click += new System.EventHandler(this.printSummary_Click);
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.startLabel.Location = new System.Drawing.Point(41, 18);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(69, 35);
			this.startLabel.TabIndex = 2;
			this.startLabel.Text = "起始";
			// 
			// stopLabel
			// 
			this.stopLabel.AutoSize = true;
			this.stopLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.stopLabel.Location = new System.Drawing.Point(205, 18);
			this.stopLabel.Name = "stopLabel";
			this.stopLabel.Size = new System.Drawing.Size(69, 35);
			this.stopLabel.TabIndex = 3;
			this.stopLabel.Text = "结束";
			// 
			// startLabelText
			// 
			this.startLabelText.AutoSize = true;
			this.startLabelText.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.startLabelText.ForeColor = System.Drawing.Color.Red;
			this.startLabelText.Location = new System.Drawing.Point(16, 56);
			this.startLabelText.Name = "startLabelText";
			this.startLabelText.Size = new System.Drawing.Size(0, 35);
			this.startLabelText.TabIndex = 4;
			// 
			// stopLabelText
			// 
			this.stopLabelText.AutoSize = true;
			this.stopLabelText.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.stopLabelText.ForeColor = System.Drawing.Color.Red;
			this.stopLabelText.Location = new System.Drawing.Point(192, 56);
			this.stopLabelText.Name = "stopLabelText";
			this.stopLabelText.Size = new System.Drawing.Size(0, 35);
			this.stopLabelText.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(145, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 28);
			this.label1.TabIndex = 6;
			this.label1.Text = "~";
			// 
			// group
			// 
			this.group.AutoSize = true;
			this.group.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.group.Location = new System.Drawing.Point(85, 116);
			this.group.Name = "group";
			this.group.Size = new System.Drawing.Size(69, 35);
			this.group.TabIndex = 7;
			this.group.Text = "组别";
			// 
			// numberOfLabel
			// 
			this.numberOfLabel.AutoSize = true;
			this.numberOfLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.numberOfLabel.Location = new System.Drawing.Point(85, 169);
			this.numberOfLabel.Name = "numberOfLabel";
			this.numberOfLabel.Size = new System.Drawing.Size(69, 35);
			this.numberOfLabel.TabIndex = 8;
			this.numberOfLabel.Text = "例数";
			// 
			// groupText
			// 
			this.groupText.AutoSize = true;
			this.groupText.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.groupText.ForeColor = System.Drawing.Color.Red;
			this.groupText.Location = new System.Drawing.Point(154, 116);
			this.groupText.Name = "groupText";
			this.groupText.Size = new System.Drawing.Size(0, 35);
			this.groupText.TabIndex = 9;
			// 
			// numberOfLabelText
			// 
			this.numberOfLabelText.AutoSize = true;
			this.numberOfLabelText.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.numberOfLabelText.ForeColor = System.Drawing.Color.Red;
			this.numberOfLabelText.Location = new System.Drawing.Point(154, 169);
			this.numberOfLabelText.Name = "numberOfLabelText";
			this.numberOfLabelText.Size = new System.Drawing.Size(0, 35);
			this.numberOfLabelText.TabIndex = 10;
			// 
			// settingLabel
			// 
			this.settingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.settingLabel.Location = new System.Drawing.Point(37, 222);
			this.settingLabel.Name = "settingLabel";
			this.settingLabel.Size = new System.Drawing.Size(228, 56);
			this.settingLabel.TabIndex = 11;
			this.settingLabel.Text = "设置";
			this.settingLabel.UseVisualStyleBackColor = true;
			this.settingLabel.Click += new System.EventHandler(this.settingLabel_Click);
			// 
			// printerButton
			// 
			this.printerButton.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.printerButton.Location = new System.Drawing.Point(37, 408);
			this.printerButton.Name = "printerButton";
			this.printerButton.Size = new System.Drawing.Size(228, 56);
			this.printerButton.TabIndex = 12;
			this.printerButton.Text = "打印机设置";
			this.printerButton.UseVisualStyleBackColor = true;
			this.printerButton.Click += new System.EventHandler(this.printerButton_Click);
			// 
			// labelSetting
			// 
			this.labelSetting.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
			this.labelSetting.Location = new System.Drawing.Point(37, 470);
			this.labelSetting.Name = "labelSetting";
			this.labelSetting.Size = new System.Drawing.Size(228, 56);
			this.labelSetting.TabIndex = 13;
			this.labelSetting.Text = "标签设置";
			this.labelSetting.UseVisualStyleBackColor = true;
			this.labelSetting.Click += new System.EventHandler(this.labelSetting_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 539);
			this.Controls.Add(this.labelSetting);
			this.Controls.Add(this.printerButton);
			this.Controls.Add(this.settingLabel);
			this.Controls.Add(this.numberOfLabelText);
			this.Controls.Add(this.groupText);
			this.Controls.Add(this.numberOfLabel);
			this.Controls.Add(this.group);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stopLabelText);
			this.Controls.Add(this.startLabelText);
			this.Controls.Add(this.stopLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.printSummary);
			this.Controls.Add(this.printLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "病理号标签打印程序";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button printLabel;
		private System.Windows.Forms.Button printSummary;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label stopLabel;
		private System.Windows.Forms.Label startLabelText;
		private System.Windows.Forms.Label stopLabelText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label group;
		private System.Windows.Forms.Label numberOfLabel;
		private System.Windows.Forms.Label groupText;
		private System.Windows.Forms.Label numberOfLabelText;
		private System.Windows.Forms.Button settingLabel;
		private System.Windows.Forms.Button printerButton;
		private System.Windows.Forms.Button labelSetting;
	}
}

