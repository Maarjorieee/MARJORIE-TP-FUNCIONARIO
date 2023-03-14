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

        public double PercentualDoIR{ get; private set; }


    public void CalculoSalarioBase()
        {
            SalarioBase = ValorDiaria * DiasTrabalhados;
            CalculoDoIR();
            CalculoSalarioLiquido();
        }


         
        private void CalculoDoIR()
        {

            if (SalarioBase <= 1903.98){
                PercentualDoIR = SalarioBase * 0 / 100;
            }

            else if (SalarioBase <= 2826.65)
            {
                PercentualDoIR = SalarioBase * 7.50 / 100;
            }

            else if (SalarioBase <= 3751.05)
            {
                PercentualDoIR = SalarioBase *15/100;
            }

            else
            {
                PercentualDoIR = SalarioBase * 22.50 / 100;
            }

           


        }

       private void CalculoSalarioLiquido()
        {
            SalarioLiquido = SalarioBase - PercentualDoIR;
        }
    }
}
