using System;
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
    public partial class ArticleBack : Form
    {
        Repository.ArticleUnit repoUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());
        
        public ArticleBack()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backArticle();
        }

        private void backArticle()
        {
            this.lblMessage.BackColor = Color.Transparent;
            this.lblMessage.Text = "";
            Model.ArticleUnit artUnit = repoUnit.getOneBySerialNumber(this.txtSerialNumber.Text);

            if (artUnit == null)
            {
                MessageBox.Show("Artikel nicht gefunden");
                return;
            }

            if (!artUnit.OutSourced)
            {
                MessageBox.Show("Artikel nicht ausgeliehen");
                return;
            }

            artUnit.OutSourced = false;
            repoUnit.update(artUnit);

            this.lblMessage.Text = "Erfolgreich";
            this.lblMessage.BackColor = Color.LightGreen;
            this.txtSerialNumber.Text = "";
            this.txtSerialNumber.Focus();
        }

        private void txtSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                backArticle();
            }
        }
    }
}
