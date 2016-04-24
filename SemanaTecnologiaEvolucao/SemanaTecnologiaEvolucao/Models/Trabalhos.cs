using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SemanaTecnologiaEvolucao.Models
{
    public class Trabalhos
    {
        public ObjectId Id { get; set; }
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public DateTime DataApresentacao { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Usuario> Integrantes { get; set; }
    }
}