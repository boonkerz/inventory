using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
    class Settings
    {
        private Inventory.Provider.Database database;

        private Inventory.Model.LocalSettings settings = Inventory.Provider.Container.getSettings();

        public Settings(Inventory.Provider.Database database)
        {
            this.database = database;
        }

        public ArrayList getAll()
        {
            var filter = new BsonDocument();

            ArrayList data = new ArrayList();

            IMongoCollection<BsonDocument> coll = this.database.getCollection("projects");

            foreach (BsonDocument item in coll.Find(filter).ToList())
            {
                data.Add(new Model.Project(item.GetValue("_id").ToString(), item.GetValue("name").ToString(), item.GetValue("nr").ToInt32()));
            }

            return data;
        }

        public void insert(Inventory.Model.Project project)
        {
            Model.LocalSettings settings = Provider.Container.getSettings();

            var document = new BsonDocument
            {
                { "name", project.Name },
                { "nr",  settings.StartNumberProject}
            };

            this.database.getCollection("projects").InsertOne(document);
            project.Nr = settings.StartNumberProject;
            project.Id = document.GetValue("_id").ToString();

            settings.StartNumberProject++;
            Provider.LocalSettings set = new Provider.LocalSettings();
            set.saveSettings(settings);
        }

        public void update(Inventory.Model.Project project)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(new ObjectId(project.Id)));

            var document = new BsonDocument
            {
                { "name", project.Name },
                { "nr", project.Nr }
            };

            this.database.getCollection("projects").ReplaceOne(filter, document);
        }

        public void delete(Inventory.Model.Project project)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new BsonObjectId(ObjectId.Parse(project.Id)));

            this.database.getCollection("projects").DeleteOne(filter);
        }
    }
}
