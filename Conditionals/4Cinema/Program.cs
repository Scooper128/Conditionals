namespace _4Cinema
{
    internal class Program
    {
        static void ageCheck(int age, int rating)
        {
            if(age>=rating)
            {
                Console.WriteLine("Enjoy the film");
            }
            else
            {
                Console.WriteLine("y=You are not old enough to watch the film");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AMAZING Nicorama Cage-athon!");
            Console.WriteLine("A celebration of 30 years of Nic Cage.");

            Console.WriteLine("1. The Rock(1996)(15)");
            Console.WriteLine("2. Face / Off(1997)(18)");
            Console.WriteLine("3. The Wicker Man(2005) (12)");
            Console.WriteLine("4. The Croods(2012)(U)");

            Console.WriteLine("What film would you like to see?(1-4)");

            int filmSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine());
            switch (filmSelection)
            {
                case 1://the rock
                    Console.WriteLine("You have selected the rock");
                    ageCheck(age, 15);
                    break;
                case 2:
                    Console.WriteLine("You have selected Face / Off");
                    ageCheck(age, 18);
                    break;
                case 3:
                    Console.WriteLine("You have selected The Wicker Man");
                    ageCheck(age, 12);
                    break;
                case 4:
                    Console.WriteLine("You have selected The Croods");
                    Console.WriteLine("Enjoy the film");
                    break;

            }

        }
    }
}