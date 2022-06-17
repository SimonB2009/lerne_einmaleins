using System; 



namespace simon { 

    
    

    class Konsolenraser
    {

        static void Main(string[] args) {

            int a, b, erg;
            char c = 'q';

            Random r = new Random(); 

            while (c != 'b') {

                if (Console.KeyAvailable == true)
                {
                    c = Console.ReadKey(true).KeyChar;

                }
                

                a = r.Next(0, 11);
                b = r.Next(0, 11);
                erg = a * b;

                Console.Write("     " + a + " * " + b + " = ");

                if (Console.ReadLine() == erg.ToString()) {

                    Console.WriteLine("     Richtig!");
                } else {

                    Console.WriteLine("     Falsch!");
                }
            }
        }
    

    }
}
