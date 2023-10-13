namespace _2PizzaShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            This pizza shop application asks the user for the value of their food in pounds.
 
            If the value of the food is at least £10 then they can get free delivery - otherwise you need to charge an extra £2 for delivery.
 
            If the value of the food is more than £14 then they can get free delivery and a free garlic bread.
            */

            Console.WriteLine("Welcome to the Pizza Shop Application!");

            Console.WriteLine("What was the value of your order?");
            float val = float.Parse(Console.ReadLine());
            if (val >= 14)
            {
                Console.WriteLine("Your cost will be " + val + " and you get free delivery and a free garlic bread");
            }else if (val >= 10)
            {
                Console.WriteLine("your cost will be " + val + " and you get free delivery");
            }
            else
            {
                Console.WriteLine("your cost is "+(val+2));
            }

        }
    }
}