using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente GustavoConta = new ContaCorrente();
            GustavoConta.titular = new Cliente();
            GustavoConta.titular.nome = "Gustavo Veiga";

           

            Console.WriteLine("Insira o valor que gostaria de sacar");
            GustavoConta.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Saldo atual conta Gustavo : " + GustavoConta.saldo);

            Console.WriteLine("Insira o valor que gostaria de depositar: ");
            GustavoConta.Depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Titular " + GustavoConta.titular.nome);

            Console.WriteLine("Saldo atual conta Gustavo :" + GustavoConta.saldo);


            


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = new Cliente();

            contaDaGabriela.titular.nome="Gabriela Santos";

            Console.WriteLine("Saldo conta Gustavo " + GustavoConta.saldo);
            Console.WriteLine("Saldo conta da Gabriela " + contaDaGabriela.saldo);

            GustavoConta.transferir(200.00, contaDaGabriela);

            Console.WriteLine("Saldo atualizado das contas após transferência:");

            Console.WriteLine("Saldo conta Gustavo " + GustavoConta.saldo);
            Console.WriteLine("Saldo conta da Gabriela " + contaDaGabriela.saldo);

            Console.WriteLine("Ao finalizar a execução tecle ENTER");
            Console.ReadLine();
        }


    }
}

