namespace Volosyna_DZ4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            River river = new River();

            Console.WriteLine("Enter the river name:");
            river.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter coordinate X:");
                if (double.TryParse(Console.ReadLine(), out double xCoordinate))
                {
                    river.XCoordinate = xCoordinate;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format of the coordinate X. Try again.");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter coordinate Y:");
                if (double.TryParse(Console.ReadLine(), out double yCoordinate))
                {
                    river.YCoordinate = yCoordinate;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format of the coordinate Y. Try again.");
                }
            }

            Console.WriteLine("Enter the description:");
            river.Description = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter the speed of the river (sm/s)");
                if (double.TryParse(Console.ReadLine(), out double flowSpeed))
                {
                    river.FlowSpeedCmPerSec = flowSpeed;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format. Try again.");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter total length of the river:");
                if (double.TryParse(Console.ReadLine(), out double totalLength))
                {
                    river.TotalLength = totalLength;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format for the total length. Try again.");
                }
            }

            Console.WriteLine("River information:");
            Console.WriteLine(river.GetInformation());
            Console.WriteLine();

            // Create a Mountain object
            Mountain mountain = new Mountain();

            Console.WriteLine("Enter the mountain name:");
            mountain.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter coordinate X:");
                if (double.TryParse(Console.ReadLine(), out double xCoordinate))
                {
                    mountain.XCoordinate = xCoordinate;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format of the coordinate X. Try again.");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter coordinate Y:");
                if (double.TryParse(Console.ReadLine(), out double yCoordinate))
                {
                    mountain.YCoordinate = yCoordinate;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format of the coordinate Y. Try again.");
                }
            }

            Console.WriteLine("Enter the description:");
            mountain.Description = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter the highest point of the mountain (meters above sea level):");
                if (double.TryParse(Console.ReadLine(), out double highestPoint))
                {
                    mountain.HighestPoint = highestPoint;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong format for the highest point. Try again.");
                }
            }

            // Display information about the Mountain
            Console.WriteLine("Mountain information:");
            Console.WriteLine(mountain.GetInformation());

            Console.ReadLine();
        }
    }
}