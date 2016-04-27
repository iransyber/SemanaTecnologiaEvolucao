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
        //Lembra de tornar a getcollection publica nesta linha ; var trab = database.GetCollection<Trabalhos>("Trabalhos");
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
        
        public Trabalhos Inserir(Trabalhos trabalho)
        {
            var trab = database.GetCollection<Trabalhos>("Trabalhos");
            var t = new Trabalhos
            {
                Descricao = trabalho.Descricao.ToUPPER(),
                DataApresentacao = new trabalho.DataApresentacao,
                Ativo = trabalho.Ativo,
                Tema = trabalho.Tema
            };
            
            trab.Insert(t.ToBsonDocument());
            
            var quer = Query.Matches("Descricao", t.Descricao);
            var r    = trab.Find(quer);
            
            return r;
        }
    }
}
