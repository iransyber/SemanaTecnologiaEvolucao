using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using SemanaTecnologiaEvolucao.Controllers;
using SemanaTecnologiaEvolucao.Interfaces;

namespace SemanaTecnologiaEvolucao.Models
{
    public class AgendaSemanaTecnologia: BaseController, ITrabalhos
    {
        readonly BaseController context = new BaseController();
        public MongoCollection ListarApresentacoes()
        {
            var trab = context.database.GetCollection<Trabalhos>("Trabalhos");
            return trab;
        }

    }
}