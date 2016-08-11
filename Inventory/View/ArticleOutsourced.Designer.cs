namespace Inventory.View
{
    partial class ArticleOutsourced
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
            this.gridArticleUnits = new System.Windows.Forms.DataGridView();
            this.txtArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // gridArticleUnits
            // 
            this.gridArticleUnits.AllowUserToAddRows = false;
            this.gridArticleUnits.AllowUserToDeleteRows = false;
            this.gridArticleUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticleUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticleUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtArticle,
            this.txtNr,
            this.txtSerialNumber,
            this.txtCustomer});
            this.gridArticleUnits.Location = new System.Drawing.Point(12, 12);
            this.gridArticleUnits.Name = "gridArticleUnits";
            this.gridArticleUnits.ReadOnly = true;
            this.gridArticleUnits.Size = new System.Drawing.Size(1318, 728);
            this.gridArticleUnits.TabIndex = 0;
            // 
            // txtArticle
            // 
            this.txtArticle.DataPropertyName = "ArticleName";
            this.txtArticle.HeaderText = "Artikel";
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.ReadOnly = true;
            // 
            // txtNr
            // 
            this.txtNr.DataPropertyName = "Nr";
            this.txtNr.HeaderText = "Nr";
            this.txtNr.Name = "txtNr";
            this.txtNr.ReadOnly = true;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.DataPropertyName = "SerialNumber";
            this.txtSerialNumber.HeaderText = "SerienNummer";
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DataPropertyName = "OutSourcedCustomerName";
            this.txtCustomer.HeaderText = "Kunde";
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            // 
            // ArticleOutsourced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 752);
            this.Controls.Add(this.gridArticleUnits);
            this.Name = "ArticleOutsourced";
            this.Text = "Aktuell ausgeliehen";
            this.Load += new System.EventHandler(this.ArticleOutsourced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticleUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridArticleUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomer;
    }
}