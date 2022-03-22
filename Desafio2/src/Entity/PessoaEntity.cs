namespace Desafio2.src.Entity
{
    public class PessoaEntity
    {
        public PessoaEntity(string nome, string pais, string estado, string cidade, string bairro, string rua, string complemento, int numero, string telefone)
        {
            Nome = nome;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Complemento = complemento;
            Numero = numero;
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string Pais { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string Complemento { get; private set; }
        public int Numero { get; private set; }
        public string Telefone { get; private set; }

        public override string ToString()
        {
            return ($"Nome: {this.Nome} \n" 
                + $"Endereço: {this.Pais}\n" 
                + $"Telefone: {this.Estado}\n"
                + $"Telefone: {this.Cidade}\n"
                + $"Telefone: {this.Bairro}\n"
                + $"Telefone: {this.Rua}\n"
                + $"Telefone: {this.Complemento}\n"
                + $"Telefone: {this.Numero}\n"
                + $"Telefone: {this.Telefone}\n");
        }
    }
}