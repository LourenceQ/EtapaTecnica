using System;

namespace Desafio3.src.Entity
{
    public class ContaCorrenteEntity : ContaEntity
    {    
        public override decimal Rendimento(decimal Saldo)
        {
            decimal n = 0.03M;
            decimal res = Decimal.Multiply(Saldo, n);
            return res;
        }
    }
}