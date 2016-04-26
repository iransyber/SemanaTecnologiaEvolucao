using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using SemanaTecnologiaEvolucao.Models;

namespace SemanaTecnologiaEvolucao.Interfaces
{
    public interface ITrabalhos
    {
        IList<Trabalhos> ListarApresentacoes();
    }
}