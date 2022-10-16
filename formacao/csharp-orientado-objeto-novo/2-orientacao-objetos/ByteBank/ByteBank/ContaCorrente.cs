using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private string conta;
        public string Conta 
        {
            get
            {
                return conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    conta = value;
                }
            }
        }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    numeroAgencia = value;
                }
            }
        }
        
        public string NomeAgencia { get; set; }

        private double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor || valor < 0)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor || valor < 0)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
        
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return; 
                }
                saldo = value;
            }
        }

        public ContaCorrente (int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;

            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }
    }
}