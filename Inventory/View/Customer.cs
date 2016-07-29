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
    public partial class Customer : Form
    {

        Inventory.Repository.Customers repo = new Repository.Customers(Inventory.Provider.Container.getDatabase());

        Model.Customer actCustomer = new Model.Customer(null, null, null, null, 0);

        Inventory.Model.Settings settings = Inventory.Provider.Container.getSettings();

        public Customer()
        {
            InitializeComponent();
            loadData();
            this.btnDelete.Enabled = false;
        }

        private void loadData()
        {
            this.gridCustomer.DataSource = repo.getAll();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.actCustomer = (Model.Customer)this.gridCustomer.CurrentRow.DataBoundItem;
            this.txtName.Text = this.actCustomer.Name;
            this.txtEmail.Text = this.actCustomer.Email;
            this.txtTel.Text = this.actCustomer.Tel;
            this.btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repo.delete(actCustomer);
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            actCustomer.Name = this.txtName.Text;
            actCustomer.Email = this.txtEmail.Text;
            actCustomer.Tel = this.txtTel.Text;

            if (actCustomer.Id == null)
            {
                repo.insert(actCustomer);
            }
            else
            {
                repo.update(actCustomer);
            }
            actCustomer = new Model.Customer(null, null, null, null, 0);
            this.txtName.Text = "";
            this.txtTel.Text = "";
            this.txtEmail.Text = "";
            this.btnDelete.Enabled = false;
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            actCustomer = new Model.Customer(null, null, null, null, 0);
            this.txtName.Text = "";
            this.txtTel.Text = "";
            this.txtEmail.Text = "";
            this.btnDelete.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
