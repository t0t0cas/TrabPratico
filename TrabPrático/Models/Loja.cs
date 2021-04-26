using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Loja
    {
        public Loja()
        {
            // inicializar a lista de Jogos
            Jogos = new HashSet<JogosLoja>();
        }
        /// <summary>
        /// Id da Loja
        /// </summary>
        [Key] //identifca este atributo como PK
        public int IdLoja { get; set; }

        /// <summary>
        /// Nome da Loja
        /// </summary>
        public string NomeLoja { get; set; }

        /// <summary>
        /// Fotografia da Loja
        /// </summary>
        public string ImagemLoja { get; set; }
        
      
        //-------------------------------------
        /// <summary>
        /// lista dos Jogos ligados a Loja
        /// </summary>
        public ICollection<JogosLoja> Jogos { get; set; }
    }
}
