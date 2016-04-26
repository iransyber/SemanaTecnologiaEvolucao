using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using MongoDB.Driver;
using Newtonsoft.Json;
using SemanaTecnologiaEvolucao.Models;

namespace SemanaTecnologiaEvolucao.Controllers
{
    [RoutePrefix("Api")]
    public class RequisicoesController : ApiController
    {
        private Interfaces.ITrabalhos interfa;

        public RequisicoesController()
        {
            interfa = new AgendaSemanaTecnologia();
        }

        [Route("Listar")]
        [HttpGet]
        public JsonResult<string> Listar()
        {
            var resultado = interfa.ListarApresentacoes().ToString();
            return Json(resultado,new JsonSerializerSettings());
        }
    }
}
