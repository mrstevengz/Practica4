using System;

class Traductor
{
    static void Main()
    {
        List<(string, string)> diccionario = CrearDiccionario();
        Traducir(diccionario);
    }

    static List<(string, string)> CrearDiccionario()
    {
        List<(string, string)> diccionario = new List<(string, string)>();//Inicializacion de la lista para almacenar las parejas de palabras
        Console.WriteLine("Introduce las parejas de palabras (Ingles/Español): ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingles: ");
            string ingles = Console.ReadLine();
            Console.Write("Español: ");
            string espanol = Console.ReadLine();
            diccionario.Add((ingles, espanol));
        }
        return diccionario;
    }

    static void Traducir(List<(string, string)> diccionario)
    {
        while (true)
        {
            Console.WriteLine("Bienvenido al modo de traduccion. \nIntroduce una palabra en ingles para traducir (o escribe salir para terminar): ");
            string palabra = Console.ReadLine();

            if (palabra == "salir") //Verificacion para permitir al usuario salir del programa
            {
                break;
            }

            string traduccion = null;
            foreach (var par in diccionario) //Buscar la traduccion en el diccionario
            {
                if (par.Item1 == palabra)
                {
                    traduccion = par.Item2;
                    break;
                }
            }

            if (traduccion != null) //Verificacion para mostrar la traduccion si se encuentra, o mandar un error
            {
                Console.WriteLine($"La traducción de '{palabra}' es '{traduccion}'.");
            }
            else
            {
                Console.WriteLine("La palabra no se encuentra en el diccionario.");
            }
        }
    }
}
