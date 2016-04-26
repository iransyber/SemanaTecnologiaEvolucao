using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;

namespace SemanaTecnologiaEvolucao.Controllers
{
    public class BaseController : Controller
    {
        public MongoDatabase database;
        public BaseController()
        {
            //var credential = MongoCredential.CreateMongoCRCredential("test", "user1", "password1");
            //var settings = new MongoClientSettings
            //{
            //    Credentials = new[] { credential }
            //};

            //var mongoClient = new MongoClient(settings);
            
            const string connectionstring = "mongodb://iransyber.southcentralus.cloudapp.azure.com";
            var client = new MongoClient(connectionstring);
            var server = client.GetServer();
            database = server.GetDatabase("SemanaTecnologia");
        }
    }
}