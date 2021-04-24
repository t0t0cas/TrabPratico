using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Utilizador
    {
        /// <summary>
        /// Id do utilizador 
        /// </summary>
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email do Utilizador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password do utilizador
        /// </summary>
        public string Pass { get; set; }
    }
}
