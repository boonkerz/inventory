using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
    class ArticleUnit
    {
        private Inventory.Provider.Database database;

        private Inventory.Model.Settings settings = Inventory.Provider.Container.getSettings();

        public ArticleUnit(Inventory.Provider.Database database)
        {
            this.database = database;
        }

        public void insert(Inventory.Model.ArticleUnit articleUnit)
        {
            Model.Settings settings = Provider.Container.getSettings();

            var document = new BsonDocument
            {
                { "lagerPlatz", articleUnit.LagerPlatz },
                { "created", new BsonDateTime(articleUnit.Created) },
                { "article", new BsonDocument {
                        {"$ref", "article"},
                        {"$id" , new BsonObjectId(new ObjectId(articleUnit.Article.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "nr",  settings.StartNumberArticleUnit}
            };

            this.database.getCollection("articleUnits").InsertOne(document);

            settings.StartNumberArticleUnit++;
            Provider.Settings set = new Provider.Settings();
            set.saveSettings(settings);
        }
    }
}
