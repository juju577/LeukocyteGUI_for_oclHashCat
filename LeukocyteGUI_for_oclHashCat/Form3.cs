using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashCat
{
    public partial class MainForm : Form
    {
        CrackTaskManager tskManager;

        public MainForm()
        {
            InitializeComponent();
            tskManager = new CrackTaskManager();
            tskManager.Visualizer.SetListView(listViewTasks);
            tskManager.Visualizer.StartId = 1;
            tskManager.Visualizer.InfoIndexes.Id = 0;
            tskManager.Visualizer.InfoIndexes.HashTypeName = 1;
            tskManager.Visualizer.InfoIndexes.Hash = 2;
            tskManager.Visualizer.InfoIndexes.Plain = 3;
            tskManager.Visualizer.InfoIndexes.OutputFileName = 8;
            tskManager.Visualizer.InfoIndexes.BruteforceMaskDictionary = 9;
            tskManager.Visualizer.InfoIndexes.Started = 10;
            tskManager.Visualizer.InfoIndexes.Finished = 11;
            tskManager.Visualizer.InfoIndexes.SessionId = 12;
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            TaskEditorForm TaskEditor = new TaskEditorForm();
            TaskEditor.Owner = this;
            TaskEditor.ShowDialog(this);
        }

        private void buttonOpenConverter_Click(object sender, EventArgs e)
        {
            ConverterForm Converter = new ConverterForm();
            Converter.ShowDialog(this);
        }

        public CrackTaskManager MainCrackTaskManager
        {
            get
            {
                return tskManager;
            }

            set
            {
                tskManager = value;
            }
        }

        private void buttonChangeTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                TaskEditorForm TaskEditor = new TaskEditorForm(listViewTasks.SelectedIndices[0]);
                TaskEditor.Owner = this;
                TaskEditor.ShowDialog(this);
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            MainCrackTaskManager.DeleteTask(listViewTasks.SelectedIndices[0]);
            MainCrackTaskManager.Visualizer.VisualizeTasks();
        }
    }
}