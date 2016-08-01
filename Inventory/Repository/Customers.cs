using System;
using System.Collections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Inventory.Repository
{
	public class Customers
	{
		private Inventory.Provider.Database database;

		public Customers(Inventory.Provider.Database database)
		{
			this.database = database;
		}

		public ArrayList getAll()
		{
			var filter = new BsonDocument();

			ArrayList data = new ArrayList();

			IMongoCollection<BsonDocument> coll = this.database.getCollection("customers");

			foreach (BsonDocument item in coll.Find(filter).ToList())
			{
				data.Add(new Model.Customer(item.GetValue("_id").ToString(), item.GetValue("name").ToString(), item.GetValue("email").ToString(), item.GetValue("tel").ToString(), item.GetValue("nr").ToInt32()));
			}

			return data;

		}

		public void insert(Inventory.Model.Customer customer)
		{
            Model.Settings settings = Provider.Container.getSettings();

            var document = new BsonDocument
			{
				{ "name", customer.Name },
				{ "email", customer.Email },
				{ "tel", customer.Tel },
                { "nr",  settings.StartNumberCustomer}
            };

			this.database.getCollection("customers").InsertOne(document);
            customer.Id = document.GetValue("_id").ToString();
            customer.Nr = settings.StartNumberCustomer;

            settings.StartNumberCustomer++;
            Provider.Settings set = new Provider.Settings();
            set.saveSettings(settings);
        }

		public void update(Inventory.Model.Customer customer)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(customer.Id)));

			var document = new BsonDocument
			{
				{ "name", customer.Name },
				{ "email", customer.Email },
				{ "tel", customer.Tel },
                { "nr", customer.Nr }
            };

			this.database.getCollection("customers").ReplaceOne(filter, document);
		}

		public void delete(Inventory.Model.Customer customer)
		{
			var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(ObjectId.Parse(customer.Id)));

			this.database.getCollection("customers").DeleteOne(filter);
		}

        public Model.Customer getOne(string v)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(v)));

            IMongoCollection<BsonDocument> coll = this.database.getCollection("customers");

            BsonDocument item = coll.Find(filter).Single();

            Model.Customer data = new Model.Customer(item.GetValue("_id").ToString(), item.GetValue("name").ToString(), item.GetValue("email").ToString(), item.GetValue("tel").ToString(), item.GetValue("nr").ToInt32());

            return data;
        }
    }
}
