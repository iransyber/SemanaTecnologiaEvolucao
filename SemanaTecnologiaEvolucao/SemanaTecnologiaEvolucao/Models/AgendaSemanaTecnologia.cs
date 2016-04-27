using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using SemanaTecnologiaEvolucao.Controllers;
using SemanaTecnologiaEvolucao.Interfaces;
using System.Data.Entity;
using MongoDB.Driver.Builders;
using WebGrease.Css.Extensions;
using FluentAssertions;

namespace SemanaTecnologiaEvolucao.Models
{
    public class AgendaSemanaTecnologia: BaseController, ITrabalhos
    {

        public List<Trabalhos> ListarApresentacoesAssync()
        {
            var quer = Query.EQ("Descricao", "APLICATIVO MOBILE SEMANA TECNOLOGIA");
            var trab = database.GetCollection<Trabalhos>("Trabalhos");
            var r = trab.Find(quer);

            return r.ToList();
        }

        public List<Trabalhos> FiltrarTrabalhos(string param)
        {
            var quer = Query.Matches("Descricao", param);
            var trab = database.GetCollection<Trabalhos>("Trabalhos");
            var r = trab.Find(quer);

            return r.ToList();
        }

    }
}

//var quer = Query.EQ("Descricao", "APLICATIVO MOBILE SEMANA TECNOLOGIA");

//var t = new Trabalhos
//{
//    Descricao = "APLICATIVO MOBILE SEMANA TECNOLOGIA TESTE3",
//    DataApresentacao = new DateTime(),
//    Ativo = true,
//    Tema = "SEMANA TECNOLOGIA (JAVASCRIPT)",

//};

//trab.Insert(t.ToBsonDocument());

//var list =  trab.Find(new ));

//foreach (var l in list)
//{
//    var ll = new Trabalhos
//    {
//        Descricao = l.
//    }
//}