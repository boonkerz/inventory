using System;

namespace Inventory.Model
{
	public class Settings
	{
		private String dbHost;
		private String dbUserName;
		private String dbPassword;
		private String dbName;
		private Int16 dbPort;
		private int appX;
		private int appY;
		private String labelPrinter;
		private String labelFile;
        private int startNumberArticle;
        private int startNumberArticleUnit;
        private int startNumberCustomer;
        private int startNumberArticlegroup;
        private int startNumberBooking;
        private int startNumberProject;

		public Settings()
		{
		}

		public string DbHost
		{
			get
			{
				return dbHost;
			}

			set
			{
				dbHost = value;
			}
		}

		public short DbPort
		{
			get
			{
				return dbPort;
			}

			set
			{
				dbPort = value;
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}

			set
			{
				dbName = value;
			}
		}

		public string DbPassword
		{
			get
			{
				return dbPassword;
			}

			set
			{
				dbPassword = value;
			}
		}

		public string DbUserName
		{
			get
			{
				return dbUserName;
			}

			set
			{
				dbUserName = value;
			}
		}

		public int AppX
		{
			get
			{
				return appX;
			}

			set
			{
				appX = value;
			}
		}

		public int AppY
		{
			get
			{
				return appY;
			}

			set
			{
				appY = value;
			}
		}

		public string LabelFile
		{
			get
			{
				return labelFile;
			}

			set
			{
				labelFile = value;
			}
		}

		public string LabelPrinter
		{
			get
			{
				return labelPrinter;
			}

			set
			{
				labelPrinter = value;
			}
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
