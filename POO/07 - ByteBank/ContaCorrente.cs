namespace _07___ByteBank
{
    public class ContaCorrente
    {


        public Cliente Titular {get; set;}


        public static int TotalDeContasCriadas { get; private set; }
        // é possivel bloquear apenas o set ou get


        // set = setar = atribuir valor
        // get = Pegar valor


        private int _agencia;
        public int Agencia {
            get
            {
                return _agencia;
            } 
            set
            {
                if(value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }
        
        public int Numero { get; set; }

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
       
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

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






