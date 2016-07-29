using System;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using Inventory.Model;

namespace Inventory.Provider
{

	public class Settings
	{
		private Inventory.Model.Settings settings;
		const String CONFIG_FILENAME = "inventorSettings.json";


		public Inventory.Model.Settings getSettings()
		{
			parseJsonObject();
			return this.settings;
		}

		public void saveSettings(Inventory.Model.Settings sett)
		{
			String data = JsonConvert.SerializeObject(sett);
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CONFIG_FILENAME);

			File.WriteAllText(path, data);

		}

		private void parseJsonObject()
		{
			String data = loadJsonData();

			settings = JsonConvert.DeserializeObject<Inventory.Model.Settings>(data);

		}

		private String loadJsonData()
		{
			String data = "";

			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CONFIG_FILENAME);

			if (File.Exists(path))
			{
				data = File.ReadAllText(path);
			}
			else
			{
				data = readDefaultSettings();
				writeDefaultSettingsToUser(path, data);
			}

			return data;
		}

		private String readDefaultSettings()
		{
			return File.ReadAllText(appDirectory());
		}

		private void writeDefaultSettingsToUser(String path, String data)
		{
			File.WriteAllText(path, data);
		}

		private string appDirectory()
		{
			return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", CONFIG_FILENAME);
		}

	}




}
