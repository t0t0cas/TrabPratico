using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabPrático.Models
{
    public class Jogos
    {
        /// <summary>
        /// Id do jogo
        /// </summary>
        public int IdJogo { get; set; }

        /// <summary>
        /// Nome do jogo
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Categoria do jogo
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Média da avaliação dos utilizadores acerca do jogo
        /// </summary>
        public int Media { get; set; }

        /// <summary>
        /// Data de lançamento do jogo
        /// </summary>
        public DateTime DataLancamento { get; set; }

        /// <summary>
        /// Imagem do Jogo
        /// </summary>
        public string Imagem { get; set; }

        /// <summary>
        /// Descrição do Jogo
        /// </summary>
        public string Descricao { get; set; }
    }
}
