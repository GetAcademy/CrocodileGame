namespace CrocodileGame
{
    internal class Program2
    {
        static int points;
        static Random random;

        static void Main2(string[] args)
        {
            random = new Random();
            points = 0;
            while (RunOneTurn())
            {
            }
        }

        private static bool RunOneTurn()
        {
            var number1 = random.Next(1, 11);
            var number2 = random.Next(1, 11);
            Console.WriteLine($"{number1} _ {number2}");
            var key = Console.ReadKey(true);
            var usersChar = key.KeyChar;
            var isGameChar = usersChar is '<' or '>' or '=';
            if (!isGameChar) return false;
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
            return true;
        }

        private static char GetCorrectChar(int number1, int number2)
        {
            if (number1 == number2) return '=';
            if (number1 > number2) return '>';
            return '<';
        }
    }
}
