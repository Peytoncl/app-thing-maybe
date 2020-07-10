using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cool_Thing
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{
			string filePath = Path.Combine(Environment.CurrentDirectory, @"Media\", "Video.mp4");
			axWindowsMediaPlayer1.URL = filePath;
			axWindowsMediaPlayer1.Ctlcontrols.play();
			Console.WriteLine(filePath);

		}
	}
}
