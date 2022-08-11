namespace CrocodileGame
{
    internal class MyConsole
    {
        //public static int starCount;

        /*
            //MyConsole.starCount = 100;
            MyConsole.WriteStringOnLinesWithStars("Terje");         
         */

        public static void WriteStringOnLinesWithStars(string text)
        {
            for (var index = 0; index < text.Length; index++)
            {
                var starCount = index + 1;
                var character = text[index];
                WriteCharacterWithStars(character, starCount);
            }
        }

        private static void WriteCharacterWithStars(char character, int starCount)
        {
            var stars = "".PadLeft(starCount, '*');
            Console.Write(stars);
            Console.Write(character);
            Console.WriteLine(stars);
        }

        static void DemoHidden()
        {
            Console.WriteLine("Hei, hva heter du? ");
            var name = HiddenReadLinn();
            Console.WriteLine($"Hei, {name}!");
        }

        static string HiddenReadLinn()
        {
            var input = "";
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) return input;
                input += key.KeyChar;
            }
        }
    }
}
