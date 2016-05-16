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
    //[Authorize]
    [RoutePrefix("Api/trabalhos")]
    public class RequisicoesController : ApiController
    {
        private Interfaces.ITrabalhos interfa;

        public RequisicoesController()
        {
            interfa = new AgendaSemanaTecnologia();
        }

        [Route("Listar")]
        [HttpGet]
        public JsonResult<List<Trabalhos>> Listar()
        {
            var resultado = interfa.ListarApresentacoesAssync();
            return Json(resultado);
        }

        [Route("filtrar/{param:length(1,60)}")]
        [HttpGet]
        public JsonResult<List<Trabalhos>> FiltrarTrabalhos(string param)
        {
            var resultado = interfa.FiltrarTrabalhos(param);
            return Json(resultado);
        }

        [Route("info/{param:length(1,60)}")]
        [HttpGet]
        public JsonResult<List<Trabalhos>> InfoTrabalhos(string param)
        {
            var resultado = interfa.InfoTrabalhos(param);
            return Json(resultado);
        }

        [Route("incluir")]
        [HttpPost]
        public JsonResult<List<Trabalhos>> FiltrarTrabalhos([FromBody] Trabalhos trabalho)
        {
            var resultado = interfa.Inserir(trabalho);
            return Json(resultado);
        }

        [Route("editar")]
        [HttpPost]
        public void Editar([FromBody] RecepTrabalhos trabalho)
        {
            interfa.Alterar(trabalho);
        }

        [Route("excluir/{param:length(1,60)}")]
        [HttpPost]
        public void Excluir(string param)
        {
            interfa.Excluir(param);
        }
    }
}
