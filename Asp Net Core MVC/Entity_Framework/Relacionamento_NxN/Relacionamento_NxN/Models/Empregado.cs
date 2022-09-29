using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacionamento_NxN.Models
{
    public class Empregado
    {
        public int EmpredoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        ICollection<EmpregadoTrabalho> EmpregadoTrabalhos { get; set; }
    }
}
