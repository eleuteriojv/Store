using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCompleto { get; set; }
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Sexo { get; set; }
        public string? User { get; set; }
    }
}
