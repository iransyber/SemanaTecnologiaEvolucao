using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using SemanaTecnologiaEvolucao.Controllers;
using SemanaTecnologiaEvolucao.Interfaces;
using System.Data.Entity;

namespace SemanaTecnologiaEvolucao.Models
{
    public class AgendaSemanaTecnologia: BaseController, ITrabalhos
    {
        public IList<Trabalhos> ListarApresentacoes()
        {
            var trab = database.GetCollection<BsonDocument>("Trabalhos");

            var t = new Trabalhos
            {
                Descricao = "APLICATIVO MOBILE SEMANA TECNOLOGIA",
                DataApresentacao = new DateTime(),
                Ativo = true,
                Tema = "SEMANA TECNOLOGIA (JAVASCRIPT)"
            };
            trab.Insert(t);

            var list = trab.Find(new QueryDocument("Descricao", "APLICATIVO MOBILE SEMANA TECNOLOGIA"));

            return null;
        }

    }
}