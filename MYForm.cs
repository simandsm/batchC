using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 批量修改
{
	internal partial class MYForm : Form
	{
		public MYForm()
		{
			this.InitializeComponent();
		}

		private void jp_Click(object sender, EventArgs e)
		{
			this.bs = Encoding.Default.GetBytes(this.strinput.Text);
			this.strinput.Text = Encoding.GetEncoding("shift-jis").GetString(this.bs);
		}

		private void u8_Click(object sender, EventArgs e)
		{
			this.bs = Encoding.Default.GetBytes(this.strinput.Text);
			this.strinput.Text = Encoding.UTF8.GetString(this.bs);
		}

		private void MYForm_DragEnter(object sender, DragEventArgs e)
		{
			foreach (string fileName in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				FileInfo fileInfo = new FileInfo(fileName);
				FileStream fileStream = fileInfo.OpenRead();
				StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding("shift-jis"));
				string s = streamReader.ReadToEnd();
				streamReader.Close();
				fileStream.Close();
				fileInfo.Delete();
				FileStream fileStream2 = fileInfo.Create();
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				fileStream2.Write(bytes, 0, bytes.Length);
				fileStream2.Flush();
				fileStream2.Close();
			}
		}

		private void self_Click(object sender, EventArgs e)
		{
			if (this.pattern.Text == "")
			{
				this.pattern.Text = " ";
			}
			this.oldfi.Clear();
			this.nowdi.Clear();
			this.olddi.Clear();
			this.nowfi.Clear();
			string[] array = Directory.GetDirectories(this.diname.Text);
			for (int i = 0; i < array.Length; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(array[i]);
				if (directoryInfo.Name.Contains(this.pattern.Text))
				{
					this.olddi.Add(directoryInfo.FullName);
					string text = this.diname.Text + this.sp + directoryInfo.Name.Replace(this.pattern.Text, "");
					this.nowdi.Add(text);
					directoryInfo.MoveTo(text);
				}
			}
			array = Directory.GetFiles(this.diname.Text);
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				if (fileInfo.Name.Contains(this.pattern.Text))
				{
					this.oldfi.Add(fileInfo.FullName);
					string text2 = this.diname.Text + this.sp + fileInfo.Name.Replace(this.pattern.Text, "");
					this.nowfi.Add(text2);
					fileInfo.MoveTo(text2);
				}
			}
		}

		private void pat_Click(object sender, EventArgs e)
		{
			this.oldfi.Clear();
			this.nowdi.Clear();
			this.olddi.Clear();
			this.nowfi.Clear();
			string[] directories = Directory.GetDirectories(this.diname.Text);
			int i = 0;
			while (i < directories.Length)
			{
				string path = directories[i];
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				MatchCollection matchCollection = Regex.Matches(directoryInfo.Name, this.pattern.Text);
				bool flag = matchCollection.Count != 0;
				if (flag)
				{
					this.olddi.Add(directoryInfo.FullName);
					string text = directoryInfo.Name;
					foreach (object obj in matchCollection)
					{
						Match match = (Match)obj;
						text = text.Replace(match.Value, "");
					}
					bool flag2 = text == "";
					if (flag2)
					{
						this.olddi.Remove(directoryInfo.FullName);
					}
					else
					{
						text = this.diname.Text + this.sp + text;
						bool flag3 = this.nowdi.Contains(text);
						if (flag3)
						{
							this.olddi.Remove(directoryInfo.FullName);
						}
						else
						{
							try
							{
								directoryInfo.MoveTo(text);
							}
							catch (Exception)
							{
								this.olddi.Remove(directoryInfo.FullName);
								goto IL_18B;
							}
							this.nowdi.Add(text);
						}
					}
				}
				IL_18B:
				i++;
				continue;
				goto IL_18B;
			}
			string[] files = Directory.GetFiles(this.diname.Text);
			int j = 0;
			while (j < files.Length)
			{
				string fileName = files[j];
				FileInfo fileInfo = new FileInfo(fileName);
				MatchCollection matchCollection2 = Regex.Matches(fileInfo.Name, this.pattern.Text);
				bool flag4 = matchCollection2.Count != 0;
				if (flag4)
				{
					this.oldfi.Add(fileInfo.FullName);
					string text2 = fileInfo.Name;
					foreach (object obj2 in matchCollection2)
					{
						Match match2 = (Match)obj2;
						text2 = text2.Replace(match2.Value, "");
					}
					bool flag5 = text2 == "";
					if (flag5)
					{
						this.oldfi.Remove(fileInfo.FullName);
					}
					else
					{
						text2 = this.diname.Text + this.sp + text2;
						bool flag6 = this.nowdi.Contains(text2);
						if (flag6)
						{
							this.oldfi.Remove(fileInfo.FullName);
						}
						else
						{
							try
							{
								fileInfo.MoveTo(text2);
							}
							catch (Exception)
							{
								this.oldfi.Remove(fileInfo.FullName);
								goto IL_300;
							}
							this.nowfi.Add(text2);
						}
					}
				}
				IL_300:
				j++;
				continue;
				goto IL_300;
			}
		}

		private void re_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.olddi.Count; i++)
			{
				new DirectoryInfo(this.nowdi[i]).MoveTo(this.olddi[i]);
			}
			for (int j = 0; j < this.oldfi.Count; j++)
			{
				new DirectoryInfo(this.nowfi[j]).MoveTo(this.oldfi[j]);
			}
			this.oldfi.Clear();
			this.nowdi.Clear();
			this.olddi.Clear();
			this.nowfi.Clear();
		}

		private void yuan_Click(object sender, EventArgs e)
		{
			this.pattern.Text = "\\([^\\)]*\\)";
			this.pat_Click(null, null);
		}

		private void fang_Click(object sender, EventArgs e)
		{
			this.pattern.Text = "\\[[^\\]]*]";
			this.pat_Click(null, null);
		}

		private void MYForm_Load(object sender, EventArgs e)
		{
		}

		private List<string> oldfi = new List<string>();

		private List<string> olddi = new List<string>();

		private List<string> nowdi = new List<string>();

		private List<string> nowfi = new List<string>();

		private string sp = "\\";

		private byte[] bs;
	}
}
