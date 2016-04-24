using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SemanaTecnologiaEvolucao.Models
{
    public class Usuario
    {
        public ObjectId Id { get; set; }
        public string CodigoFaculdade { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public ObjectId Nivel { get; set; }
    }
}