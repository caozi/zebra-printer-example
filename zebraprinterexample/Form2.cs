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
	public partial class Form2 : Form
	{
		public string newStartLabelText { get; set; }
		public string newGroupText { get; set; }
		public string newNumberOfLabelText { get; set; }


		public Form2()
		{
			InitializeComponent();
		}

		private void settingOKButton_Click(object sender, EventArgs e)
		{
			newStartLabelText = startLabelText.Text;
			newGroupText = groupText.Text;
			newNumberOfLabelText = numberOfLabelText.Text;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			startLabelText.Text = Settings.Default["currentLabelNumber"].ToString();
		}
	}
}
