using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    class ArticleUnit
    {
        private String id;

        private Article article;

        private string lagerPlatz;

        private int nr;
        
        private string serialNumber;

        private DateTime created = new DateTime();

        private Boolean outSourced = false;

        public string ArticleName
        {
            get
            {
                return this.article.Name;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Article Article
        {
            get
            {
                return article;
            }

            set
            {
                article = value;
            }
        }

        public string LagerPlatz
        {
            get
            {
                return lagerPlatz;
            }

            set
            {
                lagerPlatz = value;
            }
        }

        public int Nr
        {
            get
            {
                return nr;
            }

            set
            {
                nr = value;
            }
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return created;
            }

            set
            {
                created = value;
            }
        }

        public bool OutSourced
        {
            get
            {
                return outSourced;
            }

            set
            {
                outSourced = value;
            }
        }
    }
}
