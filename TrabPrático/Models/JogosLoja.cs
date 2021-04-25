using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class JogosLoja
    {
        /// <summary>
        /// PK para a tabela de relacionamento entre Cães e Criadores
        /// </summary>
        [Key]
        public int Id { get; set; }

        /***********************************/
        /// <summary>
        /// FK para a Loja 
        /// </summary>
        [ForeignKey(nameof(Loja))]
        public int LojaFK { get; set; }
        public Loja Loja { get; set; }

        /// <summary>
        /// FK para os Jogos
        /// </summary>
        [ForeignKey(nameof(Jogos))]
        public int JogosFK { get; set; }
        public Jogos Jogos { get; set; }
    }
}
