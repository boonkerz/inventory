namespace Inventory.View
{
    partial class ArticleOutsourcing
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
            this.selectCustomer = new System.Windows.Forms.ComboBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.gridArticleUnits = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.selectProject = new System.Windows.Forms.ComboBox();
            this.btnEditProjects = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCustomer
            // 
            this.selectCustomer.FormattingEnabled = true;
            this.selectCustomer.Location = new System.Drawing.Point(188, 12);
            this.selectCustomer.Name = "selectCustomer";
            this.selectCustomer.Size = new System.Drawing.Size(121, 21);
            this.selectCustomer.TabIndex = 0;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(188, 91);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(121, 20);
            this.txtSerialNumber.TabIndex = 1;
            this.txtSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNumber_KeyPress);
            // 
            // gridArticleUnits
            // 
            this.gridArticleUnits.AllowUserToAddRows = false;
            this.gridArticleUnits.AllowUserToDeleteRows = false;
            this.gridArticleUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticleUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtName,
            this.txSerialNumber});
            this.gridArticleUnits.Location = new System.Drawing.Point(87, 117);
            this.gridArticleUnits.Name = "gridArticleUnits";
            this.gridArticleUnits.ReadOnly = true;
            this.gridArticleUnits.Size = new System.Drawing.Size(631, 158);
            this.gridArticleUnits.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "Id";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "ArticleName";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txSerialNumber
            // 
            this.txSerialNumber.DataPropertyName = "SerialNumber";
            this.txSerialNumber.HeaderText = "Seriennummer";
            this.txSerialNumber.Name = "txSerialNumber";
            this.txSerialNumber.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(87, 378);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 40);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Neu";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 313);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(630, 59);
            this.txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kunde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Projekt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seriennummer";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(315, 91);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Einfügen";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(642, 378);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 40);
            this.btnBooking.TabIndex = 11;
            this.btnBooking.Text = "Buchen";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // selectProject
            // 
            this.selectProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectProject.FormattingEnabled = true;
            this.selectProject.Location = new System.Drawing.Point(188, 54);
            this.selectProject.Name = "selectProject";
            this.selectProject.Size = new System.Drawing.Size(121, 21);
            this.selectProject.TabIndex = 12;
            // 
            // btnEditProjects
            // 
            this.btnEditProjects.Location = new System.Drawing.Point(315, 54);
            this.btnEditProjects.Name = "btnEditProjects";
            this.btnEditProjects.Size = new System.Drawing.Size(111, 23);
            this.btnEditProjects.TabIndex = 13;
            this.btnEditProjects.Text = "Projekte bearbeiten";
            this.btnEditProjects.UseVisualStyleBackColor = true;
            this.btnEditProjects.Click += new System.EventHandler(this.btnEditProjects_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(315, 12);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(111, 23);
            this.btnEditCustomer.TabIndex = 13;
            this.btnEditCustomer.Text = "Kunden bearbeiten";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bemerkung";
            // 
            // ArticleOutsourcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 470);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnEditProjects);
            this.Controls.Add(this.selectProject);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gridArticleUnits);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.selectCustomer);
            this.Name = "ArticleOutsourcing";
            this.Text = "Artikel ausleihen";
            this.Load += new System.EventHandler(this.ArticleOutsourcing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCustomer;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.DataGridView gridArticleUnits;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.ComboBox selectProject;
        private System.Windows.Forms.Button btnEditProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txSerialNumber;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Label label5;
    }
}