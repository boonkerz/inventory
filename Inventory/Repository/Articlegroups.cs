using System;
using System.Collections;
using Inventory.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Inventory.Repository
{
	public class Articlegroups
	{
		private Inventory.Provider.Database database;

		public Articlegroups(Inventory.Provider.Database database)
		{
			this.database = database;
		}


		public ArrayList getAll()
		{
			var filter = new BsonDocument();

			ArrayList data = new ArrayList();

			IMongoCollection<BsonDocument> coll = this.database.getCollection("articlegroups");

			foreach(BsonDocument item in coll.Find(filter).ToList()) {
				data.Add(new Model.Articlegroup(item.GetValue("_id").ToString(), item.GetValue("name").ToString(), item.GetValue("nr").ToInt32()));
			}

			return data;

		}

		public void insert(Inventory.Model.Articlegroup group)
		{
            Model.LocalSettings settings = Provider.Container.getSettings();

			var document = new BsonDocument
			{
				{ "name", group.Name },
                { "nr",  settings.StartNumberArticlegroup}
			};

			this.database.getCollection("articlegroups").InsertOne(document);

            group.Nr = settings.StartNumberArticlegroup;
            group.Id = document.GetValue("_id").ToString();

            settings.StartNumberArticlegroup++;
            Provider.LocalSettings set = new Provider.LocalSettings();
            set.saveSettings(settings);
		}

		public void update(Inventory.Model.Articlegroup group)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(group.Id)));

			var document = new BsonDocument
			{
				{ "name", group.Name },
                { "nr", group.Nr }
            };

			this.database.getCollection("articlegroups").ReplaceOne(filter, document);
		}

		public void delete(Inventory.Model.Articlegroup group)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(ObjectId.Parse(group.Id)));

			this.database.getCollection("articlegroups").DeleteOne(filter);
		}

        public Articlegroup getOne(string v)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(v)));

            IMongoCollection<BsonDocument> coll = this.database.getCollection("articlegroups");

            BsonDocument item = coll.Find(filter).Single();

            Articlegroup data = new Model.Articlegroup(item.GetValue("_id").ToString(), item.GetValue("name").ToString(), item.GetValue("nr").ToInt32());

            return data;
        }
    }
}
