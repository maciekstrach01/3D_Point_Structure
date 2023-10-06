class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Give the initial coordinates of the point (x, y, z):");
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z: ");
            int z = int.Parse(Console.ReadLine());

            Point3D point = new Point3D(x, y, z);

            Console.WriteLine($"Initial coordinates of the point: {point}");

            Console.WriteLine("Specify the translation values for the coordinates (x, y, z):");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("z: ");
            z = int.Parse(Console.ReadLine());

            point.Translate(x, y, z);

            Console.WriteLine($"New coordinates of the point after translation:: {point}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error has occurred: {e.Message}");
        }
    }
}

