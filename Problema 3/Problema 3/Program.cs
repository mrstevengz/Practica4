using System;

class Traductor
{
    static void Main()
    {
        List<Tuple<string, string>> diccionario = CrearDiccionario();
        Traducir(diccionario);
        Console.ReadKey();
    }

    public static List<Tuple<string, string>> CrearDiccionario()
    {
        List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();//Inicializacion de la lista para almacenar las parejas de palabras
        Console.WriteLine("Introduce las parejas de palabras (Ingles/Español): ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingles: ");
            string palabra1 = Console.ReadLine();
            Console.Write("Español: ");
            string palabra2 = Console.ReadLine();
            diccionario.Add(new Tuple<string, string>(palabra1, palabra2));
        }
        return diccionario;
    }

    static void Traducir(List<Tuple<string, string>> diccionario)
    {
        Console.WriteLine("Introduce la palabra a traducir: ");
        string palcomp = Console.ReadLine();
        bool encontrado = false;

        foreach (var duo in diccionario)
        {
            if (duo.Item1.Equals(palcomp, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Traduccion: " + duo.Item2);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("No se encontro la palabra en el diccionario.");

    }
}
