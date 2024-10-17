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
                Console.WriteLine("\n------Bienvenido al sistema de inventario------\n");

                do
                {
                    //Menu del sistema de inventario
                    Console.WriteLine("\nMenu de opciones:");
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Eliminar producto");
                    Console.WriteLine("3. Modificar producto");
                    Console.WriteLine("4. Consultar producto");
                    Console.WriteLine("5. Mostrar todos los productos");
                    Console.WriteLine("6. Salir");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1: AgregarProducto(); break;
                        case 2: EliminarProducto(); break;
                        case 3: ModificarProducto(); break;
                        case 4: ConsultarProducto(); break;
                        case 5: MostrarProductos(); break;
                        default: Console.WriteLine("Opcion no valida, escoga otra opcion"); break;
                    }
                } while (op != 6);
            }

            public static void AgregarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Producto producto = new Producto(codigo, nombre, cantidad, precio); //Creacion de un nuevo producto que se añada a la lista 
                productos.Add(producto);
            }

            public static void EliminarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a eliminar: ");
                int buscarcodigo = int.Parse(Console.ReadLine());
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Codigo == buscarcodigo)
                    {
                        productos.RemoveAt(i);
                        Console.WriteLine("Producto eliminado");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                }
            }

            public static void ModificarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a modificar: ");
                int buscarcodigo = int.Parse(Console.ReadLine());
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Codigo == buscarcodigo)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre del producto: ");
                        string nombreActualizado = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva cantidad del producto: ");
                        int cantidadActualizada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nuevo precio del producto: ");
                        decimal precioActualizado = decimal.Parse(Console.ReadLine());

                        Producto productoModificado = productos[i];
                        productoModificado.Nombre = nombreActualizado;
                        productoModificado.Cantidad = cantidadActualizada;
                        productoModificado.Precio = precioActualizado;

                        Console.WriteLine("Producto modificado");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                }
            }

            public static void ConsultarProducto()
            {
                Console.WriteLine("Ingrese el ID del producto a consultar: ");
                int buscarcodigo = int.Parse(Console.ReadLine());
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Codigo == buscarcodigo)
                    {
                        Console.WriteLine("ID: " + productos[i].Codigo);
                        Console.WriteLine("Nombre: " + productos[i].Nombre);
                        Console.WriteLine("Cantidad: " + productos[i].Cantidad);
                        Console.WriteLine("Precio: " + productos[i].Precio);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                }
            }

            public static void MostrarProductos()
            {
                Console.WriteLine("Productos en el inventario: ");
                foreach (Producto producto in productos)
                {
                    Console.WriteLine("ID: " + producto.Codigo);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Cantidad: " + producto.Cantidad);
                    Console.WriteLine("Precio: " + producto.Precio);
                }
            }
        }
    }
}
