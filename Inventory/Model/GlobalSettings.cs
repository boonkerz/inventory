using System;

namespace Inventory.Model
{
	public class GlobalSettings
	{
		private int startNumberArticle;
        private int startNumberArticleUnit;
        private int startNumberCustomer;
        private int startNumberArticlegroup;
        private int startNumberBooking;
        private int startNumberProject;

		public GlobalSettings()
		{
		}

        public int StartNumberArticle
        {
            get
            {
                return startNumberArticle;
            }

            set
            {
                startNumberArticle = value;
            }
        }

        public int StartNumberCustomer
        {
            get
            {
                return startNumberCustomer;
            }

            set
            {
                startNumberCustomer = value;
            }
        }

        public int StartNumberArticlegroup
        {
            get
            {
                return startNumberArticlegroup;
            }

            set
            {
                startNumberArticlegroup = value;
            }
        }

        public int StartNumberBooking
        {
            get
            {
                return startNumberBooking;
            }

            set
            {
                startNumberBooking = value;
            }
        }

        public int StartNumberProject
        {
            get
            {
                return startNumberProject;
            }

            set
            {
                startNumberProject = value;
            }
        }

        public int StartNumberArticleUnit
        {
            get
            {
                return startNumberArticleUnit;
            }

            set
            {
                startNumberArticleUnit = value;
            }
        }
    }
}
