using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using zebraprinterexample.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace zebraprinterexample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public class DOCINFOA
		{
			[MarshalAs(UnmanagedType.LPStr)]
			public string pDocName;
			[MarshalAs(UnmanagedType.LPStr)]
			public string pOutputFile;
			[MarshalAs(UnmanagedType.LPStr)]
			public string pDataType;
		}
		[DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

		[DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool ClosePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

		[DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool EndDocPrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool StartPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool EndPagePrinter(IntPtr hPrinter);

		[DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
		public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

		public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
		{
			Int32 dwError = 0, dwWritten = 0;
			IntPtr hPrinter = new IntPtr(0);
			DOCINFOA di = new DOCINFOA();
			bool bSuccess = false; // Assume failure unless you specifically succeed.
			di.pDocName = "My C#.NET RAW Document";
			di.pDataType = "RAW";

			// Open the printer.
			if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
			{
				// Start a document.
				if (StartDocPrinter(hPrinter, 1, di))
				{
					// Start a page.
					if (StartPagePrinter(hPrinter))
					{
						// Write your bytes.
						bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
						EndPagePrinter(hPrinter);
					}
					EndDocPrinter(hPrinter);
				}
				ClosePrinter(hPrinter);
			}
			// If you did not succeed, GetLastError may give more information
			// about why not.
			if (bSuccess == false)
			{
				dwError = Marshal.GetLastWin32Error();
			}
			return bSuccess;
		}

		public static bool SendFileToPrinter(string szPrinterName, string szFileName)
		{
			// Open the file.
			FileStream fs = new FileStream(szFileName, FileMode.Open);
			// Create a BinaryReader on the file.
			BinaryReader br = new BinaryReader(fs);
			// Dim an array of bytes big enough to hold the file's contents.
			Byte[] bytes = new Byte[fs.Length];
			bool bSuccess = false;
			// Your unmanaged pointer.
			IntPtr pUnmanagedBytes = new IntPtr(0);
			int nLength;

			nLength = Convert.ToInt32(fs.Length);
			// Read the contents of the file into the array.
			bytes = br.ReadBytes(nLength);
			// Allocate some unmanaged memory for those bytes.
			pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
			// Copy the managed byte array into the unmanaged array.
			Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
			// Send the unmanaged bytes to the printer.
			bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
			// Free the unmanaged memory that you allocated earlier.
			Marshal.FreeCoTaskMem(pUnmanagedBytes);
			fs.Close();
			return bSuccess;
		}

		public static bool SendStringToPrinter(string szPrinterName, string szString)
		{
			IntPtr pBytes;
			Int32 dwCount;

			// How many characters are in the string?
			// Fix from Nicholas Piasecki:
			// dwCount = szString.Length;
			dwCount = (szString.Length + 1) * Marshal.SystemMaxDBCSCharSize;

			// Assume that the printer is expecting ANSI text, and then convert
			// the string to ANSI text.
			pBytes = Marshal.StringToCoTaskMemAnsi(szString);
			// Send the converted ANSI string to the printer.
			SendBytesToPrinter(szPrinterName, pBytes, dwCount);
			Marshal.FreeCoTaskMem(pBytes);
			return true;
		}

		//打印标签
		private void buttonSEND_Click(object sender, EventArgs e)
		{

			if (Settings.Default["currentPrinterName"].ToString() == "")
			{
				MessageBox.Show(" 请先设置打印机", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if(groupText.Text == "" || groupText.Text == "未选择")
			{
				MessageBox.Show(" 请选择组别", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (numberOfLabelText.Text == "0")
			{
				MessageBox.Show(" 请设置例数", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DateTime thisDay = DateTime.Today;
				string barcodeX = Settings.Default["barcodeX"].ToString();
				string barcodeY = Settings.Default["barcodeY"].ToString();
				string numberX = Settings.Default["numberX"].ToString();
				string numberY = Settings.Default["numberY"].ToString();
				string page = GenerateLabels(int.Parse(startLabelText.Text), int.Parse(numberOfLabelText.Text),barcodeX,barcodeY,numberX,numberY);
				string printer = Settings.Default["currentPrinterName"].ToString();
				SendStringToPrinter(printer, page);
				
				
				// generate pdf
				string path = "E:/pathology_barcoder/" + thisDay.ToString("yyyy_MM_dd") + "/" + groupText.Text;
				string filePath;

				//如果文件不存在，新建文件
				if (!Directory.Exists(path))
				{
					DirectoryInfo di = Directory.CreateDirectory(path);
				}


				if (numberOfLabelText.Text == "1")
				{
					filePath = path + "/" + startLabelText.Text + "-_-1.pdf";
				}
				else
				{
					filePath = path + "/" + startLabelText.Text + "-" + stopLabelText.Text + "-" + numberOfLabelText.Text + ".pdf";
				}

				generatePDF(filePath);

				
				//初始化
				startLabelText.Text = (int.Parse(stopLabelText.Text) + 1).ToString();
				Settings.Default["currentLabelNumber"] = startLabelText.Text;
				Settings.Default.Save();
				stopLabelText.Text = "";
				groupText.Text = "未选择";
				numberOfLabelText.Text = "0";
			}
			
		}

		//生成标签EPL命令
		private string GenerateLabels(int startLabelNumbers, int numberOfLabelsToGenerate,string barcodeX, string barcodeY, string numberX, string numberY)
		{
			string lineFeed = "\n";
			string pageHead = "I8,A,001";
			pageHead += lineFeed;

			string pageStart = "";
			pageStart += "Q184,024";
			pageStart += lineFeed;
			pageStart += "q831";
			pageStart += lineFeed;
			pageStart += "rN";
			pageStart += lineFeed;
			pageStart += "S3";
			pageStart += lineFeed;
			pageStart += "D13";
			pageStart += lineFeed;
			pageStart += "ZT";
			pageStart += lineFeed;
			pageStart += "JF";
			pageStart += lineFeed;
			pageStart += "O";
			pageStart += lineFeed;
			pageStart += "R0,0";
			pageStart += lineFeed;
			pageStart += "f100";
			pageStart += lineFeed;
			pageStart += "N";
			pageStart += lineFeed;

			//A开头是数字，B开头是条码
			string firstLabel = "";
			//firstLabel += "A44,100,0,3,2,2,N,\"{0}\"";
			firstLabel += "A{1},{2},0,3,2,2,N,\"{0}\"";
			firstLabel += lineFeed;
			//firstLabel += "B53,29,0,1,2,6,66,N,\"{0}\"";
			firstLabel += "B{3},{4},0,1,2,6,66,N,\"{0}\"";
			firstLabel += lineFeed;

			string secondLabel = "";
			//secondLabel += "A244,100,0,3,2,2,N,\"{0}\"";
			secondLabel += "A{1},{2},0,3,2,2,N,\"{0}\"";
			secondLabel += lineFeed;
			//secondLabel += "B253,29,0,1,2,6,66,N,\"{0}\"";
			secondLabel += "B{3},{4},0,1,2,6,66,N,\"{0}\"";
			secondLabel += lineFeed;

			string thirdLabel = "";
			//thirdLabel += "A444,100,0,3,2,2,N,\"{0}\"";
			thirdLabel += "A{1},{2},0,3,2,2,N,\"{0}\"";
			thirdLabel += lineFeed;
			//thirdLabel += "B453,29,0,1,2,6,66,N,\"{0}\"";
			thirdLabel += "B{3},{4},0,1,2,6,66,N,\"{0}\"";
			thirdLabel += lineFeed;

			string fourthLabel = "";
			//fourthLabel += "A643,100,0,3,2,2,N,\"{0}\"";
			fourthLabel += "A{1},{2},0,3,2,2,N,\"{0}\"";
			fourthLabel += lineFeed;
			//fourthLabel += "B652,29,0,1,2,6,66,N,\"{0}\"";
			fourthLabel += "B{3},{4},0,1,2,6,66,N,\"{0}\"";
			fourthLabel += lineFeed;

			string pageStop = "";
			pageStop += "P1";
			pageStop += lineFeed;


			string labels = "";
			labels += pageHead;

			for (int i = 0; i < numberOfLabelsToGenerate; i++)
			{
				if(i < 4)
				{
					switch (i % 4)
					{
						case 0:
							labels += pageStart;
							labels += String.Format(firstLabel, startLabelNumbers + i, 
								                               (44 + int.Parse(numberX)).ToString(), 
															   (100 + int.Parse(numberY)).ToString(),
															   (53 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 1:
							labels += String.Format(secondLabel, startLabelNumbers + i,
															   (244 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (253 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 2:
							labels += String.Format(thirdLabel, startLabelNumbers + i,
															   (444 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (453 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 3:
							labels += String.Format(fourthLabel, startLabelNumbers + i,
															   (643 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (652 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
					}
				}
				else
				{
					switch (i % 4)
					{
						case 0:
							labels += pageStop;
							labels += pageStart;
							labels += String.Format(firstLabel, startLabelNumbers + i,
															   (44 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (53 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 1:
							labels += String.Format(secondLabel, startLabelNumbers + i,
															   (244 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (253 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 2:
							labels += String.Format(thirdLabel, startLabelNumbers + i,
															   (444 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (453 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
						case 3:
							labels += String.Format(fourthLabel, startLabelNumbers + i,
															   (643 + int.Parse(numberX)).ToString(),
															   (100 + int.Parse(numberY)).ToString(),
															   (652 + int.Parse(barcodeX)).ToString(),
															   (29 + int.Parse(barcodeY)).ToString()
												  );
							break;
					}
				}
					
			}
			labels += pageStop;
			return labels;

		}


		// 设置
		private void settingLabel_Click(object sender, EventArgs e)
		{
			using (Form2 form2 = new Form2())
			{
				if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if(form2.newStartLabelText != "")
					{
						startLabelText.Text = form2.newStartLabelText;
					}

					if(form2.newGroupText != "选择组别")
					{
						groupText.Text = form2.newGroupText;
					}
					

					if(form2.newNumberOfLabelText != "")
					{
						numberOfLabelText.Text = form2.newNumberOfLabelText;
					}
					

					if(form2.newNumberOfLabelText != "")
					{
						stopLabelText.Text = (int.Parse(startLabelText.Text) + int.Parse(numberOfLabelText.Text) - 1).ToString();
					}
					
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			startLabelText.Text = Settings.Default["currentLabelNumber"].ToString();
			groupText.Text = "未选择";
			numberOfLabelText.Text = "0";
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default["currentLabelNumber"] = startLabelText.Text;
			Settings.Default.Save();
		}

		//当日总表
		private void printSummary_Click(object sender, EventArgs e)
		{
			DateTime thisDay = DateTime.Today;
			string basePath = "E:/pathology_barcoder/" + thisDay.ToString("yyyy_MM_dd") + "/";
			if (!Directory.Exists(basePath))
			{
				MessageBox.Show(" 今天尚未打号", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string path = basePath + thisDay.ToString("yyyy-MM-dd") + "-HE染色表.pdf";
				iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(PageSize.A4.Rotate());
				Document summary = new Document(rec);
				PdfWriter.GetInstance(summary, new FileStream(path, FileMode.Create));
				BaseFont baseFont = BaseFont.CreateFont(Directory.GetCurrentDirectory() + "/Font/simhei.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
				iTextSharp.text.Font chineseTitleFont = new iTextSharp.text.Font(baseFont, 30);
				iTextSharp.text.Font chineseFont = new iTextSharp.text.Font(baseFont, 20);
				summary.Open();
				string[] dirs = new string[] { "头颈组", "盆组", "肺组", "胃肠组" };
				PdfPTable table = new PdfPTable(2);
				Paragraph title = new Paragraph("HE染色表\n\n", chineseTitleFont);
				title.Alignment = Element.ALIGN_CENTER;
				summary.Add(title);
				int total = 0;
				foreach (string dir in dirs)
				{
					int sum = 0;
					int index = dir.LastIndexOf("/");
					string group = dir.Substring(index + 1);
					PdfPCell cell;
					try
					{
						string[] files = Directory.GetFiles("E:/pathology_barcoder/" + thisDay.ToString("yyyy_MM_dd") + "/" + dir);
						group += "()\n\n";

						foreach (string file in files)
						{
							int startIndex = file.LastIndexOf("\\") + 1;
							int endIndex = file.LastIndexOf(".");
							string fileName = file.Substring(startIndex, endIndex - startIndex);
							string numbers = fileName.Substring(fileName.LastIndexOf("-") + 1);
							if (numbers == "1")
							{
								int firsthypenIndex = fileName.IndexOf("-");
								group += fileName.Substring(0, firsthypenIndex);
								sum += 1;
							}
							else
							{
								int firsthypenIndex = fileName.IndexOf("-");
								int secondhypenIndex = fileName.LastIndexOf("-");
								group += fileName.Substring(0, firsthypenIndex) + fileName.Substring(firsthypenIndex, secondhypenIndex - firsthypenIndex);
								sum += int.Parse(numbers);
							}
							group += " : ";
							group += numbers;
							group += "\n\n";

						}
						total += sum;
						group = group.Insert(group.IndexOf("(") + 1, sum.ToString());
						cell = new PdfPCell(new Paragraph(group, chineseFont));
					}
					catch
					{
						cell = new PdfPCell(new Paragraph(group, chineseFont));
					}
					cell.FixedHeight = 180f;
					cell.HorizontalAlignment = 1;
					table.AddCell(cell);
				}
				summary.Add(table);
				Paragraph totalParagraph = new Paragraph("\n       合计 ：" + total.ToString() + "                                   日期:" + thisDay.ToString("yyyy年MM月dd日") + "\n", chineseFont);
				totalParagraph.Alignment = Element.ALIGN_LEFT; ;
				summary.Add(totalParagraph);
				summary.Close();
				System.Diagnostics.Process.Start(@path);
			}
		}


		//打印机设置
		private void printerButton_Click(object sender, EventArgs e)
		{
			using (Form3 form3 = new Form3())
			{
				if (form3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if (form3.newPrinterName != "")
					{
						Settings.Default["currentPrinterName"] = form3.newPrinterName;
						Settings.Default.Save();
					}
				}
			}
		}


		private void generatePDF(string path)
		{
			Document doc = new Document();
			PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
		}

		//标签设置
		private void labelSetting_Click(object sender, EventArgs e)
		{
			using (Form4 form4 = new Form4())
			{
				if (form4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if (form4.newbarcodeXText != "")
					{
						Settings.Default["barcodeX"] = form4.newbarcodeXText;
						Settings.Default.Save();
					}

					if (form4.newbarcodeYText != "选择组别")
					{
						Settings.Default["barcodeY"] = form4.newbarcodeYText;
						Settings.Default.Save();
					}


					if (form4.newnumberXText != "")
					{
						Settings.Default["numberX"] = form4.newnumberXText;
						Settings.Default.Save();
					}


					if (form4.newnumberYText != "")
					{
						Settings.Default["numberY"] = form4.newnumberYText;
						Settings.Default.Save();
					}

				}
			}
		}
	}
}

