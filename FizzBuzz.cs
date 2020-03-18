/* Dla liczb od 1 do 100:
- Jeśli liczba dzieli się przez 3 to wypisujesz do konsoli "Fizz"
- Jeśli liczba dzieli się przez 5 to wypisujesz "Buzz"
- Jeśli dzieli się przez 15 to wypisujesz "FizzBuzz"
- W przeciwnym przypadku wypisujesz liczbę
*/

using System;


namespace FizzBuzzTask
{
    class FizzBuzz
    {

        static public void Division(string i)
        {
            try
            {
                int number = Int32.Parse(i);

                if (number >= 1 && number <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (number % 15 == 0) // Jeśli liczba dzieli się przez 15 to wypisujesz do konsoli "FizzBuzz"
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("Buzz"); // Jeśli liczba dzieli się przez 5 to wypisujesz "Buzz"
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz"); // Jeśli liczba dzieli się przez 3 to wypisujesz do konsoli "Fizz"
                    }
                    else
                    {
                        Console.WriteLine(i); // Jeśli liczba nie niedziei się przez 3, 5 lub 15, wtedy wypisujesz liczbę
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podana liczba nie mieści się w zakresie");
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Nieprawidłowy format ");
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wpisz liczbę z zakresu od 1 do 100");
                Console.ResetColor();
                string number; // deklaracja zmiennej
                number = Console.ReadLine(); // pobranie tekstu wpisanego przez użytkownika
                Division(number);
                i++;
            }
            while (i < 500);

        }
    }
}
