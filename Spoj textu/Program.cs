
while (true)
{
    Console.WriteLine("Choose what you wanna use 1 = spojovac textu or 2 = absolutni hodnota 3 = soucet des cisel 4 = delka stringu");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case"1":
            Console.WriteLine("Napis svoji prvni cast textu");
            string string1 = Console.ReadLine();

            Console.WriteLine("Napis svoji druhou cast textu");
            string string2 = Console.ReadLine();


            string completion = string1 + string2;
            Console.WriteLine($"Tvuj text jest {completion}");
            break;
        case "2":
            Console.WriteLine("Napis cislo");
            float number1 = float.Parse(Console.ReadLine());
            float absolutni_hodnota = Math.Abs(number1);
            Console.WriteLine(absolutni_hodnota);
            break;
        case "3":
            Console.WriteLine("Napis cislo");
            float floatNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Napis druhe cislo");
            float floatNumber2 = float.Parse(Console.ReadLine());
            float result = floatNumber + floatNumber2;
            Console.WriteLine($"Tvuj vysledek je {result}");
            break;
        
        case "4":
        Console.WriteLine("Napis text");
            string text1 = Console.ReadLine();
            Console.WriteLine(text1.Length);      
            break;
        
        default: Console.WriteLine("Wrong input"); break;
    }
    Thread.Sleep(3000);
    Console.Clear();
    
}








