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
    public partial class TaskEditorForm : Form
    {
        CrackTaskManager MainCrackTaskManager;

        public TaskEditorForm(ref CrackTaskManager tskManager)
        {
            InitializeComponent();
            MainCrackTaskManager = tskManager;
        }

        private void buttonSubmitTask_Click(object sender, EventArgs e)
        {
            int TaskId;

            TaskId = MainCrackTaskManager.AddTask();

            if (!MainCrackTaskManager.CrackTasks[TaskId].SetHashFileName(textBoxHashFileName.Text, true))
            {
                return;
            }

            MainCrackTaskManager.CrackTasks[TaskId].SetSeparator(textBoxSeparator.Text);
            MainCrackTaskManager.CrackTasks[TaskId].SetHashTypeCode(int.Parse(comboBoxHashType.Text.Split('=')[0].Trim()));

            if (radioButtonAttackTypeBrute.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].SetAttackType(3);
                MainCrackTaskManager.CrackTasks[TaskId].SetBruteforceMask(textBoxBruteforceMask.Text);
            }
            else
            {
                MainCrackTaskManager.CrackTasks[TaskId].SetAttackType(0);
                MainCrackTaskManager.CrackTasks[TaskId].SetDictionary(textBoxDictionary.Text);
            }

            if (checkBoxCharset1.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].UseCharset1 = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetCharset1(textBoxCharset1.Text);
            }

            if (checkBoxCharset2.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].UseCharset2 = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetCharset2(textBoxCharset2.Text);
            }

            if (checkBoxCharset3.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].UseCharset3 = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetCharset3(textBoxCharset3.Text);
            }

            if (checkBoxCharset4.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].UseCharset4 = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetCharset4(textBoxCharset4.Text);
            }

            MainCrackTaskManager.CrackTasks[TaskId].EnableGPUAsync = checkBoxGPUAsync.Checked;

            if (checkBoxSpecificWorkloadProfile.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].EnableSpecificWorkloadProfile = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetWorkloadProfileCode(byte.Parse(comboBoxWorkloadProfile.Text.Split('=')[0].Trim()));
            }

            if (checkBoxWorkloadTuning.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].EnableWorkloadTuning = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetWorkloadTuning(byte.Parse(comboBoxWorkloadTuning.Text));
            }

            if (checkBoxWorkloadFineTuning.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].EnableWorkloadFineTuning = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetWorkloadFineTuning((int)numericUpDownWorkloadFineTuning.Value);
            }

            if (checkBoxTempAbort.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].AbortSessionIfReachesMaxTemp = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetAbortTemp((byte)numericUpDownTempAbort.Value);
            }

            if (checkBoxTempRetain.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].TryToRetain = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetRetainTemp((byte)numericUpDownTempRetain.Value);
            }

            MainCrackTaskManager.CrackTasks[TaskId].DisableAutoPowertuning = checkBoxDisablePowertune.Checked;

            if (checkBoxEnableIncrement.Checked)
            {
                MainCrackTaskManager.CrackTasks[TaskId].EnableIncrementMode = true;
                MainCrackTaskManager.CrackTasks[TaskId].SetStartLength((byte)numericUpDownIncrementMin.Value);
                MainCrackTaskManager.CrackTasks[TaskId].SetMaxLength((byte)numericUpDownIncrementMax.Value);
            }

            if (!MainCrackTaskManager.CrackTasks[TaskId].SetOutputFileName(textBoxOutputFile.Text, true))
            {
                return;
            }
        }
    }
}
