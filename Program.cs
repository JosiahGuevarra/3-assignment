namespace _3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            int room;
            double price;
            string subject;
            string name;
            int grad, radius;
            double pi;
            room = 29;
            price = 2.99;
            subject = "Computer science!";
            name = " Josiah Guevarra";
            grad = 2026;
            radius = 3;
            pi = 3.14;


            Console.WriteLine(" The room number is " + room);
            Console.WriteLine(" The price is " + price);
            Console.WriteLine(" I'm learning a little about " + subject);
            Console.WriteLine(" My name is" + name + (" and I Graduate in " +  grad));
            Console.WriteLine(" The Radius is " + radius);
            Console.WriteLine(" The area of this circle is " + (Math.Round(radius * radius * pi)));

            
            
        }
    }
}
