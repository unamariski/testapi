using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //MongoClient dbClient = new MongoDB.Driver.MongoClient("mongodb://127.0.0.1:27017");
            //MongoClient dbClient = new MongoDB.Driver.MongoClient();
            
            //var dbList = dbClient.ListDatabases().ToList();

            //Console.WriteLine("The list of databases are :");
            //foreach (var item in dbList)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < 5; i++)
            {
                BsonObjectId id = BsonObjectId.Create(ObjectId.GenerateNewId(DateTime.Now));
                Console.WriteLine(id);

                
            }

            
        }
    }
}
