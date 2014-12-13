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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertationStatistics));
            this.labelConverting = new System.Windows.Forms.Label();
            this.labelConvertingStatus = new System.Windows.Forms.Label();
            this.listViewConvertSuccess = new System.Windows.Forms.ListView();
            this.imageListConvertStatus = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // listViewConvertSuccess
            // 
            this.listViewConvertSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.listViewConvertSuccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewConvertSuccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewConvertSuccess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewConvertSuccess.Location = new System.Drawing.Point(12, 45);
            this.listViewConvertSuccess.Name = "listViewConvertSuccess";
            this.listViewConvertSuccess.Size = new System.Drawing.Size(283, 158);
            this.listViewConvertSuccess.SmallImageList = this.imageListConvertStatus;
            this.listViewConvertSuccess.TabIndex = 4;
            this.listViewConvertSuccess.UseCompatibleStateImageBehavior = false;
            this.listViewConvertSuccess.View = System.Windows.Forms.View.Details;
            // 
            // imageListConvertStatus
            // 
            this.imageListConvertStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListConvertStatus.ImageStream")));
            this.imageListConvertStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListConvertStatus.Images.SetKeyName(0, "button_cancel_5732.png");
            this.imageListConvertStatus.Images.SetKeyName(1, "button_ok_4174.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 1;
            // 
            // ConvertationStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 215);
            this.Controls.Add(this.listViewConvertSuccess);
            this.Controls.Add(this.labelConvertingStatus);
            this.Controls.Add(this.labelConverting);
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

        private System.Windows.Forms.Label labelConverting;
        private System.Windows.Forms.Label labelConvertingStatus;
        private System.Windows.Forms.ListView listViewConvertSuccess;
        private System.Windows.Forms.ImageList imageListConvertStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}