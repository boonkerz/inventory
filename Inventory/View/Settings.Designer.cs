namespace Inventory.View
{
    partial class Settings
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
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDbUserName = new System.Windows.Forms.TextBox();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectLabelPrinter = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLabelFile = new System.Windows.Forms.TextBox();
            this.btnSelectLabelFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBelegVorlage = new System.Windows.Forms.TextBox();
            this.btnBelegVorlage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBelegDir = new System.Windows.Forms.TextBox();
            this.btnBelegDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(64, 7);
            this.txtDbHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(100, 20);
            this.txtDbHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datenbank Name";
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(194, 7);
            this.txtDbPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(52, 20);
            this.txtDbPort.TabIndex = 5;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(119, 32);
            this.txtDbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(142, 20);
            this.txtDbName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Benutzername";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Passwort";
            // 
            // txtDbUserName
            // 
            this.txtDbUserName.Location = new System.Drawing.Point(119, 56);
            this.txtDbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDbUserName.Name = "txtDbUserName";
            this.txtDbUserName.Size = new System.Drawing.Size(142, 20);
            this.txtDbUserName.TabIndex = 6;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(119, 82);
            this.txtDbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(214, 20);
            this.txtDbPassword.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 216);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 22);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Abbrechen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 216);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 22);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Label Drucker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Label Datei";
            // 
            // selectLabelPrinter
            // 
            this.selectLabelPrinter.FormattingEnabled = true;
            this.selectLabelPrinter.Location = new System.Drawing.Point(119, 108);
            this.selectLabelPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectLabelPrinter.Name = "selectLabelPrinter";
            this.selectLabelPrinter.Size = new System.Drawing.Size(157, 21);
            this.selectLabelPrinter.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openLabelFile";
            // 
            // txtLabelFile
            // 
            this.txtLabelFile.Location = new System.Drawing.Point(119, 136);
            this.txtLabelFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabelFile.Name = "txtLabelFile";
            this.txtLabelFile.Size = new System.Drawing.Size(142, 20);
            this.txtLabelFile.TabIndex = 12;
            // 
            // btnSelectLabelFile
            // 
            this.btnSelectLabelFile.Location = new System.Drawing.Point(265, 136);
            this.btnSelectLabelFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectLabelFile.Name = "btnSelectLabelFile";
            this.btnSelectLabelFile.Size = new System.Drawing.Size(66, 20);
            this.btnSelectLabelFile.TabIndex = 13;
            this.btnSelectLabelFile.Text = "Auswählen";
            this.btnSelectLabelFile.UseVisualStyleBackColor = true;
            this.btnSelectLabelFile.Click += new System.EventHandler(this.btnSelectLabelFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Beleg Vorlage";
            // 
            // txtBelegVorlage
            // 
            this.txtBelegVorlage.Location = new System.Drawing.Point(119, 162);
            this.txtBelegVorlage.Margin = new System.Windows.Forms.Padding(2);
            this.txtBelegVorlage.Name = "txtBelegVorlage";
            this.txtBelegVorlage.Size = new System.Drawing.Size(142, 20);
            this.txtBelegVorlage.TabIndex = 12;
            // 
            // btnBelegVorlage
            // 
            this.btnBelegVorlage.Location = new System.Drawing.Point(265, 160);
            this.btnBelegVorlage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBelegVorlage.Name = "btnBelegVorlage";
            this.btnBelegVorlage.Size = new System.Drawing.Size(66, 20);
            this.btnBelegVorlage.TabIndex = 13;
            this.btnBelegVorlage.Text = "Auswählen";
            this.btnBelegVorlage.UseVisualStyleBackColor = true;
            this.btnBelegVorlage.Click += new System.EventHandler(this.btnBelegVorlage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Belege Speicherplatz";
            // 
            // txtBelegDir
            // 
            this.txtBelegDir.Location = new System.Drawing.Point(119, 188);
            this.txtBelegDir.Margin = new System.Windows.Forms.Padding(2);
            this.txtBelegDir.Name = "txtBelegDir";
            this.txtBelegDir.Size = new System.Drawing.Size(142, 20);
            this.txtBelegDir.TabIndex = 12;
            // 
            // btnBelegDir
            // 
            this.btnBelegDir.Location = new System.Drawing.Point(265, 187);
            this.btnBelegDir.Margin = new System.Windows.Forms.Padding(2);
            this.btnBelegDir.Name = "btnBelegDir";
            this.btnBelegDir.Size = new System.Drawing.Size(66, 20);
            this.btnBelegDir.TabIndex = 13;
            this.btnBelegDir.Text = "Auswählen";
            this.btnBelegDir.UseVisualStyleBackColor = true;
            this.btnBelegDir.Click += new System.EventHandler(this.btnBelegDir_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 249);
            this.Controls.Add(this.btnBelegDir);
            this.Controls.Add(this.btnBelegVorlage);
            this.Controls.Add(this.btnSelectLabelFile);
            this.Controls.Add(this.txtBelegDir);
            this.Controls.Add(this.txtBelegVorlage);
            this.Controls.Add(this.txtLabelFile);
            this.Controls.Add(this.selectLabelPrinter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDbPassword);
            this.Controls.Add(this.txtDbUserName);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtDbPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDbHost);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDbUserName;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectLabelPrinter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLabelFile;
        private System.Windows.Forms.Button btnSelectLabelFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBelegVorlage;
        private System.Windows.Forms.Button btnBelegVorlage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBelegDir;
        private System.Windows.Forms.Button btnBelegDir;
    }
}