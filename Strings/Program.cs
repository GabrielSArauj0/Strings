namespace Strings;

internal class Program
{
    public static void Main(string[] args)
    {
        var texto = "Este texto é um teste";

        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Insert(5, "aqui"));


        /*
    Console.WriteLine(texto.IndexOf("é"));
    Console.WriteLine(texto.LastIndexOf("é"));


    /*
    Console.WriteLine(texto.Equals("Este texto é um teste"));
    Console.WriteLine(texto.Equals("Abublebuble buble"));
    Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));


    /*
    Console.WriteLine(texto.StartsWith("Este"));
    Console.WriteLine(texto.StartsWith("este"));
    Console.WriteLine(texto.StartsWith("texto"));

    Console.WriteLine(texto.EndsWith("Teste"));
    Console.WriteLine(texto.EndsWith("xp"));
    Console.WriteLine(texto.EndsWith("teste"));


    /*
    Console.WriteLine(texto.Contains("Teste"));
    Console.WriteLine(texto.Contains("teste"));
    Console.WriteLine(texto.Contains("xpro",StringComparison.OrdinalIgnoreCase));

    */
    }
}