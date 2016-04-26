using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;
using SemanaTecnologiaEvolucao.Models;

namespace SemanaTecnologiaEvolucao.Controllers
{
    public class RequisicoesController : ApiController
    {

        private Interfaces.ITrabalhos interfa;
        public RequisicoesController()
        {
            interfa = new AgendaSemanaTecnologia();
        }


        public MongoCollection Listar()
        {
            return interfa.ListarApresentacoes();
        }
    }
}
