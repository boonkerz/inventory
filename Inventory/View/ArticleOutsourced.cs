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
    public partial class ArticleOutsourced : Form
    {
        Repository.ArticleUnit repoUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());
        
        public ArticleOutsourced()
        {
            InitializeComponent();
        }

        private void ArticleOutsourced_Load(object sender, EventArgs e)
        {
            this.gridArticleUnits.AutoGenerateColumns = false;
            this.gridArticleUnits.DataSource = repoUnit.getAllOutsourced();
        }
    }
}
