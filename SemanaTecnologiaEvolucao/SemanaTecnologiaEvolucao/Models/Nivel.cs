using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SemanaTecnologiaEvolucao.Models
{
    public class Nivel
    {
        public ObjectId Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}