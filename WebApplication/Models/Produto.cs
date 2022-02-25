using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeProduto { get; set; }
        [DisplayName("Data de Entrada")]
        public DateTime DataEntrada { get; set; }
        [DisplayName("Data de Saída")]
        public DateTime DataSaida { get; set; }
        [DisplayName("Preço")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public float Preco { get; set; }

    }
}
