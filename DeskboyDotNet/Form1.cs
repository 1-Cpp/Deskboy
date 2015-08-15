using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskboyDotNet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{

		}

		private void buttonNext_Click(object sender, EventArgs e)
		{

		}

		private void buttonFile_Click(object sender, EventArgs e)
		{
			if(openFileDialog.ShowDialog() == DialogResult.OK)
				textClipFile.Text = openFileDialog.FileName;
		}

		private void buttonQFile_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				textQFile.Text = saveFileDialog.FileName;
		}

		private void buttonTFile_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				textTFile.Text = saveFileDialog.FileName;
		}

		private void buttonNFile_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				textNFile.Text = saveFileDialog.FileName;
		}

		private void buttonCFile_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				textCFile.Text = saveFileDialog.FileName;
		}

		private void checkBoxRegistry_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
