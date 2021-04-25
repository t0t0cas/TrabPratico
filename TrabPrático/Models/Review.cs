using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


    }
}
