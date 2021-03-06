﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.View
{
    public partial class Settings : Form
    {
        Inventory.Model.LocalSettings settings = Inventory.Provider.Container.getSettings();

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (String printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                this.selectLabelPrinter.Items.Add(printer);
            }

            this.selectLabelPrinter.SelectedText = settings.LabelPrinter;
            this.txtDbHost.Text = settings.DbHost;
            this.txtDbName.Text = settings.DbName;
            this.txtDbPort.Text = settings.DbPort.ToString();
            this.txtDbUserName.Text = settings.DbUserName;
            this.txtDbPassword.Text = settings.DbPassword;
            this.txtLabelFile.Text = settings.LabelFile;
            this.txtBelegVorlage.Text = settings.BelegOutsourcedVorlageFile;
            this.txtBelegDir.Text = settings.BelegOutsourcedSaveDir;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.DbHost = this.txtDbHost.Text;
            settings.DbName = this.txtDbName.Text;
            settings.DbPort = Int16.Parse(this.txtDbPort.Text);
            settings.DbUserName = this.txtDbUserName.Text;
            settings.DbPassword = this.txtDbPassword.Text;
            settings.LabelFile = this.txtLabelFile.Text;
            settings.LabelPrinter = this.selectLabelPrinter.Text;
            settings.BelegOutsourcedVorlageFile = this.txtBelegVorlage.Text;
            settings.BelegOutsourcedSaveDir = this.txtBelegDir.Text;

            Inventory.Provider.LocalSettings set = new Inventory.Provider.LocalSettings();
            set.saveSettings(settings);
            this.Close();
        }

        private void btnSelectLabelFile_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtLabelFile.Text = this.openFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBelegVorlage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtBelegVorlage.Text = this.openFileDialog1.FileName;
            }
        }

        private void btnBelegDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                this.txtBelegDir.Text = fbd.SelectedPath;

            }
        }
    }
}
