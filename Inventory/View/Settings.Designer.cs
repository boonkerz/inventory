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
            this.SuspendLayout();
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(128, 13);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(196, 31);
            this.txtDbHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datenbank Name";
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(387, 13);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(100, 31);
            this.txtDbPort.TabIndex = 5;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(208, 64);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(279, 31);
            this.txtDbName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Benutzername";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Passwort";
            // 
            // txtDbUserName
            // 
            this.txtDbUserName.Location = new System.Drawing.Point(208, 110);
            this.txtDbUserName.Name = "txtDbUserName";
            this.txtDbUserName.Size = new System.Drawing.Size(279, 31);
            this.txtDbUserName.TabIndex = 6;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(208, 161);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(424, 31);
            this.txtDbPassword.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Abbrechen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Drucker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Label Datei";
            // 
            // selectLabelPrinter
            // 
            this.selectLabelPrinter.FormattingEnabled = true;
            this.selectLabelPrinter.Location = new System.Drawing.Point(208, 203);
            this.selectLabelPrinter.Name = "selectLabelPrinter";
            this.selectLabelPrinter.Size = new System.Drawing.Size(310, 33);
            this.selectLabelPrinter.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openLabelFile";
            // 
            // txtLabelFile
            // 
            this.txtLabelFile.Location = new System.Drawing.Point(208, 261);
            this.txtLabelFile.Name = "txtLabelFile";
            this.txtLabelFile.Size = new System.Drawing.Size(279, 31);
            this.txtLabelFile.TabIndex = 12;
            // 
            // btnSelectLabelFile
            // 
            this.btnSelectLabelFile.Location = new System.Drawing.Point(501, 261);
            this.btnSelectLabelFile.Name = "btnSelectLabelFile";
            this.btnSelectLabelFile.Size = new System.Drawing.Size(131, 39);
            this.btnSelectLabelFile.TabIndex = 13;
            this.btnSelectLabelFile.Text = "Auswählen";
            this.btnSelectLabelFile.UseVisualStyleBackColor = true;
            this.btnSelectLabelFile.Click += new System.EventHandler(this.btnSelectLabelFile_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.btnSelectLabelFile);
            this.Controls.Add(this.txtLabelFile);
            this.Controls.Add(this.selectLabelPrinter);
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
    }
}