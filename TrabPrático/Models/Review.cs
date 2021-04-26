﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Review
    {
        /// <summary>
        /// Id da review
        /// </summary>
        [Key]
        public int IdReview { get; set; }

        /// <summary>
        /// Nota da Review que o utilizador dará
        /// </summary>
        [Required]
        public double NotaReview { get; set; }

        /// <summary>
        /// Comentário que o utilizador dará ao jogo
        /// </summary>
        [Required]
        public string Comentário { get; set; }

        //****************************************

        /// <summary>
        /// FK para o Utilizador que fez o Review
        /// </summary>        
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizador Utilizador { get; set; }

        /// <summary>
        /// FK para os Jogos
        /// </summary>
        [ForeignKey(nameof(Jogos))]
        public int JogoFK { get; set; }
        public Utilizador Jogos { get; set; }
    }
}
