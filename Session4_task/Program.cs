namespace Session4_task
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new(); // Arr Dynamic
            
            for (int i = 1; i <= 100; i++) // Loop to add numbers from 1 to 100
            {
                numbers.Add(i);
            };

            bool running = true;// Flag to control the loop

            while (running) // Main loop for the menu
            {
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");

                char choice = char.ToUpper(Console.ReadKey().KeyChar);// Read user input and convert to uppercase

                Console.WriteLine();

                switch (choice) // Switch statement to handle user choices
                {
                    case 'P':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        } // Check if the list is empty
                        else
                        {
                            Console.Write("[ ");

                          for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }// Print the numbers in the list

                            Console.WriteLine("]");
                        }; 

                        break;


                    case 'A':

                        Console.Write("Enter a number to add: ");// Prompt user to enter a number

                       int numberToAdd = int.Parse(Console.ReadLine());// Read the number from user input

                        numbers.Add(numberToAdd); // Add the number to the list

                        Console.WriteLine($"{numberToAdd} added");// Confirm that the number has been added

                        break;


                    case 'M':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine(
                                "Unable to calculate the mean - no data");
                        }// Check if the list is empty
                        else
                        {
                            int sum = 0;

                          for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }// Calculate the sum of the numbers in the list

                            double mean = (double)sum / numbers.Count;// Calculate the mean

                            Console.WriteLine($"The mean is {mean}");
                        }

                        break;


                    case 'S':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }// Check if the list is empty
                        else
                        {
                            int smallest = numbers[0]; // Initialize smallest with the first number in the list

                            for (int i = 1; i < numbers.Count; i++)
                            {
                               
                                
                              if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            } // Find the smallest number in the list

                            Console.WriteLine($"The smallest number is {smallest}");
                        }

                        break;


                    case 'L':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        } // Check if the list is empty
                        else
                        {
                            int largest = numbers[0]; // Initialize largest with the first number in the list

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            } // Find the largest number in the lis

                            Console.WriteLine($"The largest number is {largest}");
                        }

                        break;


                    case 'Q':

                        Console.WriteLine("Goodbye");// Print goodbye message

                        running = false; // Set running to false to exit the loop

                        break;


                    default:// Handle unknown selections

                        Console.WriteLine(
                            "Unknown selection, please try again");

                        break;
                }
            }
        }
    }
}

       
