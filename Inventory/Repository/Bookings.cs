using MongoDB.Bson;
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

        private Inventory.Model.Settings settings = Inventory.Provider.Container.getSettings();

        public Bookings(Inventory.Provider.Database database)
        {
            this.database = database;
        }

        public void insert(Inventory.Model.Booking booking)
        {
            Model.Settings settings = Provider.Container.getSettings();

            BsonArray ArticleUnits = new BsonArray { };

            Inventory.Repository.ArticleUnit repoArticleUnit = new Repository.ArticleUnit(Inventory.Provider.Container.getDatabase());

            foreach (Model.ArticleUnit unit in booking.ArticleUnits)
            {
                ArticleUnits.Add(new BsonDocument {
                    {"$ref", "articleUnits"},
                    {"$id" , new BsonObjectId(new ObjectId(unit.Id))},
                    {"$db" , settings.DbName}
                });

                unit.OutSourced = true;

                repoArticleUnit.update(unit);
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

            settings.StartNumberArticleUnit++;
            Provider.Settings set = new Provider.Settings();
            set.saveSettings(settings);
        }
    }
}
