namespace Desafio3.src.Entity
{
    public abstract class ContaEntity
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        

        public abstract decimal Rendimento(decimal Saldo);

    }
    
}