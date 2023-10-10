    class Program
{
    static int GetValidIntegerInput(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                int result = int.Parse(Console.ReadLine());
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Give the initial coordinates of the point (x, y, z):");

            int x = GetValidIntegerInput("x: ");
            int y = GetValidIntegerInput("y: ");
            int z = GetValidIntegerInput("z: ");

            Point3D point = new Point3D(x, y, z);

            Console.WriteLine($"Initial coordinates of the point: {point}");

            Console.WriteLine("Specify the translation values for the coordinates (x, y, z):");

            x = GetValidIntegerInput("x: ");
            y = GetValidIntegerInput("y: ");
            z = GetValidIntegerInput("z: ");

            point.Translate(x, y, z);

            Console.WriteLine($"New coordinates of the point after translation: {point}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error has occurred: {e.Message}");
        }
    }
}


