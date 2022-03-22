using System;

namespace Desafio3.src.Entity
{
    public class ContaPoupancaEntity : ContaEntity
    {    
        public override decimal Rendimento(decimal Saldo)
        {
            decimal n = 0.05M;
            decimal res = Decimal.Multiply(Saldo, n);
            return res;
        }
    }
    
}