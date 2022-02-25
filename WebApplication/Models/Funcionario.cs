using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.Enum;

namespace WebApplication.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string NomeFuncionario { get; set; }
        public Cargo CargoFuncionario { get; set; }
        public float SalarioFuncionario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
