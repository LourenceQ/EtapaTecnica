/*
2. Crie uma Classe Pessoa, contendo os atributos (nome, endereço e telefone)
encapsulados, com seus respectivos seletores (getters) e modificadores (setters), e
ainda o construtor padrão. Por fim, criar uma classe principal que instancie o objeto
Pessoa, adicione no mínimo um valor para cada atributo e imprima na tela.
*/
using System;
using Desafio2.src.Entity;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaEntity pessoa = new PessoaEntity(
                "Lourence Queirz Fófano"
                , "Brasil"
                , "Minas Gerais"
                , "Cataguases "
                , "Horto Florestal"
                , "Ana Maria Mendonça"
                , "Casa"
                , 58
                , "3432 3270");
            
            System.Console.WriteLine(pessoa);
        }
    }
}
