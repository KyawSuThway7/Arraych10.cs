using System;

namespace Ch10Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aissignment 1");
            int inputnumber;
            try
            {
                Console.Write("Enter number of values : ");
                inputnumber = Convert.ToInt32(Console.ReadLine());
                int[] number = new int[inputnumber];
                int count = 1;
                for (int input = 0; input < inputnumber; input++)
                {
                    Console.Write($"Enter Value {count} : ");
                    int numbers = Convert.ToInt32(Console.ReadLine());
                    number[input] = numbers;
                    count++;
                }
                Console.Write("Your entered value are : ");
                for (int input1 = 0; input1 < inputnumber; input1++)
                {
                    Console.Write($" {number[input1]}");

                    if (input1 < inputnumber - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
                int maxvalue = number[0];
                int minvalue = number[0];
                int total = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] > maxvalue)
                    {
                        maxvalue = number[j];
                    }
                    if (number[j] < minvalue)
                    {
                        minvalue = number[j];
                    }
                    total += number[j];
                }
                float average = (float)total / (float)inputnumber;
                Console.WriteLine("Maximum : " + maxvalue);
                Console.WriteLine("Minimum : " + minvalue);
                Console.WriteLine("Total : " + total);
                Console.WriteLine("Average : " + average);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error !!! Your input must be number");
            }
            catch (Exception e1)
            {
                Console.WriteLine("Type only number");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
