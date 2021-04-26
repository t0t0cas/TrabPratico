using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Utilizador
    {
        /// <summary>
        /// Id do utilizador 
        /// </summary>
        [Key]
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Email do Utilizador
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Email { get; set; }

        /// <summary>
        /// Password do utilizador
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(12, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Pass { get; set; }


    }
}
