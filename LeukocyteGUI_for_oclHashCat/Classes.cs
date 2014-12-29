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
    class Converter : System.Diagnostics.Process
    {
        public string OutPath = "/";
        public string ConverterFileName = "aircrack-ng.exe";
        private bool result = false;

        public Converter(string OutPath, string ConverterFileName)
            : this()
        {
            this.OutPath = OutPath;
            this.ConverterFileName = ConverterFileName;
        }

        public Converter()
        {
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardOutput = true;
            OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(converter_OutputDataReceived);
        }

        private void converter_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if ((!String.IsNullOrEmpty(e.Data)) && (e.Data.Contains("Successfully written")))
            {
                this.result = true;
            }
        }

        public bool Convert(string fName)
        {
            result = false;

            StartInfo.FileName = "\"" + ConverterFileName + "\"";
            StartInfo.Arguments = '"' + fName + '"' + " -J " + "\"" + OutPath + "\""
                + System.IO.Path.GetFileNameWithoutExtension(fName);
            Start();
            BeginOutputReadLine();
            WaitForExit();
            CancelOutputRead();
            Application.DoEvents();

            return result;
        }
    }

    class CrackTaskManager
    {
        class CrackTask
        {
            private string HashFileName, HashTypeName, BruteforceMask, Separator,
                Charset1, Charset2, Charset3, Charset4, Dictionary, OutputFile,
                OutputFileName, OutputFormatName, SessionId, WorkloadProfileName;
            private bool UseCharset1, UseCharset2, UseCharset3, UseCharset4,
                EnableIncrementMode, EnableGPUAsync, EnableSpecificWorkloadProfile,
                EnableWorkloadTuning, EnableWorkloadFineTuning, DisableTempReading,
                AbortSessionIfReachesMaxTemp, TryToRetain, DisableAutoPowertuning,
                CharsetIsInHex, SaltIsInHex, IgnoreWarnings, EnableLoopback,
                IgnoreUsernames, RemoveCrackedHashes, DisablePotfile, DisableLogfile;
            private int HashTypeCode, WorkloadFineTuning;
            private byte WorkloadProfileCode, OutputFormatCode, StartLength, MaxLength,
                WorkloadTuning, AbortTemp, RetainTemp, AttackType;
        }
    }
}
