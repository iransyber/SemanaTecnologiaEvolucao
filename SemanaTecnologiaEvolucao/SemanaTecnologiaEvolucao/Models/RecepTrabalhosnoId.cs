using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace SemanaTecnologiaEvolucao.Models
{
    public class RecepTrabalhosnoId : IMongoUpdate
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Tema { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DataApresentacao { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool Ativo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Usuario> Integrantes { get; set; }
    }
}