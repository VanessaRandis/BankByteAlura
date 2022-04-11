using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBank
{
    public class ContaCorrente
    {


        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {

            if (this.saldo < valor)

            {
                Console.WriteLine("Infelizmente saldo insuficiente");
                return false;
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine("Tranferencia realizada com sucesso");

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

                Console.WriteLine("Saldo insuficiente ");

                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Tranferência realizada com sucesso");
                return true;

            }
        }
    }

}
