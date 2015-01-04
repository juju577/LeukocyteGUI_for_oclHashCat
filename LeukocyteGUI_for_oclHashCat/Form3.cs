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
            tskManager.Visualizer.InfoIndexes.HashTypeName = 0;
            tskManager.Visualizer.InfoIndexes.HashFileName = 1;
            tskManager.Visualizer.InfoIndexes.OutputFileName = 2;
            tskManager.Visualizer.InfoIndexes.BruteforceMaskDictionary = 3;
            //todo
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
    }
}