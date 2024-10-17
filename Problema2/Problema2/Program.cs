using System;

namespace Problema2
{
    class CuentaBancaria
    {
        static void Main(string[] args)
        {
            List <decimal> balance = new List<decimal> { 0.0m };
            int op;
            Console.WriteLine("Bienvenido a su cuenta bancaria");
            Console.WriteLine("--------------------------------");
            do
            {
                Console.WriteLine("\n1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar saldo");
                Console.WriteLine("4. Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: ConsultarSaldo(balance); break;
                    case 2: DepositarDinero(balance); break;
                    case 3: RetirarSaldo(balance); break;
                    case 4: Console.WriteLine("Gracias por usar nuestros servicios bancarios"); break;
                    default: Console.WriteLine("Opción no válida"); break;
                }
            } while (op != 4);
        }

        static void ConsultarSaldo(List<decimal> balance)
        {
            Console.WriteLine("Su saldo actual es de: " + balance[0]);
        }

        static void DepositarDinero(List<decimal> balance)
        {
            decimal deposito;
            Console.WriteLine("Ingrese la cantidad a depositar: ");
            deposito = decimal.Parse(Console.ReadLine());
            decimal nuevoSaldo = balance.Last() + deposito;
            balance.Add(nuevoSaldo);
            Console.WriteLine("Depósito realizado con éxito. Su nuevo saldo es de: {0}", nuevoSaldo);

        }

        static void RetirarSaldo(List<decimal> balance)
        {
            decimal retiro;
            Console.WriteLine("Ingrese la cantidad a retirar: ");
            retiro = decimal.Parse(Console.ReadLine());
            if (retiro > balance.Last())
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                decimal nuevoSaldo = balance.Last() - retiro;
                balance.Add(nuevoSaldo);
                Console.WriteLine("Retiro realizado con éxito. Su nuevo saldo es de: {0}", nuevoSaldo);
            }
        }

    }
}