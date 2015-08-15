namespace DeskboyDotNet
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageEdit = new System.Windows.Forms.TabPage();
			this.textNotes = new System.Windows.Forms.TextBox();
			this.comboNCategory = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.tabPageClipBoard = new System.Windows.Forms.TabPage();
			this.tabPageQuestion = new System.Windows.Forms.TabPage();
			this.tabPageTask = new System.Windows.Forms.TabPage();
			this.comboQCategory = new System.Windows.Forms.ComboBox();
			this.textQuestion = new System.Windows.Forms.TextBox();
			this.comboTCategory = new System.Windows.Forms.ComboBox();
			this.textTaskDesc = new System.Windows.Forms.TextBox();
			this.listClips = new System.Windows.Forms.ListBox();
			this.textResponse = new System.Windows.Forms.TextBox();
			this.textTaskName = new System.Windows.Forms.TextBox();
			this.listTaskState = new System.Windows.Forms.ListBox();
			this.tabPageConfigure = new System.Windows.Forms.TabPage();
			this.textClipFile = new System.Windows.Forms.TextBox();
			this.buttonFile = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonQFile = new System.Windows.Forms.Button();
			this.textQFile = new System.Windows.Forms.TextBox();
			this.buttonTFile = new System.Windows.Forms.Button();
			this.textTFile = new System.Windows.Forms.TextBox();
			this.buttonNFile = new System.Windows.Forms.Button();
			this.textNFile = new System.Windows.Forms.TextBox();
			this.buttonCFile = new System.Windows.Forms.Button();
			this.textCFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBoxRegistry = new System.Windows.Forms.CheckBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.buttonNext = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageEdit.SuspendLayout();
			this.tabPageClipBoard.SuspendLayout();
			this.tabPageQuestion.SuspendLayout();
			this.tabPageTask.SuspendLayout();
			this.tabPageConfigure.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageQuestion);
			this.tabControl.Controls.Add(this.tabPageClipBoard);
			this.tabControl.Controls.Add(this.tabPageTask);
			this.tabControl.Controls.Add(this.tabPageEdit);
			this.tabControl.Controls.Add(this.tabPageConfigure);
			this.tabControl.Location = new System.Drawing.Point(1, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(775, 365);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageEdit
			// 
			this.tabPageEdit.Controls.Add(this.comboNCategory);
			this.tabPageEdit.Controls.Add(this.textNotes);
			this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
			this.tabPageEdit.Name = "tabPageEdit";
			this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageEdit.Size = new System.Drawing.Size(767, 339);
			this.tabPageEdit.TabIndex = 1;
			this.tabPageEdit.Text = "Edit";
			this.tabPageEdit.UseVisualStyleBackColor = true;
			// 
			// textNotes
			// 
			this.textNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textNotes.Location = new System.Drawing.Point(6, 46);
			this.textNotes.Multiline = true;
			this.textNotes.Name = "textNotes";
			this.textNotes.Size = new System.Drawing.Size(755, 287);
			this.textNotes.TabIndex = 0;
			// 
			// comboNCategory
			// 
			this.comboNCategory.FormattingEnabled = true;
			this.comboNCategory.Location = new System.Drawing.Point(7, 6);
			this.comboNCategory.Name = "comboNCategory";
			this.comboNCategory.Size = new System.Drawing.Size(274, 21);
			this.comboNCategory.TabIndex = 1;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(782, 22);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(90, 27);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// tabPageClipBoard
			// 
			this.tabPageClipBoard.Controls.Add(this.listClips);
			this.tabPageClipBoard.Location = new System.Drawing.Point(4, 22);
			this.tabPageClipBoard.Name = "tabPageClipBoard";
			this.tabPageClipBoard.Size = new System.Drawing.Size(767, 339);
			this.tabPageClipBoard.TabIndex = 2;
			this.tabPageClipBoard.Text = "ClipBoard";
			this.tabPageClipBoard.UseVisualStyleBackColor = true;
			// 
			// tabPageQuestion
			// 
			this.tabPageQuestion.Controls.Add(this.textResponse);
			this.tabPageQuestion.Controls.Add(this.comboQCategory);
			this.tabPageQuestion.Controls.Add(this.textQuestion);
			this.tabPageQuestion.Location = new System.Drawing.Point(4, 22);
			this.tabPageQuestion.Name = "tabPageQuestion";
			this.tabPageQuestion.Size = new System.Drawing.Size(767, 339);
			this.tabPageQuestion.TabIndex = 3;
			this.tabPageQuestion.Text = "Question";
			this.tabPageQuestion.UseVisualStyleBackColor = true;
			// 
			// tabPageTask
			// 
			this.tabPageTask.Controls.Add(this.listTaskState);
			this.tabPageTask.Controls.Add(this.textTaskName);
			this.tabPageTask.Controls.Add(this.comboTCategory);
			this.tabPageTask.Controls.Add(this.textTaskDesc);
			this.tabPageTask.Location = new System.Drawing.Point(4, 22);
			this.tabPageTask.Name = "tabPageTask";
			this.tabPageTask.Size = new System.Drawing.Size(767, 339);
			this.tabPageTask.TabIndex = 4;
			this.tabPageTask.Text = "Task";
			this.tabPageTask.UseVisualStyleBackColor = true;
			// 
			// comboQCategory
			// 
			this.comboQCategory.FormattingEnabled = true;
			this.comboQCategory.Location = new System.Drawing.Point(7, 6);
			this.comboQCategory.Name = "comboQCategory";
			this.comboQCategory.Size = new System.Drawing.Size(274, 21);
			this.comboQCategory.TabIndex = 3;
			// 
			// textQuestion
			// 
			this.textQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textQuestion.Location = new System.Drawing.Point(6, 46);
			this.textQuestion.Multiline = true;
			this.textQuestion.Name = "textQuestion";
			this.textQuestion.Size = new System.Drawing.Size(755, 96);
			this.textQuestion.TabIndex = 2;
			// 
			// comboTCategory
			// 
			this.comboTCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboTCategory.FormattingEnabled = true;
			this.comboTCategory.Location = new System.Drawing.Point(7, 6);
			this.comboTCategory.Name = "comboTCategory";
			this.comboTCategory.Size = new System.Drawing.Size(274, 28);
			this.comboTCategory.TabIndex = 3;
			// 
			// textTaskDesc
			// 
			this.textTaskDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textTaskDesc.Location = new System.Drawing.Point(6, 92);
			this.textTaskDesc.Multiline = true;
			this.textTaskDesc.Name = "textTaskDesc";
			this.textTaskDesc.Size = new System.Drawing.Size(755, 112);
			this.textTaskDesc.TabIndex = 2;
			// 
			// listClips
			// 
			this.listClips.FormattingEnabled = true;
			this.listClips.Location = new System.Drawing.Point(162, 13);
			this.listClips.Name = "listClips";
			this.listClips.Size = new System.Drawing.Size(602, 316);
			this.listClips.TabIndex = 0;
			// 
			// textResponse
			// 
			this.textResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textResponse.Location = new System.Drawing.Point(6, 158);
			this.textResponse.Multiline = true;
			this.textResponse.Name = "textResponse";
			this.textResponse.Size = new System.Drawing.Size(755, 178);
			this.textResponse.TabIndex = 4;
			// 
			// textTaskName
			// 
			this.textTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTaskName.Location = new System.Drawing.Point(7, 45);
			this.textTaskName.Name = "textTaskName";
			this.textTaskName.Size = new System.Drawing.Size(478, 29);
			this.textTaskName.TabIndex = 4;
			// 
			// listTaskState
			// 
			this.listTaskState.FormattingEnabled = true;
			this.listTaskState.Items.AddRange(new object[] {
            "OPEN",
            "INQUIRY",
            "PROCEEDING",
            "ALMOST DONE",
            "DONE"});
			this.listTaskState.Location = new System.Drawing.Point(529, 6);
			this.listTaskState.Name = "listTaskState";
			this.listTaskState.Size = new System.Drawing.Size(232, 69);
			this.listTaskState.TabIndex = 5;
			// 
			// tabPageConfigure
			// 
			this.tabPageConfigure.Controls.Add(this.checkBoxRegistry);
			this.tabPageConfigure.Controls.Add(this.label5);
			this.tabPageConfigure.Controls.Add(this.label4);
			this.tabPageConfigure.Controls.Add(this.label3);
			this.tabPageConfigure.Controls.Add(this.label2);
			this.tabPageConfigure.Controls.Add(this.label1);
			this.tabPageConfigure.Controls.Add(this.buttonCFile);
			this.tabPageConfigure.Controls.Add(this.textCFile);
			this.tabPageConfigure.Controls.Add(this.buttonNFile);
			this.tabPageConfigure.Controls.Add(this.textNFile);
			this.tabPageConfigure.Controls.Add(this.buttonTFile);
			this.tabPageConfigure.Controls.Add(this.textTFile);
			this.tabPageConfigure.Controls.Add(this.buttonQFile);
			this.tabPageConfigure.Controls.Add(this.textQFile);
			this.tabPageConfigure.Controls.Add(this.buttonFile);
			this.tabPageConfigure.Controls.Add(this.textClipFile);
			this.tabPageConfigure.Location = new System.Drawing.Point(4, 22);
			this.tabPageConfigure.Name = "tabPageConfigure";
			this.tabPageConfigure.Size = new System.Drawing.Size(767, 339);
			this.tabPageConfigure.TabIndex = 5;
			this.tabPageConfigure.Text = "Configure";
			this.tabPageConfigure.UseVisualStyleBackColor = true;
			// 
			// textClipFile
			// 
			this.textClipFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textClipFile.Location = new System.Drawing.Point(7, 36);
			this.textClipFile.Name = "textClipFile";
			this.textClipFile.Size = new System.Drawing.Size(633, 24);
			this.textClipFile.TabIndex = 0;
			// 
			// buttonFile
			// 
			this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFile.Location = new System.Drawing.Point(660, 36);
			this.buttonFile.Name = "buttonFile";
			this.buttonFile.Size = new System.Drawing.Size(75, 23);
			this.buttonFile.TabIndex = 1;
			this.buttonFile.Text = ". . .";
			this.buttonFile.UseVisualStyleBackColor = true;
			this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "Question.boy";
			this.openFileDialog.Filter = "DeskBoy Files|*.boy";
			this.openFileDialog.InitialDirectory = "%USERDIR%";
			// 
			// buttonQFile
			// 
			this.buttonQFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonQFile.Location = new System.Drawing.Point(660, 102);
			this.buttonQFile.Name = "buttonQFile";
			this.buttonQFile.Size = new System.Drawing.Size(75, 23);
			this.buttonQFile.TabIndex = 3;
			this.buttonQFile.Text = ". . .";
			this.buttonQFile.UseVisualStyleBackColor = true;
			this.buttonQFile.Click += new System.EventHandler(this.buttonQFile_Click);
			// 
			// textQFile
			// 
			this.textQFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textQFile.Location = new System.Drawing.Point(7, 102);
			this.textQFile.Name = "textQFile";
			this.textQFile.Size = new System.Drawing.Size(633, 24);
			this.textQFile.TabIndex = 2;
			// 
			// buttonTFile
			// 
			this.buttonTFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTFile.Location = new System.Drawing.Point(660, 162);
			this.buttonTFile.Name = "buttonTFile";
			this.buttonTFile.Size = new System.Drawing.Size(75, 23);
			this.buttonTFile.TabIndex = 5;
			this.buttonTFile.Text = ". . .";
			this.buttonTFile.UseVisualStyleBackColor = true;
			this.buttonTFile.Click += new System.EventHandler(this.buttonTFile_Click);
			// 
			// textTFile
			// 
			this.textTFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTFile.Location = new System.Drawing.Point(7, 162);
			this.textTFile.Name = "textTFile";
			this.textTFile.Size = new System.Drawing.Size(633, 24);
			this.textTFile.TabIndex = 4;
			// 
			// buttonNFile
			// 
			this.buttonNFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNFile.Location = new System.Drawing.Point(660, 224);
			this.buttonNFile.Name = "buttonNFile";
			this.buttonNFile.Size = new System.Drawing.Size(75, 23);
			this.buttonNFile.TabIndex = 7;
			this.buttonNFile.Text = ". . .";
			this.buttonNFile.UseVisualStyleBackColor = true;
			this.buttonNFile.Click += new System.EventHandler(this.buttonNFile_Click);
			// 
			// textNFile
			// 
			this.textNFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNFile.Location = new System.Drawing.Point(7, 224);
			this.textNFile.Name = "textNFile";
			this.textNFile.Size = new System.Drawing.Size(633, 24);
			this.textNFile.TabIndex = 6;
			// 
			// buttonCFile
			// 
			this.buttonCFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCFile.Location = new System.Drawing.Point(660, 280);
			this.buttonCFile.Name = "buttonCFile";
			this.buttonCFile.Size = new System.Drawing.Size(75, 23);
			this.buttonCFile.TabIndex = 9;
			this.buttonCFile.Text = ". . .";
			this.buttonCFile.UseVisualStyleBackColor = true;
			this.buttonCFile.Click += new System.EventHandler(this.buttonCFile_Click);
			// 
			// textCFile
			// 
			this.textCFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textCFile.Location = new System.Drawing.Point(7, 280);
			this.textCFile.Name = "textCFile";
			this.textCFile.Size = new System.Drawing.Size(633, 24);
			this.textCFile.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 259);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Config File";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Notes File";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Task File";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 18);
			this.label4.TabIndex = 13;
			this.label4.Text = "Question File";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 18);
			this.label5.TabIndex = 14;
			this.label5.Text = "Clipboard File";
			// 
			// checkBoxRegistry
			// 
			this.checkBoxRegistry.AutoSize = true;
			this.checkBoxRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxRegistry.Location = new System.Drawing.Point(123, 256);
			this.checkBoxRegistry.Name = "checkBoxRegistry";
			this.checkBoxRegistry.Size = new System.Drawing.Size(109, 24);
			this.checkBoxRegistry.TabIndex = 15;
			this.checkBoxRegistry.Text = "use registry";
			this.checkBoxRegistry.UseVisualStyleBackColor = true;
			this.checkBoxRegistry.CheckedChanged += new System.EventHandler(this.checkBoxRegistry_CheckedChanged);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "boy";
			this.saveFileDialog.Filter = "DeskBoy files|*.boy";
			// 
			// buttonNext
			// 
			this.buttonNext.Location = new System.Drawing.Point(782, 71);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(90, 27);
			this.buttonNext.TabIndex = 2;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 358);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "Deskboy";
			this.tabControl.ResumeLayout(false);
			this.tabPageEdit.ResumeLayout(false);
			this.tabPageEdit.PerformLayout();
			this.tabPageClipBoard.ResumeLayout(false);
			this.tabPageQuestion.ResumeLayout(false);
			this.tabPageQuestion.PerformLayout();
			this.tabPageTask.ResumeLayout(false);
			this.tabPageTask.PerformLayout();
			this.tabPageConfigure.ResumeLayout(false);
			this.tabPageConfigure.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageEdit;
		private System.Windows.Forms.TextBox textNotes;
		private System.Windows.Forms.ComboBox comboNCategory;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TabPage tabPageQuestion;
		private System.Windows.Forms.TabPage tabPageClipBoard;
		private System.Windows.Forms.TabPage tabPageTask;
		private System.Windows.Forms.ComboBox comboQCategory;
		private System.Windows.Forms.TextBox textQuestion;
		private System.Windows.Forms.ComboBox comboTCategory;
		private System.Windows.Forms.TextBox textTaskDesc;
		private System.Windows.Forms.ListBox listClips;
		private System.Windows.Forms.TextBox textResponse;
		private System.Windows.Forms.TextBox textTaskName;
		private System.Windows.Forms.ListBox listTaskState;
		private System.Windows.Forms.TabPage tabPageConfigure;
		private System.Windows.Forms.Button buttonFile;
		private System.Windows.Forms.TextBox textClipFile;
		private System.Windows.Forms.CheckBox checkBoxRegistry;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCFile;
		private System.Windows.Forms.TextBox textCFile;
		private System.Windows.Forms.Button buttonNFile;
		private System.Windows.Forms.TextBox textNFile;
		private System.Windows.Forms.Button buttonTFile;
		private System.Windows.Forms.TextBox textTFile;
		private System.Windows.Forms.Button buttonQFile;
		private System.Windows.Forms.TextBox textQFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button buttonNext;
	}
}

