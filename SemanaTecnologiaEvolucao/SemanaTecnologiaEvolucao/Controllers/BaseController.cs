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
        private MongoDatabase _database;
        public BaseController()
        {
            const string connectionstring = "mongodb://localhost";
            var client = new MongoClient(connectionstring);
            var server = client.GetServer();
            _database = server.GetDatabase("SemanaTecnologia");
        }
    }
}