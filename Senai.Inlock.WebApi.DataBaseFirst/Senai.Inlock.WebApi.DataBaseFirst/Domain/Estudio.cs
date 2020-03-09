﻿using System;
using System.Collections.Generic;

namespace Senai.Inlock.WebApi.DataBaseFirst.Domain
{
    public partial class Estudio
    {
        public Estudio()
        {
            Jogo = new HashSet<Jogo>();
        }

        public int IdEstudio { get; set; }
        public string NomeEstudio { get; set; }

        public ICollection<Jogo> Jogo { get; set; }

        
}
}
