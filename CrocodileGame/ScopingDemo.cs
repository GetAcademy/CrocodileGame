namespace CrocodileGame
{
    internal class ScopingDemo
    {
        /*
         * Parametre => verdier vi sender inn i en funksjon
         * Returverdi => verdier vi får tilbake fra en funksjon
         * Klassevariabler
         * Objektvariabler
         */
        public static int Dummy(int b)
        {
            int a;
            {
                {
                    {
                        {
                            {
                                a = 5;
                            }
                            a++;
                        }
                        a++;
                    }
                    a++;
                }
                a++;
            }
            a++;

            return 7;
        }
    }
}
