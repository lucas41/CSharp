namespace _06___ByteBank
{
    public class ContaCorrente
    {


        public Cliente Titular {get; set;}
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }

        // atributos public podem ser declarados de qualquer parte do codigo
        // atributos private são acesseiveis apenas em suas classes 

        private double _saldo = 100;
       
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        // Para acessar variaveis private é necessario criar um metodo para elas (encapsulamento) 
       

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}






