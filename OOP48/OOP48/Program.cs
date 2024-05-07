namespace OOP48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Enter the radius of the circle==>  ");
            double radius = double.Parse(Console.ReadLine());
            Krug ploshad = new Krug(radius);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nPloshad kruga==> {ploshad.Ploshad()}\n ");
            Console.WriteLine($"Perimetr==<{ ploshad.Perimetr()}" );

            Console.WriteLine("\nEnter the sides of the triangle++>  ");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());
            Triugolnik triangle = new Triugolnik(side1, side2, side3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nPloshad triugolnika=> {triangle.Ploshad()}\n");
            Console.WriteLine($"Perimetr => {triangle.Perimetr()}\n");

            Main(args);
        }
    }
}
