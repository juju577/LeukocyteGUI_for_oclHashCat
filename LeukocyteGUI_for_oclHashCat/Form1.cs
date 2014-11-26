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
        public MainForm()
        {
            InitializeComponent();
        }

        private void listBoxFilenames_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData("FileDrop", false);

            for (int i = 0; i < files.Length; i++)
            {
                listBoxFilenames.Items.Add(files[i].Replace("\\", "/"));
            }
        }

        private void listBoxFilenames_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter(textBoxOutput.Text, textBoxConverter.Text);

            for (int i = 0; i < listBoxFilenames.Items.Count; i++)
            {
                string file = listBoxFilenames.Items[i] as string;

                if (file.Length > 4)
                {
                    converter.Convert(file);
                }   
            }

            //converter.WaitForExit();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Properties.Settings.Default.capConverter = textBoxConverter.Text;
            Properties.Settings.Default.hccapOutputPath = textBoxOutput.Text;
            Properties.Settings.Default.Save();

            base.OnClosing(e);
        }

        private void buttonChooseConverter_Click(object sender, EventArgs e)
        {
            if (chooseConverterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxConverter.Text = chooseConverterDialog.FileName;
            }
        }

        private void buttonChooseOutput_Click(object sender, EventArgs e)
        {
            if (chooseOutputDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutput.Text = chooseOutputDialog.SelectedPath + "\\";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxFilenames.SelectedIndex;

            if(index != -1)
            {
                listBoxFilenames.Items.RemoveAt(index);
            }

            if (listBoxFilenames.Items.Count > index)
            {
                listBoxFilenames.SelectedIndex = index;
            }
            else if (listBoxFilenames.Items.Count > 0)
            {
                listBoxFilenames.SelectedIndex = index - 1;
            }
        }

        private void buttonMoveUpDown_Click(object sender, EventArgs e)
        {
            int index = listBoxFilenames.SelectedIndex;
            string buffer;

            if (index == -1) return;

            if ((sender as Button).Name == "buttonMoveUp")
            {
                if(index > 0)
                {
                    buffer = (string) listBoxFilenames.Items[index - 1];
                    listBoxFilenames.Items[index - 1] = listBoxFilenames.Items[index];
                    listBoxFilenames.Items[index] = buffer;
                    listBoxFilenames.SelectedIndex = index - 1;
                }
            }
            else if(listBoxFilenames.Items.Count > index + 1)
            {
                buffer = (string) listBoxFilenames.Items[index + 1];
                listBoxFilenames.Items[index + 1] = listBoxFilenames.Items[index];
                listBoxFilenames.Items[index] = buffer;
                listBoxFilenames.SelectedIndex = index + 1;
            }
        }

        private void listBoxFilenames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilenames.SelectedIndex == -1)
            {
                buttonConvert.Enabled  = false;
                buttonDelete.Enabled   = false;
                buttonMoveUp.Enabled   = false;
                buttonMoveDown.Enabled = false;
            }
            else
            {
                buttonConvert.Enabled  = true;
                buttonDelete.Enabled   = true;
                buttonMoveUp.Enabled   = true;
                buttonMoveDown.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (chooseFilesDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < chooseFilesDialog.FileNames.Length; i++)
                {
                    listBoxFilenames.Items.Add(chooseFilesDialog.FileNames[i].Replace("\\", "/"));
                }
            }
        }
    }

    class Converter : System.Diagnostics.Process
    {
        public string OutPath = "/";
        public string ConverterFileName = "aircrack-ng.exe";
        private bool result = false;

        public Converter(string OutPath, string ConverterFileName) : this()
        {
            this.OutPath = OutPath;
            this.ConverterFileName = ConverterFileName;
        }

        public Converter()
        {
            StartInfo.FileName = "\"" + ConverterFileName + "\"";
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardOutput = true;
            OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(converter_OutputDataReceived);
        }

        private void converter_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data.Contains("Successfully written"))
            {
                this.result = true;
            }
        }

        public bool Convert(string fName)
        {
            result = false;

            StartInfo.Arguments = '"' + fName + '"' + " -J " + "\"" + OutPath + "\""
                + System.IO.Path.GetFileNameWithoutExtension(fName);
            Start();
            WaitForExit();

            return result;
        }        
    }
}
