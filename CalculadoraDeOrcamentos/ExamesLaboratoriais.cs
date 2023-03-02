using Exames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeOrcamentos
{
    public class ExamesLaboratoriais : CadastroExames
    {
        public ExamesLaboratoriais() : base() { }

        public override double Valores() => this.Valor;
    }
}
