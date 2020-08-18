using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string CPF {//se eu quiser tbm posso escrever assim
            get 
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            } 
        }
        public string Profissao { get; set; }
    }
}
