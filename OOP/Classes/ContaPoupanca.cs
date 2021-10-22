using OOP.Interfaces;

namespace OOP.Classes
{
    public class ContaPoupanca : Conta, IInvestimento
    {
        public ContaPoupanca(int numero, decimal saldoAbertura, Cliente cliente)
            : base(numero, saldoAbertura, cliente)
        { }

        public override bool Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                MensagemOperacao = $"Saque bloqueado. Saldo insuficiente: Saldo atual {Saldo}";
                return false;
            }

            Saldo -= valor - 0.1m;
            return true;
        }

        public override bool Depositar(decimal valor)
        {
            if (valor < 0)
            {
                MensagemOperacao = $"Depósito inválido. Transação não realizada. Valor do depósito {valor}";
                return false;
            }

            Saldo += valor + 0.5m;
            return true;
        }

        public string Investir(decimal valorInvestimento) => "Investimento realizado pela poupança";
    }
}