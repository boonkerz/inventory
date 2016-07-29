namespace Inventory.View
{
    partial class Article
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
            this.gridArticle = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridArticlegroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.numMeldeBestand = new System.Windows.Forms.NumericUpDown();
            this.numMinBestand = new System.Windows.Forms.NumericUpDown();
            this.numBestand = new System.Windows.Forms.NumericUpDown();
            this.selectOwner = new System.Windows.Forms.ComboBox();
            this.selectArticleGroup = new System.Windows.Forms.ComboBox();
            this.txtLagerPlatz = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLabel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Seriennummer = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeldeBestand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinBestand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBestand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridArticle
            // 
            this.gridArticle.AllowUserToAddRows = false;
            this.gridArticle.AllowUserToDeleteRows = false;
            this.gridArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridNr,
            this.gridName,
            this.gridOwner,
            this.gridArticlegroup});
            this.gridArticle.Location = new System.Drawing.Point(12, 12);
            this.gridArticle.Name = "gridArticle";
            this.gridArticle.ReadOnly = true;
            this.gridArticle.RowTemplate.Height = 33;
            this.gridArticle.Size = new System.Drawing.Size(898, 464);
            this.gridArticle.TabIndex = 0;
            this.gridArticle.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticle_CellContentDoubleClick);
            // 
            // gridId
            // 
            this.gridId.DataPropertyName = "Id";
            this.gridId.HeaderText = "Id";
            this.gridId.Name = "gridId";
            this.gridId.ReadOnly = true;
            // 
            // gridNr
            // 
            this.gridNr.DataPropertyName = "Nr";
            this.gridNr.HeaderText = "Nr";
            this.gridNr.Name = "gridNr";
            this.gridNr.ReadOnly = true;
            // 
            // gridName
            // 
            this.gridName.DataPropertyName = "Name";
            this.gridName.HeaderText = "Name";
            this.gridName.Name = "gridName";
            this.gridName.ReadOnly = true;
            // 
            // gridOwner
            // 
            this.gridOwner.DataPropertyName = "OwnerName";
            this.gridOwner.HeaderText = "Eigentümer";
            this.gridOwner.Name = "gridOwner";
            this.gridOwner.ReadOnly = true;
            // 
            // gridArticlegroup
            // 
            this.gridArticlegroup.DataPropertyName = "ArticleGroupName";
            this.gridArticlegroup.HeaderText = "Artikelgruppe";
            this.gridArticlegroup.Name = "gridArticlegroup";
            this.gridArticlegroup.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1325, 785);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(191, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.numMeldeBestand);
            this.groupBox2.Controls.Add(this.numMinBestand);
            this.groupBox2.Controls.Add(this.numBestand);
            this.groupBox2.Controls.Add(this.selectOwner);
            this.groupBox2.Controls.Add(this.selectArticleGroup);
            this.groupBox2.Controls.Add(this.txtSerialNumber);
            this.groupBox2.Controls.Add(this.txtLagerPlatz);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Seriennummer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.Location = new System.Drawing.Point(639, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSave.Location = new System.Drawing.Point(639, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(639, 35);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(191, 50);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Neu";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // numMeldeBestand
            // 
            this.numMeldeBestand.Location = new System.Drawing.Point(710, 287);
            this.numMeldeBestand.Name = "numMeldeBestand";
            this.numMeldeBestand.Size = new System.Drawing.Size(120, 31);
            this.numMeldeBestand.TabIndex = 5;
            // 
            // numMinBestand
            // 
            this.numMinBestand.Location = new System.Drawing.Point(386, 287);
            this.numMinBestand.Name = "numMinBestand";
            this.numMinBestand.Size = new System.Drawing.Size(120, 31);
            this.numMinBestand.TabIndex = 5;
            // 
            // numBestand
            // 
            this.numBestand.Location = new System.Drawing.Point(103, 287);
            this.numBestand.Name = "numBestand";
            this.numBestand.Size = new System.Drawing.Size(120, 31);
            this.numBestand.TabIndex = 5;
            // 
            // selectOwner
            // 
            this.selectOwner.FormattingEnabled = true;
            this.selectOwner.Location = new System.Drawing.Point(154, 146);
            this.selectOwner.Name = "selectOwner";
            this.selectOwner.Size = new System.Drawing.Size(386, 33);
            this.selectOwner.TabIndex = 2;
            // 
            // selectArticleGroup
            // 
            this.selectArticleGroup.FormattingEnabled = true;
            this.selectArticleGroup.Location = new System.Drawing.Point(154, 93);
            this.selectArticleGroup.Name = "selectArticleGroup";
            this.selectArticleGroup.Size = new System.Drawing.Size(386, 33);
            this.selectArticleGroup.TabIndex = 1;
            // 
            // txtLagerPlatz
            // 
            this.txtLagerPlatz.Location = new System.Drawing.Point(154, 199);
            this.txtLagerPlatz.Name = "txtLagerPlatz";
            this.txtLagerPlatz.Size = new System.Drawing.Size(386, 31);
            this.txtLagerPlatz.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 31);
            this.txtName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Melde Bestand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Min Bestand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bestand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lagerplatz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Eigentümer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Warengruppe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // btnLabel
            // 
            this.btnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLabel.Location = new System.Drawing.Point(203, 199);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(191, 50);
            this.btnLabel.TabIndex = 4;
            this.btnLabel.Text = "Label drucken";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(916, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(600, 464);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticle_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nr";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Seriennummer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LagerPlatz";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lagerplatz";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnLabel);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(916, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 264);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lagerplatz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seriennummer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 31);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Neu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Location = new System.Drawing.Point(203, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.Location = new System.Drawing.Point(400, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Löschen";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Seriennummer
            // 
            this.Seriennummer.AutoSize = true;
            this.Seriennummer.Location = new System.Drawing.Point(6, 248);
            this.Seriennummer.Name = "Seriennummer";
            this.Seriennummer.Size = new System.Drawing.Size(151, 25);
            this.Seriennummer.TabIndex = 2;
            this.Seriennummer.Text = "Seriennummer";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(154, 245);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(386, 31);
            this.txtSerialNumber.TabIndex = 4;
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 871);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gridArticle);
            this.Name = "Article";
            this.Text = "Artikel";
            ((System.ComponentModel.ISupportInitialize)(this.gridArticle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeldeBestand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinBestand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBestand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridArticle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox selectOwner;
        private System.Windows.Forms.ComboBox selectArticleGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLagerPlatz;
        private System.Windows.Forms.NumericUpDown numMeldeBestand;
        private System.Windows.Forms.NumericUpDown numMinBestand;
        private System.Windows.Forms.NumericUpDown numBestand;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridArticlegroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label Seriennummer;
    }
}