using System;
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
        public int NotaReview { get; set; }

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
