namespace LeukocyteGUI_for_oclHashCat
{
    partial class TaskEditorForm
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
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.radioButtonAttackTypeBrute = new System.Windows.Forms.RadioButton();
            this.radioButtonAttackTypeDictionary = new System.Windows.Forms.RadioButton();
            this.groupBoxAttackType = new System.Windows.Forms.GroupBox();
            this.checkBoxCharset4 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset4 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset3 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset3 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset2 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset2 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset1 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset1 = new System.Windows.Forms.TextBox();
            this.textBoxDictionary = new System.Windows.Forms.TextBox();
            this.textBoxBruteforceMask = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHashFile = new System.Windows.Forms.Label();
            this.labelHashType = new System.Windows.Forms.Label();
            this.comboBoxHashType = new System.Windows.Forms.ComboBox();
            this.groupBoxAttackType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.Location = new System.Drawing.Point(77, 19);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(339, 20);
            this.textBoxHashcat.TabIndex = 10;
            // 
            // radioButtonAttackTypeBrute
            // 
            this.radioButtonAttackTypeBrute.AutoSize = true;
            this.radioButtonAttackTypeBrute.Checked = true;
            this.radioButtonAttackTypeBrute.Location = new System.Drawing.Point(16, 22);
            this.radioButtonAttackTypeBrute.Name = "radioButtonAttackTypeBrute";
            this.radioButtonAttackTypeBrute.Size = new System.Drawing.Size(111, 17);
            this.radioButtonAttackTypeBrute.TabIndex = 11;
            this.radioButtonAttackTypeBrute.TabStop = true;
            this.radioButtonAttackTypeBrute.Text = "Mask (bruteforce):";
            this.radioButtonAttackTypeBrute.UseVisualStyleBackColor = true;
            // 
            // radioButtonAttackTypeDictionary
            // 
            this.radioButtonAttackTypeDictionary.AutoSize = true;
            this.radioButtonAttackTypeDictionary.Location = new System.Drawing.Point(16, 163);
            this.radioButtonAttackTypeDictionary.Name = "radioButtonAttackTypeDictionary";
            this.radioButtonAttackTypeDictionary.Size = new System.Drawing.Size(108, 17);
            this.radioButtonAttackTypeDictionary.TabIndex = 12;
            this.radioButtonAttackTypeDictionary.Text = "Dictionary attack:";
            this.radioButtonAttackTypeDictionary.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttackType
            // 
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset4);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset4);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset3);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset3);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset2);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset2);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset1);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset1);
            this.groupBoxAttackType.Controls.Add(this.textBoxDictionary);
            this.groupBoxAttackType.Controls.Add(this.textBoxBruteforceMask);
            this.groupBoxAttackType.Controls.Add(this.radioButtonAttackTypeBrute);
            this.groupBoxAttackType.Controls.Add(this.radioButtonAttackTypeDictionary);
            this.groupBoxAttackType.Location = new System.Drawing.Point(13, 107);
            this.groupBoxAttackType.Name = "groupBoxAttackType";
            this.groupBoxAttackType.Size = new System.Drawing.Size(345, 196);
            this.groupBoxAttackType.TabIndex = 13;
            this.groupBoxAttackType.TabStop = false;
            this.groupBoxAttackType.Text = "Attack type";
            // 
            // checkBoxCharset4
            // 
            this.checkBoxCharset4.AutoSize = true;
            this.checkBoxCharset4.Location = new System.Drawing.Point(30, 132);
            this.checkBoxCharset4.Name = "checkBoxCharset4";
            this.checkBoxCharset4.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset4.TabIndex = 26;
            this.checkBoxCharset4.Text = "Charset 4:";
            this.checkBoxCharset4.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset4
            // 
            this.textBoxCharset4.Location = new System.Drawing.Point(110, 130);
            this.textBoxCharset4.Name = "textBoxCharset4";
            this.textBoxCharset4.Size = new System.Drawing.Size(214, 20);
            this.textBoxCharset4.TabIndex = 25;
            // 
            // checkBoxCharset3
            // 
            this.checkBoxCharset3.AutoSize = true;
            this.checkBoxCharset3.Location = new System.Drawing.Point(30, 106);
            this.checkBoxCharset3.Name = "checkBoxCharset3";
            this.checkBoxCharset3.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset3.TabIndex = 24;
            this.checkBoxCharset3.Text = "Charset 3:";
            this.checkBoxCharset3.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset3
            // 
            this.textBoxCharset3.Location = new System.Drawing.Point(110, 104);
            this.textBoxCharset3.Name = "textBoxCharset3";
            this.textBoxCharset3.Size = new System.Drawing.Size(214, 20);
            this.textBoxCharset3.TabIndex = 23;
            // 
            // checkBoxCharset2
            // 
            this.checkBoxCharset2.AutoSize = true;
            this.checkBoxCharset2.Location = new System.Drawing.Point(30, 80);
            this.checkBoxCharset2.Name = "checkBoxCharset2";
            this.checkBoxCharset2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset2.TabIndex = 22;
            this.checkBoxCharset2.Text = "Charset 2:";
            this.checkBoxCharset2.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset2
            // 
            this.textBoxCharset2.Location = new System.Drawing.Point(110, 78);
            this.textBoxCharset2.Name = "textBoxCharset2";
            this.textBoxCharset2.Size = new System.Drawing.Size(214, 20);
            this.textBoxCharset2.TabIndex = 21;
            // 
            // checkBoxCharset1
            // 
            this.checkBoxCharset1.AutoSize = true;
            this.checkBoxCharset1.Location = new System.Drawing.Point(30, 54);
            this.checkBoxCharset1.Name = "checkBoxCharset1";
            this.checkBoxCharset1.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset1.TabIndex = 20;
            this.checkBoxCharset1.Text = "Charset 1:";
            this.checkBoxCharset1.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset1
            // 
            this.textBoxCharset1.Location = new System.Drawing.Point(110, 52);
            this.textBoxCharset1.Name = "textBoxCharset1";
            this.textBoxCharset1.Size = new System.Drawing.Size(214, 20);
            this.textBoxCharset1.TabIndex = 16;
            // 
            // textBoxDictionary
            // 
            this.textBoxDictionary.Location = new System.Drawing.Point(138, 162);
            this.textBoxDictionary.Name = "textBoxDictionary";
            this.textBoxDictionary.Size = new System.Drawing.Size(186, 20);
            this.textBoxDictionary.TabIndex = 15;
            // 
            // textBoxBruteforceMask
            // 
            this.textBoxBruteforceMask.Location = new System.Drawing.Point(138, 21);
            this.textBoxBruteforceMask.Name = "textBoxBruteforceMask";
            this.textBoxBruteforceMask.Size = new System.Drawing.Size(186, 20);
            this.textBoxBruteforceMask.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHashType);
            this.groupBox1.Controls.Add(this.labelHashType);
            this.groupBox1.Controls.Add(this.labelHashFile);
            this.groupBox1.Controls.Add(this.textBoxHashcat);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 89);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash";
            // 
            // labelHashFile
            // 
            this.labelHashFile.AutoSize = true;
            this.labelHashFile.Location = new System.Drawing.Point(13, 22);
            this.labelHashFile.Name = "labelHashFile";
            this.labelHashFile.Size = new System.Drawing.Size(51, 13);
            this.labelHashFile.TabIndex = 11;
            this.labelHashFile.Text = "Hash file:";
            // 
            // labelHashType
            // 
            this.labelHashType.AutoSize = true;
            this.labelHashType.Location = new System.Drawing.Point(13, 49);
            this.labelHashType.Name = "labelHashType";
            this.labelHashType.Size = new System.Drawing.Size(58, 13);
            this.labelHashType.TabIndex = 12;
            this.labelHashType.Text = "Hash type:";
            // 
            // comboBoxHashType
            // 
            this.comboBoxHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHashType.Items.AddRange(new object[] {
            "0 = MD5",
            "10 = md5($pass.$salt)",
            "20 = md5($salt.$pass)",
            "30 = md5(unicode($pass).$salt)",
            "40 = md5($salt.unicode($pass))",
            "50 = HMAC-MD5 (key = $pass)",
            "60 = HMAC-MD5 (key = $salt)",
            "100 = SHA1",
            "110 = sha1($pass.$salt)",
            "120 = sha1($salt.$pass)",
            "130 = sha1(unicode($pass).$salt)",
            "140 = sha1($salt.unicode($pass))",
            "150 = HMAC-SHA1 (key = $pass)",
            "160 = HMAC-SHA1 (key = $salt)",
            "190 = sha1(LinkedIn)",
            "200 = MySQL323",
            "300 = MySQL4.1/MySQL5",
            "400 = phpass, MD5(Wordpress), MD5(phpBB3), MD5(Joomla)",
            "500 = md5crypt, MD5(Unix), FreeBSD MD5, Cisco-IOS MD5",
            "900 = MD4",
            "1000 = NTLM",
            "1100 = Domain Cached Credentials, mscash",
            "1400 = SHA256",
            "1410 = sha256($pass.$salt)",
            "1420 = sha256($salt.$pass)",
            "1430 = sha256(unicode($pass).$salt)",
            "1440 = sha256($salt.unicode($pass))",
            "1450 = HMAC-SHA256 (key = $pass)",
            "1460 = HMAC-SHA256 (key = $salt)",
            "1500 = descrypt, DES(Unix), Traditional DES",
            "1600 = md5apr1, MD5(APR), Apache MD5",
            "1700 = SHA512",
            "1710 = sha512($pass.$salt)",
            "1720 = sha512($salt.$pass)",
            "1730 = sha512(unicode($pass).$salt)",
            "1740 = sha512($salt.unicode($pass))",
            "1750 = HMAC-SHA512 (key = $pass)",
            "1760 = HMAC-SHA512 (key = $salt)",
            "1800 = sha512crypt, SHA512(Unix)",
            "2100 = Domain Cached Credentials2, mscash2",
            "2400 = Cisco-PIX MD5",
            "2410 = Cisco-ASA MD5",
            "2500 = WPA/WPA2",
            "2600 = Double MD5",
            "3000 = LM",
            "3100 = Oracle 7-10g, DES(Oracle)",
            "3200 = bcrypt, Blowfish(OpenBSD)",
            "3710 = md5($salt.md5($pass))",
            "4400 = md5(sha1($pass))",
            "4500 = Double SHA1",
            "4700 = sha1(md5($pass))",
            "4800 = MD5(Chap), iSCSI CHAP authentication",
            "5000 = SHA-3(Keccak)",
            "5100 = Half MD5",
            "5200 = Password Safe v3",
            "5300 = IKE-PSK MD5",
            "5400 = IKE-PSK SHA1",
            "5500 = NetNTLMv1-VANILLA / NetNTLMv1+ESS",
            "5600 = NetNTLMv2",
            "5700 = Cisco-IOS SHA256",
            "5800 = Android PIN",
            "6000 = RipeMD160",
            "6100 = Whirlpool",
            "6300 = AIX {smd5}",
            "6400 = AIX {ssha256}",
            "6500 = AIX {ssha512}",
            "6600 = 1Password, agilekeychain",
            "6700 = AIX {ssha1}",
            "6800 = Lastpass",
            "6900 = GOST R 34.11-94",
            "7100 = OSX v10.8 / v10.9",
            "7200 = GRUB 2",
            "7300 = IPMI2 RAKP HMAC-SHA1",
            "7400 = sha256crypt, SHA256(Unix)",
            "7500 = Kerberos 5 AS-REQ Pre-Auth etype 23",
            "7700 = SAP CODVN B (BCODE)",
            "7800 = SAP CODVN F/G (PASSCODE)",
            "7900 = Drupal7",
            "8000 = Sybase ASE",
            "8100 = Citrix Netscaler",
            "8200 = 1Password, cloudkeychain",
            "8300 = DNSSEC (NSEC3)",
            "8400 = WBB3, Woltlab Burning Board 3",
            "8500 = RACF",
            "8600 = Lotus Notes/Domino 5",
            "8700 = Lotus Notes/Domino 6",
            "8800 = Android FDE",
            "8900 = scrypt",
            "9000 = Password Safe v2",
            "9100 = Lotus Notes/Domino 8",
            "11 = Joomla < 2.5.18",
            "12 = PostgreSQL",
            "21 = osCommerce, xt:Commerce",
            "22 = Juniper Netscreen/SSG (ScreenOS)",
            "23 = Skype",
            "101 = nsldap, SHA-1(Base64), Netscape LDAP SHA",
            "111 = nsldaps, SSHA-1(Base64), Netscape LDAP SSHA",
            "112 = Oracle 11g/12c",
            "121 = SMF > v1.1",
            "122 = OSX v10.4, v10.5, v10.6",
            "131 = MSSQL(2000)",
            "132 = MSSQL(2005)",
            "133 = PeopleSoft",
            "141 = EPiServer 6.x < v4",
            "1421 = hMailServer",
            "1441 = EPiServer 6.x > v4",
            "1711 = SSHA-512(Base64), LDAP {SSHA512}",
            "1722 = OSX v10.7",
            "1731 = MSSQL(2012), MSSQL(2014)",
            "2611 = vBulletin < v3.8.5",
            "2612 = PHPS",
            "2711 = vBulletin > v3.8.5",
            "2811 = IPB2+, MyBB1.2+",
            "3711 = Mediawiki B type"});
            this.comboBoxHashType.Location = new System.Drawing.Point(77, 46);
            this.comboBoxHashType.Name = "comboBoxHashType";
            this.comboBoxHashType.Size = new System.Drawing.Size(339, 21);
            this.comboBoxHashType.TabIndex = 13;
            // 
            // TaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAttackType);
            this.Name = "TaskEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Task Editor";
            this.groupBoxAttackType.ResumeLayout(false);
            this.groupBoxAttackType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHashcat;
        private System.Windows.Forms.RadioButton radioButtonAttackTypeBrute;
        private System.Windows.Forms.RadioButton radioButtonAttackTypeDictionary;
        private System.Windows.Forms.GroupBox groupBoxAttackType;
        private System.Windows.Forms.TextBox textBoxDictionary;
        private System.Windows.Forms.TextBox textBoxBruteforceMask;
        private System.Windows.Forms.CheckBox checkBoxCharset4;
        private System.Windows.Forms.TextBox textBoxCharset4;
        private System.Windows.Forms.CheckBox checkBoxCharset3;
        private System.Windows.Forms.TextBox textBoxCharset3;
        private System.Windows.Forms.CheckBox checkBoxCharset2;
        private System.Windows.Forms.TextBox textBoxCharset2;
        private System.Windows.Forms.CheckBox checkBoxCharset1;
        private System.Windows.Forms.TextBox textBoxCharset1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxHashType;
        private System.Windows.Forms.Label labelHashType;
        private System.Windows.Forms.Label labelHashFile;
    }
}