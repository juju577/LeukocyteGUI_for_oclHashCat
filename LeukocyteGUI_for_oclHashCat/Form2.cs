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
    public partial class ConvertationStatistics : Form
    {
        public ConvertationStatistics()
        {
            InitializeComponent();
        }

        public ConvertationStatistics(int ConvertCount)
            : this()
        {
            progressBarConverting.Value = 0;
            progressBarConverting.Maximum = ConvertCount;
        }
        public int ConvertCount
        {
            get
            {
                return progressBarConverting.Maximum;
            }

            set
            {
                progressBarConverting.Maximum = value;
                labelConvertingStatus.Text = "0 / " + value.ToString();
            }
        }

        public int Converted
        {
            get
            {
                return progressBarConverting.Value;
            }

            set
            {
                progressBarConverting.Value = value;
                labelConvertingStatus.Text = value.ToString() + " / "
                    + progressBarConverting.Maximum.ToString();
            }
        }

        public void richConvertSuccessAdd(string FileName, bool Success)
        {
            richConvertSuccess.SelectionStart = richConvertSuccess.TextLength;
            richConvertSuccess.SelectionLength = 0;

            if (Success)
            {
                richConvertSuccess.SelectionColor = System.Drawing.Color.Green;
            }
            else
            {
                richConvertSuccess.SelectionColor = System.Drawing.Color.Red;
            }

            richConvertSuccess.AppendText(FileName + "\r\n");
        }
    }
}
