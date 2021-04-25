using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Loja
    {
        /// <summary>
        /// Id da Loja
        /// </summary>
        [Key] //identifca este atributo como PK
        public int IdLoja { get; set; }

        /// <summary>
        /// Links das lojas
        /// </summary>
        public string Links { get; set;}
    }
}
