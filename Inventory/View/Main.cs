using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.View.Settings setWindow = new View.Settings();
            setWindow.Show();

        }

        private void btnArticleGroups_Click(object sender, EventArgs e)
        {
            View.articleGroups grouWindow = new View.articleGroups();
            grouWindow.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            View.Customer customerWindow = new View.Customer();
            customerWindow.Show();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            View.Article articleWindow = new View.Article();
            articleWindow.Show();
        }

        private void btnArticleAuslagern_Click(object sender, EventArgs e)
        {
            View.ArticleOutsourcing outSourcingWindow = new View.ArticleOutsourcing();
            outSourcingWindow.Show();
        }
    }
}
