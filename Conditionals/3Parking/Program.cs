namespace _3Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
This application will simulate parking sensors on a car.
 
First the program "detects" (i.e. asks the user - who is playing the role of sensors on the car) if the
car is in reverse to move backwards.
 
If the car is in reverse to move backwards then the program should detect the distance to the nearest
object behind the car in metres.
 
If the distance to the nearest object is less that 1.5 metres the program should output "beep, beep, beep"
*/

            Console.WriteLine("Parking Sensors Application");

            Console.WriteLine("Is the car in reverse? Press Y for yes or N for no.");

            string isInReverse = Console.ReadLine();

            Console.WriteLine("How much space is there behind the car?");

            float emptySpaceBehindCar = float.Parse(Console.ReadLine());
            if((isInReverse==y || isInReverse == Y) && (emptySpaceBehindCar < 1.5))
            {
                Console.WriteLine("Beep Beep Beep");
            }
        }
    }
}