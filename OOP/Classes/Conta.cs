namespace OOP.Classes
{
    public abstract class Conta
    {
        protected decimal saldo;

        public Conta(int numero, decimal saldoAberturaConta, Cliente cliente)
        {
            Numero = numero;            
            Saldo = saldoAberturaConta;
            Cliente = cliente;
        }

        public int Numero { get; private set; }
       
        public string MensagemOperacao { get; protected set; }

        public Cliente Cliente { get; protected set; }

        public decimal Saldo 
        {
            get { return saldo; }
            protected set
            {
                if (value >= 0)                
                    saldo = value;                
                else
                    saldo = 0;                                    
            } 
        }

        public abstract bool Sacar(decimal valor);

        public abstract bool Depositar(decimal valor);
        
        public void Transferir(decimal valor, Conta destino)
        {           
            var sucessoNaTransacaoDeSaque = Sacar(valor);
            var sucessoNaTransacaoDeDeposito = destino.Depositar(valor);             
            
            if (sucessoNaTransacaoDeSaque && sucessoNaTransacaoDeDeposito)
                MensagemOperacao = $"Transferência realizada com sucesso. \n" +
                    $"De: {Cliente.Nome} Para: {destino.Cliente.Nome} \n" +
                    $"Valor da Transação: {valor}";
        }
    }
}