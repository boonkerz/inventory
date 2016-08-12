using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
    class Bookings
    {
        private Inventory.Provider.Database database;

        private Inventory.Model.LocalSettings settings = Inventory.Provider.Container.getSettings();

        public Bookings(Inventory.Provider.Database database)
        {
            this.database = database;
        }

        public Model.Booking getOne(string v)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(v)));

            Inventory.Repository.Customers repoCustomer = new Repository.Customers(Inventory.Provider.Container.getDatabase());

            IMongoCollection<BsonDocument> coll = this.database.getCollection("bookings");

            BsonDocument item = coll.Find(filter).Single();

            Model.Booking booking = new Model.Booking();
            booking.Id = item.GetValue("_id").ToString();
            booking.Description = item.GetValue("description").ToString();
            booking.Customer = repoCustomer.getOne(item.GetValue("customer").ToBsonDocument().GetValue("$id").ToString());


            return booking;

        }

        public void insert(Inventory.Model.Booking booking)
        {
            Model.LocalSettings settings = Provider.Container.getSettings();

            BsonArray ArticleUnits = new BsonArray { };

            Inventory.Repository.ArticleUnit repoArticleUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());

            foreach (Model.ArticleUnit unit in booking.ArticleUnits)
            {
                ArticleUnits.Add(new BsonDocument {
                    {"$ref", "articleUnits"},
                    {"$id" , new BsonObjectId(new ObjectId(unit.Id))},
                    {"$db" , settings.DbName}
                });
                
            }

            var document = new BsonDocument
            {
                { "description", booking.Description },
                { "created", new BsonDateTime(booking.Created) },
                { "customer", new BsonDocument {
                        {"$ref", "customers"},
                        {"$id" , new BsonObjectId(new ObjectId(booking.Customer.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "articleUnits", ArticleUnits },
                { "nr",  settings.StartNumberBooking},

            };

            this.database.getCollection("bookings").InsertOne(document);

            booking.Nr = settings.StartNumberBooking;
            booking.Id = document.GetValue("_id").ToString();

            foreach (Model.ArticleUnit unit in booking.ArticleUnits)
            {
                unit.OutSourced = true;
                unit.OutSourcedBooking = booking;

                repoArticleUnit.update(unit);
            }
            
            settings.StartNumberBooking++;
            Provider.LocalSettings set = new Provider.LocalSettings();
            set.saveSettings(settings);
        }
    }
}
