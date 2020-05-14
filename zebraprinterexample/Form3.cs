using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zebraprinterexample.Properties;

namespace zebraprinterexample
{
	public partial class Form3 : Form
	{
		public string newPrinterName { get; set; }

		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			newPrinterName = printerNameText.Text;
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			printerNameText.Text = Settings.Default["currentPrinterName"].ToString();
		}
	}
}
