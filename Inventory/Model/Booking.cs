using System;
using System.Collections;

namespace Inventory.Model
{
    public class Booking
    {
        private String id;

        private DateTime created = new DateTime();

        private Customer customer;

        private int nr;

        private Project project;

        private String description;

        private ArrayList articleUnits;

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

        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
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

        public Project Project
        {
            get
            {
                return project;
            }

            set
            {
                project = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public ArrayList ArticleUnits
        {
            get
            {
                return articleUnits;
            }

            set
            {
                articleUnits = value;
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

        public Booking()
        {
            this.articleUnits = new ArrayList();
        }
	}
}
