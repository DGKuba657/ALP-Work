namespace Spoj_Textu {
    public static class Program {
        public static void Main() {
            bool running = true;
            while (running)
            {
                Console.WriteLine("What do you want to run? 1 = Spojovac Textu  2 = absolutni hodnota 3 = scitani 4 = Delka stringu");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Spoj.SpojovacTextu();
                        break;
                    case "2":
                        Spoj.Absolute();
                        break;
                    case "3":
                        Spoj.Scitac();
                        break;
                    case "4":
                        Spoj.TextLength();
                        break;
                }
                Thread.Sleep(1500);
                Console.WriteLine("Do you want to continue? (y/n)");
                string input = Console.ReadLine();

                if (input.ToLower() == "no" || input.ToLower() == "n")
                {
                    running = false;
                }
                Console.Clear();
            }
            
            
        }
    }
}





