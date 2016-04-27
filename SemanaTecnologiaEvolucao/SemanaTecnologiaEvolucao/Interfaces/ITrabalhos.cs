using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Driver;
using SemanaTecnologiaEvolucao.Models;

namespace SemanaTecnologiaEvolucao.Interfaces
{
    public interface ITrabalhos
    {
        List<Trabalhos> FiltrarTrabalhos(string param);
        List<Trabalhos> ListarApresentacoesAssync();
    }
}