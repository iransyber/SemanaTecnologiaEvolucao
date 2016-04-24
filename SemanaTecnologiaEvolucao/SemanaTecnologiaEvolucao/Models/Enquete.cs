﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace SemanaTecnologiaEvolucao.Models
{
    public class Enquete
    {
        public ObjectId Id { get; set; }
        public string Descricao { get; set; }
        public int TrabalhoId { get; set; }
        public decimal Nota { get; set; }
    }
}