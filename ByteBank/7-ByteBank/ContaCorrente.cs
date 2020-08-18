namespace _7_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia {
            get
            {
                return this._agencia;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                this._agencia = value;
            }

        }
        public int Numero { get; set; }

        //------------------------------------------------------------
        public Cliente Titular { get; set; }
        //OU------------------------------------------------

        /*private Cliente _titular;
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                this._titular = value;
            }
        }*/

        //------------------------------------------------------------
        private double _saldo = 100;
        //OU------------------------------------------------
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

        /*public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            
            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }*/

        public ContaCorrente(int Agencia, int Numero)
        {
            this.Agencia = Agencia;
            this.Numero = Numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}