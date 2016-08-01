using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Model;
using System.Collections;
using MongoDB.Driver;

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
                { "serialNumber", articleUnit.SerialNumber },
                { "outSourced", new BsonBoolean(articleUnit.OutSourced) },
                { "article", new BsonDocument {
                        {"$ref", "article"},
                        {"$id" , new BsonObjectId(new ObjectId(articleUnit.Article.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "nr",  settings.StartNumberArticleUnit}
            };

            this.database.getCollection("articleUnits").InsertOne(document);

            articleUnit.Nr = settings.StartNumberArticleUnit;
            articleUnit.Id = document.GetValue("_id").ToString();

            settings.StartNumberArticleUnit++;
            Provider.Settings set = new Provider.Settings();
            set.saveSettings(settings);
        }

        public void update(Inventory.Model.ArticleUnit articleUnit)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(articleUnit.Id)));

            var document = new BsonDocument
            {
                { "lagerPlatz", articleUnit.LagerPlatz },
                { "created", new BsonDateTime(articleUnit.Created) },
                { "serialNumber", articleUnit.SerialNumber },
                { "outSourced", new BsonBoolean(articleUnit.OutSourced) },
                { "article", new BsonDocument {
                        {"$ref", "article"},
                        {"$id" , new BsonObjectId(new ObjectId(articleUnit.Article.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "nr",  articleUnit.Nr}
            };

            this.database.getCollection("articleUnits").ReplaceOne(filter, document);
        }

        public ArrayList getAllByArticle(Model.Article actArticle)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("article.$id", new BsonObjectId(new ObjectId(actArticle.Id)));

            ArrayList data = new ArrayList();

            IMongoCollection<BsonDocument> coll = this.database.getCollection("articleUnits");

            foreach (BsonDocument item in coll.Find(filter).ToList())
            {
                Model.ArticleUnit articleUnit = new Model.ArticleUnit();
                articleUnit.Id = item.GetValue("_id").ToString();
                articleUnit.Nr = item.GetValue("nr").ToInt32();
                articleUnit.LagerPlatz = item.GetValue("lagerPlatz").ToString();
                articleUnit.SerialNumber = item.GetValue("serialNumber").ToString();
                articleUnit.OutSourced = item.GetValue("outSourced").ToBoolean();
                data.Add(articleUnit);
            }

            return data;
        }

        public void delete(Inventory.Model.ArticleUnit articleUnit)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(ObjectId.Parse(articleUnit.Id)));
            this.database.getCollection("articleUnits").DeleteOne(filter);
        }

        public Model.ArticleUnit getOneBySerialNumber(string v)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("serialNumber", v) | Builders<BsonDocument>.Filter.Eq("nr", Int32.Parse(v));

            IMongoCollection<BsonDocument> coll = this.database.getCollection("articleUnits");

            var autoColl = coll.Find(filter);
            
            if (autoColl.Count() == 0)
            {
                return null;
            }

            Inventory.Repository.Article repoArticle = new Repository.Article(Inventory.Provider.Container.getDatabase());

            Model.ArticleUnit articleUnit = new Model.ArticleUnit();
            BsonDocument item = autoColl.Single();
            articleUnit.Id = item.GetValue("_id").ToString();
            articleUnit.Nr = item.GetValue("nr").ToInt32();
            articleUnit.LagerPlatz = item.GetValue("lagerPlatz").ToString();
            articleUnit.SerialNumber = item.GetValue("serialNumber").ToString();
            articleUnit.OutSourced = item.GetValue("outSourced").ToBoolean();

            articleUnit.Article = repoArticle.getOne(item.GetValue("article").ToBsonDocument().GetValue("$id").ToString());

            return articleUnit;
        }
    }
}
