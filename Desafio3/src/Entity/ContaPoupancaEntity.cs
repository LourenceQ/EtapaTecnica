using System;
using Desafio3.src.Interface;

namespace Desafio3.src.Entity
{
    public class ContaPoupancaEntity : ContaEntity, IImposto
    {
        public decimal CalcularImposto(decimal rendimento)
        {
            decimal imposto = 25/100;
            decimal res = Decimal.Multiply(imposto, rendimento);
            return res;
        }

        public override decimal Rendimento(decimal Saldo)
        {
            decimal n = 0.05M;
            decimal res = Decimal.Multiply(Saldo, n);
            return res;
        }
    }
    
}