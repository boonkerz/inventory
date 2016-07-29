using System;
using MongoDB.Bson;
using System.Collections;
using MongoDB.Driver;

namespace Inventory.Repository
{
	public class Article
	{
		private Inventory.Provider.Database database;

		private Inventory.Model.Settings settings = Inventory.Provider.Container.getSettings();

		public Article(Inventory.Provider.Database database)
		{
			this.database = database;
		}

        public ArrayList getAll()
        {
            var filter = new BsonDocument();

            Inventory.Repository.Articlegroups repoArticleGroup = new Repository.Articlegroups(Inventory.Provider.Container.getDatabase());

            Inventory.Repository.Customers repoCustomer = new Repository.Customers(Inventory.Provider.Container.getDatabase());

            ArrayList data = new ArrayList();

            IMongoCollection<BsonDocument> coll = this.database.getCollection("articles");

            foreach (BsonDocument item in coll.Find(filter).ToList())
            {
                Model.Article article = new Model.Article();
                article.Id = item.GetValue("_id").ToString();
                article.Bestand = item.GetValue("bestand").ToInt32();
                article.MinBestand = item.GetValue("minBestand").ToInt32();
                article.MeldeBestand = item.GetValue("meldeBestand").ToInt32();
                article.Nr = item.GetValue("nr").ToInt32();
                article.Name = item.GetValue("name").ToString();

                article.ArticleGroup = repoArticleGroup.getOne(item.GetValue("articleGroup").ToBsonDocument().GetValue("$id").ToString());
                article.Owner = repoCustomer.getOne(item.GetValue("owner").ToBsonDocument().GetValue("$id").ToString());
                data.Add(article);
            }

            return data;

        }

        public void insert(Inventory.Model.Article article)
		{
            Model.Settings settings = Provider.Container.getSettings();

            var document = new BsonDocument
			{
				{ "name", article.Name },
				{ "bestand", article.Bestand },
				{ "minBestand", article.MinBestand },
				{ "meldeBestand", article.MeldeBestand },
				{ "created", new BsonDateTime(article.Created) },
				{ "articleGroup", new BsonDocument {
						{"$ref", "articlegroups"},
						{"$id" , new BsonObjectId(new ObjectId(article.ArticleGroup.Id))},
						{"$db" , settings.DbName}
					}
				},
				{ "owner", new BsonDocument {
						{"$ref", "customers"},
						{"$id" , new BsonObjectId(new ObjectId(article.Owner.Id))},
						{"$db" , settings.DbName}
					}
				},
                { "nr",  settings.StartNumberArticle}
            };

			this.database.getCollection("articles").InsertOne(document);
            article.Id = document.GetValue("_id").ToString();
            settings.StartNumberArticlegroup++;
            Provider.Settings set = new Provider.Settings();
            set.saveSettings(settings);
        }

        public void update(Inventory.Model.Article article)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(article.Id)));

            var document = new BsonDocument
            {
                { "name", article.Name },
                { "bestand", article.Bestand },
                { "minBestand", article.MinBestand },
                { "meldeBestand", article.MeldeBestand },
                { "created", new BsonDateTime(article.Created) },
                { "articleGroup", new BsonDocument {
                        {"$ref", "articlegroups"},
                        {"$id" , new BsonObjectId(new ObjectId(article.ArticleGroup.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "owner", new BsonDocument {
                        {"$ref", "customers"},
                        {"$id" , new BsonObjectId(new ObjectId(article.Owner.Id))},
                        {"$db" , settings.DbName}
                    }
                },
                { "nr",  settings.StartNumberArticle}
            };

            this.database.getCollection("articles").ReplaceOne(filter, document);
        }

        public void delete(Inventory.Model.Article article)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(ObjectId.Parse(article.Id)));

            this.database.getCollection("articles").DeleteOne(filter);
        }
    }
}
