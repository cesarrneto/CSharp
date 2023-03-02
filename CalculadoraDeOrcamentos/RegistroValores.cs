using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exames;

namespace CalculadoraDeOrcamentos
{
    public class Registro : CadastroExames
    {
        private double _valordoorcamento;

        public override double Valores() => this.Valor;
        public void RegistrarValor(CadastroExames Exame)
        {
            _valordoorcamento += Exame.Valores();
        }

        public double TotalDoOrcamento()
        {
            return _valordoorcamento;
        }

        //var listaValores = new List<double> { 10, 10, 20 };
        
    }

}
