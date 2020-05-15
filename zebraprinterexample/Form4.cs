using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zebraprinterexample.Properties;

namespace zebraprinterexample
{
	public partial class Form4 : Form
	{
		public string newbarcodeXText { get; set; }
		public string newbarcodeYText { get; set; }
		public string newnumberXText { get; set; }
		public string newnumberYText { get; set; }
		

		public Form4()
		{
			InitializeComponent();
		}

		private void labelSettingButton_Click(object sender, EventArgs e)
		{
			newbarcodeXText = barcodeXText.Text;
			newbarcodeYText = barcodeYText.Text;
			newnumberXText = numberXText.Text;
			newnumberYText = numberYText.Text;
	}

		private void Form4_Load(object sender, EventArgs e)
		{
			barcodeXText.Text = Settings.Default["barcodeX"].ToString();
			barcodeYText.Text = Settings.Default["barcodeY"].ToString();
			numberXText.Text =Settings.Default["numberX"].ToString();
			numberYText.Text= Settings.Default["numberY"].ToString();
		}
	}
}


