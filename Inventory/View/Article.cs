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
    public partial class Article : Form
    {

        Inventory.Repository.Articlegroups repoArticleGroup = new Repository.Articlegroups(Inventory.Provider.Container.getDatabase());

        Inventory.Repository.Customers repoCustomer = new Repository.Customers(Inventory.Provider.Container.getDatabase());

        Inventory.Repository.Article repo = new Repository.Article(Inventory.Provider.Container.getDatabase());

        Inventory.Repository.ArticleUnit repoUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());

        Inventory.Model.Settings settings = Inventory.Provider.Container.getSettings();

        Model.Article actArticle = new Model.Article();

        Model.ArticleUnit actArticleUnit = new Model.ArticleUnit();

        public Article()
        {
            InitializeComponent();
            this.loadData();
        }

        private void loadData()
        {
            this.gridArticle.AutoGenerateColumns = false;
            this.gridArticleUnit.AutoGenerateColumns = false;
            this.gridArticle.DataSource = repo.getAll();

            this.gridArticleUnit.DataSource = null;

            this.selectArticleGroup.DataSource = repoArticleGroup.getAll();
            this.selectArticleGroup.DisplayMember = "Name";
            this.selectArticleGroup.ValueMember = "Id";
            this.selectOwner.DataSource = repoCustomer.getAll();
            this.selectOwner.DisplayMember = "Name";
            this.selectOwner.ValueMember = "Id";
            this.btnDelete.Enabled = false;
            this.btnDelUnit.Enabled = false;
            this.btnNewUnit.Enabled = false;
            this.btnSaveUnit.Enabled = false;
            this.gridArticleUnit.Enabled = false;
            this.txtLagerPlatzUnit.Enabled = false;
            this.txtSerialNumberUnit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            actArticle.Name = this.txtName.Text;
            actArticle.Bestand = (int)this.numBestand.Value;
            actArticle.MinBestand = (int)this.numMinBestand.Value;
            actArticle.MeldeBestand = (int)this.numMeldeBestand.Value;
            actArticle.ArticleGroup = (Model.Articlegroup)this.selectArticleGroup.SelectedItem;
            actArticle.Owner = (Model.Customer)this.selectOwner.SelectedItem;
            actArticle.Created = new DateTime();

            if (actArticle.Id == null)
            {
                repo.insert(actArticle);

                actArticleUnit.Article = actArticle;
                actArticleUnit.Created = new DateTime();
                actArticleUnit.LagerPlatz = this.txtLagerPlatz.Text;
                actArticleUnit.OutSourced = false;
                actArticleUnit.SerialNumber = this.txtSerialNumber.Text;

                repoUnit.insert(actArticleUnit);
            }
            else
            {
                repo.update(actArticle);
            }
            
            actArticle = new Model.Article();
            actArticleUnit = new Model.ArticleUnit();

            this.txtName.Text = "";
            this.txtLagerPlatz.Text = "";
            this.txtSerialNumber.Text = "";
            this.numBestand.Value = 1;
            this.numMinBestand.Value = 1;
            this.numMeldeBestand.Value = 1;
            this.btnDelete.Enabled = false;
            this.txtSerialNumber.Enabled = true;
            this.txtLagerPlatz.Enabled = true;
            
            loadData();
        }

        private void gridArticle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.actArticle = (Model.Article)this.gridArticle.CurrentRow.DataBoundItem;
            this.txtName.Text = this.actArticle.Name;
            this.numBestand.Value = this.actArticle.Bestand;
            this.numMeldeBestand.Value = this.actArticle.MeldeBestand;
            this.numMinBestand.Value = this.actArticle.MinBestand;

            this.selectArticleGroup.SelectedItem = this.actArticle.ArticleGroup;
            this.selectOwner.SelectedItem = this.actArticle.Owner;
            this.btnDelete.Enabled = true;
            this.txtLagerPlatz.Enabled = false;
            this.txtSerialNumber.Enabled = false;
            this.btnDelUnit.Enabled = false;
            this.btnNewUnit.Enabled = true;
            this.btnSaveUnit.Enabled = true;
            this.gridArticleUnit.Enabled = true;
            this.txtSerialNumberUnit.Enabled = true;
            this.txtLagerPlatzUnit.Enabled = true;

            this.gridArticleUnit.DataSource = repoUnit.getAllByArticle(this.actArticle);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            actArticle = new Model.Article();
            actArticleUnit = new Model.ArticleUnit();
            this.txtName.Text = "";
            this.txtLagerPlatz.Text = "";
            this.txtSerialNumber.Text = "";
            this.numBestand.Value = 1;
            this.numMinBestand.Value = 1;
            this.numMeldeBestand.Value = 1;
            this.btnDelete.Enabled = false;
            this.txtLagerPlatz.Enabled = true;
            this.txtSerialNumber.Enabled = true;
            this.btnDelete.Enabled = false;
            this.btnDelUnit.Enabled = false;
            this.btnNewUnit.Enabled = false;
            this.btnSaveUnit.Enabled = false;
            this.gridArticleUnit.Enabled = false;
            this.txtLagerPlatzUnit.Enabled = false;
            this.txtSerialNumberUnit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repo.delete(actArticle);
            actArticle = new Model.Article();
            actArticleUnit = new Model.ArticleUnit();
            this.txtName.Text = "";
            this.txtLagerPlatz.Text = "";
            this.txtSerialNumber.Text = "";
            this.numBestand.Value = 1;
            this.numMinBestand.Value = 1;
            this.numMeldeBestand.Value = 1;
            this.btnDelete.Enabled = false;
            this.txtLagerPlatz.Enabled = true;
            this.txtSerialNumber.Enabled = true;
            this.btnDelete.Enabled = false;
            this.btnDelUnit.Enabled = false;
            this.btnNewUnit.Enabled = false;
            this.btnSaveUnit.Enabled = false;
            this.gridArticleUnit.Enabled = false;
            this.txtLagerPlatzUnit.Enabled = false;
            this.txtSerialNumberUnit.Enabled = false;
            loadData();
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            actArticleUnit = new Model.ArticleUnit();

            this.txtLagerPlatzUnit.Text = "";
            this.txtSerialNumberUnit.Text = "";
            this.btnDelUnit.Enabled = false;
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            actArticleUnit.Article = actArticle;
            actArticleUnit.Created = new DateTime();
            actArticleUnit.LagerPlatz = this.txtLagerPlatz.Text;
            actArticleUnit.SerialNumber = this.txtSerialNumber.Text;

            if (actArticleUnit.Id == null)
            {
                repoUnit.insert(actArticleUnit);

                actArticle.Bestand++;

                repo.update(actArticle);
                this.numBestand.Value = actArticle.Bestand;
            }
            else
            {
                repo.update(actArticle);
            }

            actArticleUnit = new Model.ArticleUnit();
            this.txtLagerPlatzUnit.Text = "";
            this.txtSerialNumberUnit.Text = "";
            this.btnDelUnit.Enabled = false;

            this.gridArticleUnit.DataSource = repoUnit.getAllByArticle(actArticle);
        }

        private void btnDelUnit_Click(object sender, EventArgs e)
        {
            repoUnit.delete(actArticleUnit);

            actArticle.Bestand--;

            repo.update(actArticle);
            this.numBestand.Value = actArticle.Bestand;

            actArticleUnit = new Model.ArticleUnit();
            this.txtLagerPlatz.Text = "";
            this.txtSerialNumber.Text = "";
            this.btnDelUnit.Enabled = false;
        }

        private void btnPrintUnit_Click(object sender, EventArgs e)
        {
            var label = DYMO.Label.Framework.Label.Open(settings.LabelFile);
            label.SetObjectText("artikelNr", actArticleUnit.Nr.ToString());
            label.Print(settings.LabelPrinter);
        }

        private void gridArticleUnit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.actArticleUnit = (Model.ArticleUnit)this.gridArticleUnit.CurrentRow.DataBoundItem;
            this.txtLagerPlatzUnit.Text = this.actArticleUnit.LagerPlatz;
            this.txtSerialNumberUnit.Text = this.actArticleUnit.SerialNumber;

            this.btnDelUnit.Enabled = true;
        }
    }
}
