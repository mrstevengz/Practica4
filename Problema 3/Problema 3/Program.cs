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

}
