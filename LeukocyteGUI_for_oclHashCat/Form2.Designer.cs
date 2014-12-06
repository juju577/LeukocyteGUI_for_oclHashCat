namespace LeukocyteGUI_for_oclHashCat
{
    partial class ConvertationStatistics
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
            this.progressBarConverting = new System.Windows.Forms.ProgressBar();
            this.labelConverting = new System.Windows.Forms.Label();
            this.labelConvertingStatus = new System.Windows.Forms.Label();
            this.richConvertSuccess = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progressBarConverting
            // 
            this.progressBarConverting.Location = new System.Drawing.Point(12, 38);
            this.progressBarConverting.Name = "progressBarConverting";
            this.progressBarConverting.Size = new System.Drawing.Size(283, 20);
            this.progressBarConverting.Step = 1;
            this.progressBarConverting.TabIndex = 0;
            // 
            // labelConverting
            // 
            this.labelConverting.AutoSize = true;
            this.labelConverting.Location = new System.Drawing.Point(10, 18);
            this.labelConverting.Name = "labelConverting";
            this.labelConverting.Size = new System.Drawing.Size(61, 13);
            this.labelConverting.TabIndex = 1;
            this.labelConverting.Text = "Converting:";
            // 
            // labelConvertingStatus
            // 
            this.labelConvertingStatus.Location = new System.Drawing.Point(237, 18);
            this.labelConvertingStatus.Name = "labelConvertingStatus";
            this.labelConvertingStatus.Size = new System.Drawing.Size(61, 13);
            this.labelConvertingStatus.TabIndex = 2;
            this.labelConvertingStatus.Text = "0 / 0";
            this.labelConvertingStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richConvertSuccess
            // 
            this.richConvertSuccess.Location = new System.Drawing.Point(12, 73);
            this.richConvertSuccess.Name = "richConvertSuccess";
            this.richConvertSuccess.ReadOnly = true;
            this.richConvertSuccess.Size = new System.Drawing.Size(284, 132);
            this.richConvertSuccess.TabIndex = 3;
            this.richConvertSuccess.Text = "";
            // 
            // ConvertationStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 215);
            this.Controls.Add(this.richConvertSuccess);
            this.Controls.Add(this.labelConvertingStatus);
            this.Controls.Add(this.labelConverting);
            this.Controls.Add(this.progressBarConverting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertationStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Converting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarConverting;
        private System.Windows.Forms.Label labelConverting;
        private System.Windows.Forms.Label labelConvertingStatus;
        private System.Windows.Forms.RichTextBox richConvertSuccess;
    }
}