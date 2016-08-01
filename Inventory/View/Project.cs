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
    public partial class Project : Form
    {
        Inventory.Repository.Projects repo = new Repository.Projects(Inventory.Provider.Container.getDatabase());

        Model.Project actGroup = new Model.Project(null, null, 0);

        public Project()
        {
            InitializeComponent();
        }

        private void ArticleGroups_Load(object sender, EventArgs e)
        {
            this.loadData();
            this.btnDelete.Enabled = false;
        }

        private void loadData()
        {
            this.gridProjects.DataSource = repo.getAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            actGroup = new Model.Project(null, null, 0);
            this.txtName.Text = "";
            this.btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            actGroup.Name = this.txtName.Text;

            if (actGroup.Id == null)
            {
                repo.insert(actGroup);
            }
            else
            {
                repo.update(actGroup);
            }
            actGroup = new Model.Project(null, null, 0);
            this.txtName.Text = "";
            this.btnDelete.Enabled = false;
            loadData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repo.delete(this.actGroup);
            this.actGroup = new Model.Project(null, null, 0);
            this.btnDelete.Enabled = false;
            this.loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridArticleGroups_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void gridArticleGroups_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.actGroup = (Model.Project)this.gridProjects.CurrentRow.DataBoundItem;
            this.txtName.Text = this.actGroup.Name;
            this.btnDelete.Enabled = true;
        }
    }
}
