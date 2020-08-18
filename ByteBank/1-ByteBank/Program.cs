using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("titular: " + contaDaGabriela.titular);
            Console.WriteLine("agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("numero: " + contaDaGabriela.numero);
            Console.WriteLine("saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("novo saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
