using System;
using System.IO.Pipes;

namespace Ejercicio1
{
    public struct Producto
    {
        public int Codigo;
        public string Nombre;
        public int Cantidad;
        public decimal Precio;

        public Producto(int codigo, string nombre, int cantidad, decimal precio) //Uso del constructor para inicializar un producto
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;

        }

        public class Programa
        {
            private static List<Producto> productos = new List<Producto>(); //Lista para almacenar productos

            public static void Main()
            {
                int op;
                do
                {
                    Console.WriteLine("\n------Bienvenido al sistema de inventario------"); //Menu del sistema de inventario
                    Console.WriteLine("Menu de opciones:");
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Eliminar producto");
                    Console.WriteLine("3. Modificar producto");
                    Console.WriteLine("4. Consultar producto");
                    Console.WriteLine("5. Mostrar todos los productos");
                    Console.WriteLine("6. Salir");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {

                    }
                }
            }
        }

    }
}
