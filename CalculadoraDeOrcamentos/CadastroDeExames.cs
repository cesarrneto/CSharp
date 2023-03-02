using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exames
{
    public abstract class CadastroExames
    {
        public string? NomeExame { get; set; }
        public double Valor { get; set; }

        public abstract double Valores();
    }

    
}
