using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Inventory.Provider
{
	public class Database
	{
		private Inventory.Model.LocalSettings settings;
       	private IMongoClient client;
		private IMongoDatabase database;

		public Database(Inventory.Model.LocalSettings settings)
		{
			this.settings = settings;

			this.client = new MongoClient("mongodb://"+ settings.DbUserName + ":" + settings.DbPassword + "@" + settings.DbHost + ":" + settings.DbPort + "/" + settings.DbName);
			this.database = this.client.GetDatabase(settings.DbName);

		}

		public IMongoDatabase getDatabase()
		{
			return this.database;
		}

		public IMongoCollection<BsonDocument> getCollection(String name)
		{
			return this.database.GetCollection<BsonDocument>(name);
		}
	}
}
