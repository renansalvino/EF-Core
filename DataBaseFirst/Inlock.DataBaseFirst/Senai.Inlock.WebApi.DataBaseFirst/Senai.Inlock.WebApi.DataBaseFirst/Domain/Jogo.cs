﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Inlock.WebApi.DataBaseFirst.Domain
{
    public partial class Jogo
    {
        public int IdJogo { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public string Valor { get; set; }
        public int? IdEstudio { get; set; }

        public Estudio IdEstudioNavigation { get; set; }

        [ForeignKey("Id")]
        public Estudio estudio { get; set; }
    }
}
