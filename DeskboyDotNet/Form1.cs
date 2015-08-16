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

		TabPage tabPage = null;
		Edit edit = new Edit();
		Task task = new Task();
		Configure configure = new Configure();
		Question question = new Question();
		Tasks tasks = new Tasks();

		public Form1()
		{
			InitializeComponent();
		}
		private void saveEdit()
		{


		}
		private void saveQuestion()
		{


		}
		private void loadEdit()
		{


		}
		private void loadQuestion()
		{


		}
		private void saveTask()
		{
			task.taskName = textTaskName.Text;
			task.taskDesc = textTaskDesc.Lines;
			task.category = comboTCategory.Text;
			task.taskState = listTaskState.SelectedItem.ToString();
			String[] ar = new String[listTMain.Items.Count];
			int i = 0;
			foreach (Object obj in listTMain.Items)
			{
				ar[i++] = obj.ToString();
			}
			task.taskTags = ar;
			tasks.Add(task);
			
		}
		private void loadTask()
		{
			textTaskName.Text = task.taskName;
			textTaskDesc.Lines = task.taskDesc ;
			comboTCategory.Text = task.category ;
			listTaskState.SelectedItem = task.taskState ;
			listTMain.Items.AddRange( task.taskTags) ;		
      }
		private void saveConfigure()
		{


		}
		private void clearEdit()
		{


		}
		private void clearQuestion()
		{


		}
		private void clearTask()
		{
			comboTCategory.Items.Clear();
			textTag.Clear();
			textTaskDesc.Clear();
			textTaskName.Clear();
			listTaskState.ClearSelected();
			listTMain.Items.Clear();
		}
		private void nextTask()
		{			
			comboTCategory.Items.Clear();
			textTag.Clear();
			textTaskDesc.Clear();
			textTaskName.Clear();
			listTaskState.ClearSelected();
			listTMain.Items.Clear();

		}
		private void clearConfigure()
		{


		}
		private void buttonSave_Click(object sender, EventArgs e)
		{
			if(tabPage == tabPageEdit)
			{
				saveEdit();
			}
			else if(tabPage == tabPageQuestion)
			{
				saveQuestion();
			}
			else if(tabPageTask == tabPage)
			{
				saveTask();
			}
			else if(tabPageConfigure == tabPage)
			{
				saveConfigure();
			}
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			if (tabPage == tabPageEdit)
			{
				saveEdit();
				clearEdit();
			}
			else if (tabPage == tabPageQuestion)
			{
				saveQuestion();
				clearQuestion();
			}
			else if (tabPageTask == tabPage)
			{
				saveTask();
				nextTask();
			}
			else if (tabPageConfigure == tabPage)
			{
				saveConfigure();
				clearConfigure();
			}
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

		private void textTag_TextChanged(object sender, EventArgs e)
		{
			if(textTag.Text.Length > 0)
			{
				buttonAddDel.Text = ">>";
			}
			else
			{
				buttonAddDel.Text = "<<";
			}
		}

		private void buttonAddDel_Click(object sender, EventArgs e)
		{
			if(buttonAddDel.Text == "<<")
			{
				textTag.Text = listTMain.SelectedItem.ToString();
				listTMain.Items.RemoveAt(listTMain.SelectedIndex);
         }
			else if(buttonAddDel.Text == ">>")
			{
				listTMain.Items.Add(textTag.Text) ;
			}
		}

		private void tabControl_Selected(object sender, TabControlEventArgs e)
		{
			tabPage = e.TabPage;
		}

		private void comboTCategory_DropDown(object sender, EventArgs e)
		{
			MessageBox.Show("Search Category");
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (tabPage == tabPageEdit)
			{
				loadEdit();
			}
			else if (tabPage == tabPageQuestion)
			{
				loadQuestion();
			}
			else if (tabPageTask == tabPage)
			{
				
				loadTask();
			}
			else if (tabPageConfigure == tabPage)
			{
				//loadConfigure();
			}
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (tabPage == tabPageEdit)
			{
				saveEdit();
				clearEdit();
			}
			else if (tabPage == tabPageQuestion)
			{
				saveQuestion();
				clearQuestion();
			}
			else if (tabPageTask == tabPage)
			{
				saveTask();
				clearTask();
			}
			else if (tabPageConfigure == tabPage)
			{
				saveConfigure();
				clearConfigure();
			}
		}
	}
}
