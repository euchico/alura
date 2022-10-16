namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente _titular;
        public int _numero;
        public double _saldo;

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia 
        {
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

                _agencia = value;
            } 
        }
        public int Numero { get; set; }

        public int agencia;
        public int numero;

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

                this._saldo = value;
            }
        }

        public void SetSaldo(double saldo)
        {
            if (_saldo < 0)
            {
                return;
            }

            this._saldo = saldo;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public ContaCorrente (int agencia, int numero)
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

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}

