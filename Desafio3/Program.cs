/*
3. Considerando os conceitos de Orientação a Objetos, 
crie uma classe abstrata Pai de nome Conta com os seguintes atributos
(número, titular e saldo) e mais duas classes

Filhas (ContaCorrente e ContaPoupanca). Na classe Conta deve existir um método
de nome rendimento que retorna o rendimento mensal da conta, nas classes filhas
deve existir o mesmo método rendimento, porém com as seguintes regras:
⦁ Para ContaCorrente, o método rendimento deve retornar o saldo * 0.03;
⦁ Para ContaPoupanca, o método rendimento deve retornar o saldo * 0.05;

Por fim, criar uma classe principal que instancie objetos de ContaCorrente e
ContaPoupanca, adicione no mínimo um valor para cada atributo e imprima cada
conta (ContaCorrente e ContaPoupanca) com seus devidos rendimentos.
Obs: Encapsular atributos das classes.

4. Aproveitando o seu código já escrito na questão 3, crie uma interface chamada
Imposto que contenha o método calcularImposto() e implemente ela em
ContaCorrente e ContaPoupanca com a seguinte regra:
⦁ Para ContaCorrente, o método calcularImposto() deve retornar o rendimento * 25%;
⦁ Para ContaPoupanca, o método calcularImposto() deve retornar o rendimento *
10%;

*/

using System;
using Desafio3.src.Entity;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupancaEntity contaC = new ContaPoupancaEntity();
            ContaCorrenteEntity contaP = new ContaCorrenteEntity();

            contaC.Saldo = 1600.70M;
            contaP.Saldo = 1900.70M;           

            var RendimentoCC = contaC.Rendimento(contaC.Saldo);
            var RendimentoCP = contaP.Rendimento(contaP.Saldo);

            var impostoCC = contaC.CalcularImposto(RendimentoCC);
            var impostoCP = contaP.CalcularImposto(RendimentoCP);

            System.Console.WriteLine("O rendimento mensal da conta corrente é R$: " + decimal.Round(RendimentoCC, 2, MidpointRounding.AwayFromZero));
            System.Console.WriteLine("O rendimento mensal da conta poupança é R$: " + decimal.Round(RendimentoCP, 2, MidpointRounding.AwayFromZero));

            System.Console.WriteLine("O importo da conta corrente é R$: " + decimal.Round(impostoCC, 2, MidpointRounding.AwayFromZero));
            System.Console.WriteLine("O imposto conta poupança é R$: " + decimal.Round(impostoCP, 2, MidpointRounding.AwayFromZero));
        }
    }
}
