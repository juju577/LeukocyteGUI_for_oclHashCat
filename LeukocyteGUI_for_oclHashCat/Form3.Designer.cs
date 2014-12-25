namespace LeukocyteGUI_for_oclHashCat
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "MD5",
            "c:\\users\\file.hash",
            "C:\\dictionaries\\dic1.txt",
            "9/10",
            "94.34%",
            "2/10",
            "Cracking",
            "15.12.14 14:53:15",
            "",
            "15:38",
            "12345678"}, -1);
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.labelHashcat = new System.Windows.Forms.Label();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHashType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHashFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDictionary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCracked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFinished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstimated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOpenConverter = new System.Windows.Forms.Button();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonStopTask = new System.Windows.Forms.Button();
            this.buttonPauseTask = new System.Windows.Forms.Button();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.buttonChangeTask = new System.Windows.Forms.Button();
            this.buttonDownTask = new System.Windows.Forms.Button();
            this.buttonUpTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.Location = new System.Drawing.Point(100, 12);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(339, 20);
            this.textBoxHashcat.TabIndex = 8;
            this.textBoxHashcat.Text = "oclHashcat64.exe";
            // 
            // labelHashcat
            // 
            this.labelHashcat.AutoSize = true;
            this.labelHashcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHashcat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHashcat.Location = new System.Drawing.Point(12, 13);
            this.labelHashcat.Name = "labelHashcat";
            this.labelHashcat.Size = new System.Drawing.Size(82, 17);
            this.labelHashcat.TabIndex = 7;
            this.labelHashcat.Text = "oclHashcat:";
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderHashType,
            this.columnHeaderHashFile,
            this.columnHeaderDictionary,
            this.columnHeaderHash,
            this.columnHeaderProgress,
            this.columnHeaderCracked,
            this.columnHeaderStatus,
            this.columnHeaderStarted,
            this.columnHeaderFinished,
            this.columnHeaderEstimated,
            this.columnHeaderSession});
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTasks.Location = new System.Drawing.Point(12, 168);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(938, 344);
            this.listViewTasks.TabIndex = 1;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 37;
            // 
            // columnHeaderHashType
            // 
            this.columnHeaderHashType.Text = "Hash Type";
            this.columnHeaderHashType.Width = 66;
            // 
            // columnHeaderHashFile
            // 
            this.columnHeaderHashFile.Text = "Hash File";
            this.columnHeaderHashFile.Width = 122;
            // 
            // columnHeaderDictionary
            // 
            this.columnHeaderDictionary.Text = "Dictionary / Mask";
            this.columnHeaderDictionary.Width = 125;
            // 
            // columnHeaderHash
            // 
            this.columnHeaderHash.Text = "Hash";
            this.columnHeaderHash.Width = 62;
            // 
            // columnHeaderProgress
            // 
            this.columnHeaderProgress.Text = "Progress";
            this.columnHeaderProgress.Width = 54;
            // 
            // columnHeaderCracked
            // 
            this.columnHeaderCracked.Text = "Cracked";
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 56;
            // 
            // columnHeaderStarted
            // 
            this.columnHeaderStarted.Text = "Started";
            this.columnHeaderStarted.Width = 105;
            // 
            // columnHeaderFinished
            // 
            this.columnHeaderFinished.Text = "Finished";
            this.columnHeaderFinished.Width = 109;
            // 
            // columnHeaderEstimated
            // 
            this.columnHeaderEstimated.Text = "Estimated";
            this.columnHeaderEstimated.Width = 68;
            // 
            // columnHeaderSession
            // 
            this.columnHeaderSession.Text = "Session";
            // 
            // buttonOpenConverter
            // 
            this.buttonOpenConverter.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.message_reply_9020;
            this.buttonOpenConverter.Location = new System.Drawing.Point(205, 130);
            this.buttonOpenConverter.Name = "buttonOpenConverter";
            this.buttonOpenConverter.Padding = new System.Windows.Forms.Padding(3);
            this.buttonOpenConverter.Size = new System.Drawing.Size(40, 32);
            this.buttonOpenConverter.TabIndex = 18;
            this.buttonOpenConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenConverter.UseVisualStyleBackColor = true;
            this.buttonOpenConverter.Click += new System.EventHandler(this.buttonOpenConverter_Click);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.old_view_refresh_4484;
            this.buttonClearTask.Location = new System.Drawing.Point(149, 130);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearTask.Size = new System.Drawing.Size(40, 32);
            this.buttonClearTask.TabIndex = 17;
            this.buttonClearTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            // 
            // buttonStopTask
            // 
            this.buttonStopTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_stop_2295;
            this.buttonStopTask.Location = new System.Drawing.Point(455, 130);
            this.buttonStopTask.Name = "buttonStopTask";
            this.buttonStopTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStopTask.Size = new System.Drawing.Size(40, 32);
            this.buttonStopTask.TabIndex = 16;
            this.buttonStopTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopTask.UseVisualStyleBackColor = true;
            // 
            // buttonPauseTask
            // 
            this.buttonPauseTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_pause_9393;
            this.buttonPauseTask.Location = new System.Drawing.Point(409, 130);
            this.buttonPauseTask.Name = "buttonPauseTask";
            this.buttonPauseTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPauseTask.Size = new System.Drawing.Size(40, 32);
            this.buttonPauseTask.TabIndex = 15;
            this.buttonPauseTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPauseTask.UseVisualStyleBackColor = true;
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_play_ltr_9072;
            this.buttonStartTask.Location = new System.Drawing.Point(363, 130);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStartTask.Size = new System.Drawing.Size(40, 32);
            this.buttonStartTask.TabIndex = 14;
            this.buttonStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartTask.UseVisualStyleBackColor = true;
            // 
            // buttonChangeTask
            // 
            this.buttonChangeTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.configure_9863;
            this.buttonChangeTask.Location = new System.Drawing.Point(103, 130);
            this.buttonChangeTask.Name = "buttonChangeTask";
            this.buttonChangeTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeTask.Size = new System.Drawing.Size(40, 32);
            this.buttonChangeTask.TabIndex = 13;
            this.buttonChangeTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeTask.UseVisualStyleBackColor = true;
            // 
            // buttonDownTask
            // 
            this.buttonDownTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources._1downarrow_9068;
            this.buttonDownTask.Location = new System.Drawing.Point(307, 130);
            this.buttonDownTask.Name = "buttonDownTask";
            this.buttonDownTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownTask.Size = new System.Drawing.Size(40, 32);
            this.buttonDownTask.TabIndex = 12;
            this.buttonDownTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownTask.UseVisualStyleBackColor = true;
            // 
            // buttonUpTask
            // 
            this.buttonUpTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources._1uparrow_2202;
            this.buttonUpTask.Location = new System.Drawing.Point(261, 130);
            this.buttonUpTask.Name = "buttonUpTask";
            this.buttonUpTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpTask.Size = new System.Drawing.Size(40, 32);
            this.buttonUpTask.TabIndex = 11;
            this.buttonUpTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpTask.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.button_cancel_8125;
            this.buttonDeleteTask.Location = new System.Drawing.Point(57, 130);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteTask.Size = new System.Drawing.Size(40, 32);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.edit_add_7148;
            this.buttonAddTask.Location = new System.Drawing.Point(11, 130);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddTask.Size = new System.Drawing.Size(40, 32);
            this.buttonAddTask.TabIndex = 9;
            this.buttonAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 524);
            this.Controls.Add(this.buttonOpenConverter);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonStopTask);
            this.Controls.Add(this.buttonPauseTask);
            this.Controls.Add(this.buttonStartTask);
            this.Controls.Add(this.buttonChangeTask);
            this.Controls.Add(this.buttonDownTask);
            this.Controls.Add(this.buttonUpTask);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxHashcat);
            this.Controls.Add(this.labelHashcat);
            this.Controls.Add(this.listViewTasks);
            this.Name = "MainForm";
            this.Text = "LeukocyteGUI for oclHashCat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHashcat;
        private System.Windows.Forms.Label labelHashcat;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderHashType;
        private System.Windows.Forms.ColumnHeader columnHeaderHashFile;
        private System.Windows.Forms.ColumnHeader columnHeaderProgress;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderHash;
        private System.Windows.Forms.ColumnHeader columnHeaderCracked;
        private System.Windows.Forms.ColumnHeader columnHeaderStarted;
        private System.Windows.Forms.ColumnHeader columnHeaderFinished;
        private System.Windows.Forms.ColumnHeader columnHeaderEstimated;
        private System.Windows.Forms.ColumnHeader columnHeaderSession;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonUpTask;
        private System.Windows.Forms.Button buttonDownTask;
        private System.Windows.Forms.Button buttonChangeTask;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.Button buttonPauseTask;
        private System.Windows.Forms.Button buttonStopTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.ColumnHeader columnHeaderDictionary;
        private System.Windows.Forms.Button buttonOpenConverter;
    }
}