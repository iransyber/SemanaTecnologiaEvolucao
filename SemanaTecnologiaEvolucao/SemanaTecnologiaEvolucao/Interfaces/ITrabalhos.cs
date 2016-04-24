using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace SemanaTecnologiaEvolucao.Interfaces
{
    public interface ITrabalhos
    {
        MongoCollection ListarApresentacoes();
    }
}