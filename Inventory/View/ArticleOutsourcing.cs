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
    public partial class ArticleOutsourcing : Form
    {
        Inventory.Repository.Customers repoCustomer = new Repository.Customers(Inventory.Provider.Container.getDatabase());

        Inventory.Repository.Projects repoProject = new Repository.Projects(Inventory.Provider.Container.getDatabase());
        
        Repository.ArticleUnit repoUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());

        Repository.Bookings repoBooking = new Repository.Bookings(Inventory.Provider.Container.getDatabase());


        Model.Booking booking = new Model.Booking();

        public ArticleOutsourcing()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.selectCustomer.DataSource = repoCustomer.getAll();
            this.selectCustomer.ValueMember = "Id";
            this.selectCustomer.DisplayMember = "Name";

            var projects = repoProject.getAll();

            this.selectProject.DataSource = projects;
            if (projects.Count > 0)
            {
                this.selectProject.ValueMember = "Id";
                this.selectProject.DisplayMember = "Name";
            }
            this.gridArticleUnits.AutoGenerateColumns = false;
            if (this.booking.ArticleUnits.Count > 0)
            {
                this.gridArticleUnits.DataSource = null;
                this.gridArticleUnits.DataSource = this.booking.ArticleUnits;
                
            }
        }

        private void ArticleOutsourcing_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertArticle();
        }

        private void insertArticle()
        {
            Model.ArticleUnit artUnit = repoUnit.getOneBySerialNumber(this.txtSerialNumber.Text);
            
            if (artUnit == null)
            {
                MessageBox.Show("Artikel nicht gefunden");
                return;
            }

            foreach (Model.ArticleUnit item in this.booking.ArticleUnits)
            {
                if (item.Id == artUnit.Id)
                {
                    MessageBox.Show("Artikel schon vorhanden");
                    return;
                }
            }

            if(artUnit.OutSourced)
            {
                MessageBox.Show("Artikel schon ausgeliehen");
                return;
            }

            this.booking.ArticleUnits.Add(artUnit);

            loadData();
        }

        private void txtSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                insertArticle();
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Model.Project project = (Model.Project)this.selectProject.SelectedItem;
            if(project == null)
            {
                if(this.selectProject.Text.Length > 0)
                {
                    project = new Model.Project(null, this.selectProject.Text, 0);
                    repoProject.insert(project);
                }else
                {
                    MessageBox.Show("Artikel schon vorhanden");
                    return;
                }
            }

            this.booking.Description = this.txtDescription.Text;
            this.booking.Project = project;
            this.booking.Customer = (Model.Customer)this.selectCustomer.SelectedItem;

            this.repoBooking.insert(this.booking);
            
            if (MessageBox.Show("Beleg drucken?", "Drucken?", MessageBoxButtons.YesNo) == DialogResult.OK)
            {

            }

            this.booking = new Model.Booking();
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.booking = new Model.Booking();
            loadData();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            View.Customer customerWindow = new View.Customer();
            var result = customerWindow.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                loadData();
            }
        }

        private void btnEditProjects_Click(object sender, EventArgs e)
        {
            View.Project customerWindow = new View.Project();
            var result = customerWindow.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                loadData();
            }
        }
    }
}
