using System;
using Inventory.Model;

namespace Inventory.Provider
{
	public class Container
	{
		private static Inventory.Model.LocalSettings localSettings;

        private static Inventory.Model.GlobalSettings globalSettings;

        private static Inventory.Provider.Database database;

		public static Inventory.Model.GlobalSettings getGlobalSettings()
		{
			if (globalSettings == null)
			{
				var settProvider = new Provider.GlobalSettings();
                globalSettings = settProvider.getSettings();
			}
			return globalSettings;
		}

        public static Inventory.Model.LocalSettings getLocalSettings()
        {
            if (localSettings == null)
            {
                var settProvider = new Provider.LocalSettings();
                localSettings = settProvider.getSettings();
            }
            return localSettings;
        }


        public static Inventory.Provider.Database getDatabase()
		{
			if (database == null)
			{
				database = new Provider.Database(getLocalSettings());
			}
			return database;


		}
	}
}
