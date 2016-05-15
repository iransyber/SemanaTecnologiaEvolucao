using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using SemanaTecnologiaEvolucao.Models;

namespace SemanaTecnologiaEvolucao.Interfaces
{
    public interface ITrabalhos
    {
        List<Trabalhos> FiltrarTrabalhos(string param);
        List<Trabalhos> ListarApresentacoesAssync();
        List<Trabalhos> Inserir(Trabalhos trabalho);
        void Alterar(RecepTrabalhos trabalho);
        List<Trabalhos> InfoTrabalhos(string param);
    }
}
