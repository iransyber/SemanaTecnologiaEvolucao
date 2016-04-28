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
            const string connectionstring = "mongodb://iransyber:Iran10301988@ds021771.mlab.com:21771/iransyberdb?connectTimeoutMS=30000&authMechanism=SCRAM-SHA-1";
            var client = new MongoClient(connectionstring);
            var server = client.GetServer();
            database = server.GetDatabase("iransyberdb");
        }
    }
}