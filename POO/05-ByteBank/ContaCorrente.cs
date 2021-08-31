namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldo = 100;



        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}






