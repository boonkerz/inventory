using System;

namespace Inventory.Model
{
	public class LocalSettings
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
        private String belegOutsourcedVorlageFile;
        private String belegOutsourcedSaveDir;

		public LocalSettings()
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

        public string BelegOutsourcedVorlageFile
        {
            get
            {
                return belegOutsourcedVorlageFile;
            }

            set
            {
                belegOutsourcedVorlageFile = value;
            }
        }

        public string BelegOutsourcedSaveDir
        {
            get
            {
                return belegOutsourcedSaveDir;
            }

            set
            {
                belegOutsourcedSaveDir = value;
            }
        }
    }
}
