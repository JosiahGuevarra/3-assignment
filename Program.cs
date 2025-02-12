namespace _3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            int room, length, weidth;
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
            radius = 9;
            pi = 3.14;
            length = 8;
            weidth = 9;


            Console.WriteLine(" The room number is " + room);
            Console.WriteLine(" The price is " + price);
            Console.WriteLine(" I'm learning a little about " + subject);
            Console.WriteLine(" My name is" + name + (" and I Graduate in " +  grad));
            Console.WriteLine(" The Radius is " + radius);
            Console.WriteLine(" The area of this circle is " + (Math.Round(radius * radius * pi)));
            Console.WriteLine(" the formula of a square is length times weidth");
            Console.WriteLine(" the length equals 8 and the weidth equals 9," + (" this means the area of this square equals ") + (length * weidth));
            
            
        }
    }
}
