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
        List<(string, string)> diccionario = new List<(string, string)>();
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
        Console.WriteLine("Bienvenido al modo de traduccion. \nIntroduce una palabra en ingles para traducir: ");
        string palabra = Console.ReadLine();
        string traduccion = "No se ha encontrado la traduccion";
        foreach (var par in diccionario)
        {
            if (par.Item1 == palabra)
            {
                traduccion = par.Item2;
                break;
            }
        }
        Console.WriteLine("Traduccion: " + traduccion);
    }
}
