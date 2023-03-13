using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARJORIE_TP_FUNCIONARIO
{
    public class Funcionario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public double ValorDiaria { get; set; }

        public int DiasTrabalhados { get; set; }

        public double SalarioBase { get; private set; }

        public double DescontoDoIR { get; private set; }

        public double SalarioLiquido { get; private set; }

        public double PercentualDoIR{ get; set; }


    public void CalculoSalarioBase()
        {
            SalarioBase = ValorDiaria * DiasTrabalhados;
        }


         
        public void CalculoDoIR()
        {

            if (SalarioBase <= 1903.98){
                PercentualDoIR = 0;
            }

            else if (SalarioBase <= 2826.65)
            {
                PercentualDoIR = 7.50;
            }

            else if (SalarioBase <= 3751.05)
            {
                PercentualDoIR = 15;
            }

            else
            {
                PercentualDoIR = 22.50;
            }

           


        }

        public void CalculoSalarioLiquido()
        {
            SalarioLiquido = (SalarioBase * PercentualDoIR)/100;
        }
    }
}
