namespace SpojovacTextu;

public class Spoj
{
    public static void SpojovacTextu()
    {
        Console.WriteLine("Napis svoji prvni cast textu");
        string string1 = Console.ReadLine();

        Console.WriteLine("Napis svoji druhou cast textu");
        string string2 = Console.ReadLine();


        string completion = string1 + string2;
        Console.WriteLine($"Tvuj text jest {completion}");
    }

    public static void Absolute()
    {
        Console.WriteLine("Napis cislo");
        float number1 = float.Parse(Console.ReadLine());
        float absolutni_hodnota = Math.Abs(number1);
        Console.WriteLine(absolutni_hodnota);
    }

    public static void Scitac()
    {
        Console.WriteLine("Napis cislo");
        float floatNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Napis druhe cislo");
        float floatNumber2 = float.Parse(Console.ReadLine());
        float result = floatNumber + floatNumber2;
        Console.WriteLine($"Tvuj vysledek je {result}");
    }

    public static void TextLength()
    {
        Console.WriteLine("Napis text");
        string text1 = Console.ReadLine();
        Console.WriteLine(text1.Length);
    }
}