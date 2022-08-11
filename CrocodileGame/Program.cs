namespace CrocodileGame
{
    internal class Program
    {
        /*
            For hver runde skal det printes ut til skjermen et random tall mellom 1-11
            et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det 
            ser sånn ut: 3 _ 5

            Brukeren kan skrive inn <, > eller =

            i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

            Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
            Det må verifiseres om brukeren har valgt riktig alternativ.
            Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
            Poengsummen printes til skjermen for hvert svar brukeren har gitt.
            Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene         
         */
        static void Main(string[] args)
        {
            var random = new Random();
            var points = 0;
            while (true)
            {
                var number1 = random.Next(1, 11);
                var number2 = random.Next(1, 11);
                Console.WriteLine($"{number1} _ {number2}");
                var key = Console.ReadKey(true);
                var usersChar = key.KeyChar;
                var isGameChar = usersChar is '<' or '>' or '=';
                if (!isGameChar) return;
                var correctChar = GetCorrectChar(number1, number2);

                if (correctChar == usersChar)
                {
                    Console.WriteLine("Riktig!");
                    points++;
                }
                else
                {
                    Console.WriteLine("Feil!");
                    points--;
                }
                Console.WriteLine($"Du har {points} poeng.");

            }
        }

        private static char GetCorrectChar(int number1, int number2)
        {
            if (number1 == number2) return '=';
            if (number1 > number2) return '>';
            return '<';
        }
    }
}