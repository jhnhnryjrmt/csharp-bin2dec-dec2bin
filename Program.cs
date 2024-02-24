while (true) // Start of the loop
{
    Console.WriteLine("=========================================");
    Console.WriteLine("|     BINARY TO DECIMAL CONVERSION      |");
    Console.WriteLine("|         PLEASE SELECT BELOW:          |");
    Console.WriteLine("|                                       |");
    Console.WriteLine("|         1. BINARY TO DECIMAL          |");
    Console.WriteLine("|         2. DECIMAL TO BINARY          |");
    Console.WriteLine("|            3. CLOSE APP               |");
    Console.WriteLine("=========================================");

    Console.WriteLine("Your Choice: ");
    int yourChoice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You have selected: {yourChoice}");

    switch (yourChoice)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|           BINARY TO DECIMAL           |");
            Console.WriteLine("=========================================");
            Console.WriteLine("Input a binary number: ");
            try
            {
                var binary = Console.ReadLine();
                int result = Convert.ToInt32(binary, 2);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            break;
        case 2:
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|           DECIMAL TO BINARY           |");
            Console.WriteLine("=========================================");
            Console.WriteLine("Input a decimal number: ");
            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                string binaryResult = Convert.ToString(value, 2);
                Console.WriteLine($"Result: {binaryResult}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            break;
        case 3:
            Console.Clear();
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
