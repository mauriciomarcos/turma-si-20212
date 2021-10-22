using OOP.Classes;
using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {

        static void Main()
        {
            Cliente mauricio = new Cliente("Maurício", "321.588.987-99", "Rua Bento de Abreu, 527");

            //var contaMauricio = new ContaCorrente(101010, 1000, mauricio);
            //var contaAnthony = new ContaPoupanca(550055, 5000, new Cliente("Anthony", "556.998", "Rua da República, 1020"));

            //contaMauricio.Depositar(1000);
            //contaAnthony.Sacar(2500);

            //Console.WriteLine($"O saldo do cliente {contaMauricio.Cliente.Nome} é: {contaMauricio.Saldo}");
            //Console.WriteLine($"O saldo do cliente {contaAnthony.Cliente.Nome} é: {contaAnthony.Saldo}");

            //contaMauricio.Transferir(75, contaAnthony);

            //Console.WriteLine($"O saldo do cliente {contaMauricio.Cliente.Nome} é: {contaMauricio.Saldo}");
            //Console.WriteLine($"O saldo do cliente {contaAnthony.Cliente.Nome} é: {contaAnthony.Saldo}");

            //Console.WriteLine($"{contaMauricio.MensagemOperacao}");
            //Console.WriteLine($"{contaAnthony.MensagemOperacao}");


            //Conta poupanca = new ContaPoupanca(101010, 1000, mauricio);
            //poupanca.Depositar(500);
            //poupanca.Sacar(100);


            //Console.WriteLine($"{poupanca.MensagemOperacao}");
            //Console.WriteLine($"O saldo da poupança do {poupanca.Cliente.Nome} é: {poupanca.Saldo}");

            //var contaCorrente = new ContaCorrente(1111111, 1850, mauricio);
            //var contaPoupanca = new ContaPoupanca(2222222, 5000, mauricio);
            //var contaInvestimento = new Investimento();

            //List<IInvestimento> contasComInvestimento = new List<IInvestimento>();
            //contasComInvestimento.Add(contaCorrente);
            //contasComInvestimento.Add(contaPoupanca);
            //contasComInvestimento.Add(contaInvestimento);

            //contaCorrente.Transferir(1000, contaPoupanca);

            //foreach (var conta in contasComInvestimento)
            //{
            //    Console.WriteLine(conta.Investir(99999));
            //}


            Func<int, int, string> Somar = (n1, n2) =>
            {
                var soma = n1 + n2;
                return $"Resultado soma = {soma}";
            };

            Func<int, int, string> Subtrair = (n1, n2) =>
            {
                var sub = n1 - n2;
                return $"Resultado subtração = {sub}";
            };

            Func<int, int, string> Dividir = (n1, n2) =>
            {
                var div = n1 / n2;
                return $"Resultado divisão = {div}";
            };

            Func<int, int, string> Multiplicar = (n1, n2) =>
            {
                var mult = n1 * n2;
                return $"Resultado multiplicação = {mult}";
            };

            //MaquinaCalcular(Multiplicar, 10, 5);
            //MaquinaCalcular(Dividir, 10, 5);
            //MaquinaCalcular(Somar, 10, 5);
            //MaquinaCalcular(Subtrair, 10, 5);

            var funcoesDeCalculo = new List<Func<int, int, string>>();
            funcoesDeCalculo.Add(Multiplicar);
            funcoesDeCalculo.Add(Somar);
            funcoesDeCalculo.Add(Subtrair);
            funcoesDeCalculo.Add(Dividir);

            Console.WriteLine("INICIOU A EXECUÇÃO");
            
            var val1 = int.Parse(Console.ReadLine());
            var val2 = int.Parse(Console.ReadLine());

            MaquinaCalcular(funcoesDeCalculo, val1, val2);
        }

        public static void MaquinaCalcular(List<Func<int, int, string>> listaCompletaDeFuncoes, int n1, int n2)
        {
            foreach (var apenasUmaFuncao in listaCompletaDeFuncoes)
            {
                Console.WriteLine(apenasUmaFuncao(n1, n2));
            }
        }
    }
}