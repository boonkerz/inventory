using System;
using Inventory.Model;

namespace Inventory.Provider
{
	public class Container
	{
		private static Inventory.Model.Settings settings;

		private static Inventory.Provider.Database database;

		public static Inventory.Model.Settings getSettings()
		{
			if (settings == null)
			{
				var settProvider = new Provider.Settings();
				settings = settProvider.getSettings();
			}
			return settings;


		}

		public static Inventory.Provider.Database getDatabase()
		{
			if (database == null)
			{
				database = new Provider.Database(getSettings());
			}
			return database;


		}
	}
}
