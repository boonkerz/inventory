using System;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using Inventory.Model;

namespace Inventory.Provider
{

	public class LocalSettings
	{
		private Inventory.Model.LocalSettings settings;
		const String CONFIG_FILENAME = "inventorSettings.json";


		public Inventory.Model.LocalSettings getSettings()
		{
			parseJsonObject();
			return this.settings;
		}

		public void saveSettings(Inventory.Model.LocalSettings sett)
		{
			String data = JsonConvert.SerializeObject(sett);
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CONFIG_FILENAME);

			File.WriteAllText(path, data);

		}

		private void parseJsonObject()
		{
			String data = loadJsonData();

			settings = JsonConvert.DeserializeObject<Inventory.Model.LocalSettings>(data);

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
