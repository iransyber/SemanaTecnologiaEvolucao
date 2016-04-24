using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SemanaTecnologiaEvolucao.Models
{
    public class Nota
    {
        public ObjectId Id { get; set; }
        public ObjectId UsuarioId { get; set; }
        public ObjectId TrabalhoId { get; set; }
        public decimal NotaInformada { get; set; }
    }
}