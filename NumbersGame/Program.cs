namespace NumbersGame
{
    internal class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 21);
            int guesses = 0; // Här skapar vi en tom variabel för att använda till att räkna hur många gånger användaren har gissat
            bool isGuessNumber = true; // En boolean för att att kunna säga när while loopen ska avslutas.
            static void CheckGuess() // Metod för att skriva ut i konsolen om användaren gissade rätt.
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }

            while (isGuessNumber) 
            {
           
                int guessNumber = Convert.ToInt32(Console.ReadLine()); 
                
                if (guesses >= 5) // Om användaren gissar fel 5 gånger körs det här.
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    Console.WriteLine("Vill du försöka igen? (Y/N)");
                    string tryAgain = Console.ReadLine();
                    tryAgain = tryAgain.ToUpper(); /* Med ToUpper metoden innebär det att det inte spelar någon roll om användaren inmatar med liten eller stor bokstav.
                                                    Eftersom att all text blir till stor text och programmet körs vidare.*/
                    if (tryAgain == "Y")
                    {
                        /* Om användaren vill köra igen*/
                        isGuessNumber = true;
                        guesses = 0;
                        Console.Clear();
                    }

                    else if (tryAgain == "N")
                    {
                        isGuessNumber = false;
                    }
                }

                else if (guessNumber > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    guesses++;
                }

                else if (guessNumber < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    guesses++;
                }

                else
                {
                    CheckGuess();
                    isGuessNumber = false;
                }
                

            }
            Console.ReadKey();
        }
    }
}
