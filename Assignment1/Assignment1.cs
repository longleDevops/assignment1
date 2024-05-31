

using System;
using antra;

/*
 1. What type would you choose for the following “numbers”?
- A person’s telephone number: String
- A person’s height: Float
- A person’s age: Integer
- A person’s gender (Male, Female, Prefer Not To Answer): Enum/String
- A person’s salary: Float
- A book’s ISBN: String
- A book’s price: Float
- A book’s shipping weight: Float
- A country’s population: Integer
- The number of stars in the universe: Big Integer
- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): Integer

2. What are the difference between value type and reference type variables? What is boxing and unboxing?

---value type:
+ has a fixed size and value
+ hold value variable store in stack memory
+ can not be collected by garbage collector
+ can not accept null value
+ are created using struct or enum

--reference type:
+ does not have fixed size and dynamic
+ hold the memory address stored in heap memory
+ are collected by garbage collector
+ can accept null value
+ reference are created using class or interface

- Boxing is the process of converting a value type to a reference type
- Unboxing is converting reference type to a value type

3. What is meant by the terms managed resource and unmanaged resource in .NET?

- Managed resources are resources that are handled by the .NET runtime's garbage collector while unmanaged resources are not.

4. What's the purpose of the Garbage Collector in .NET?

- The purpose of the garbage collector in .NET is collecting unreachable or unused data automatically.
*/

namespace antra.AntraCSharpHW
{
    public class Assignment1
    {
        public static void Main(string[] args)
        {
            UnderstandingTyper();


            Pyramid(5);

            guessing();

            birthday(2000, 4, 12);

            greeting();

            counting();
        }

        public static void UnderstandingTyper()
        {
            // sbyte val
            Console.WriteLine("sbyte:");
            Console.WriteLine($"Size: {sizeof(sbyte)} bytes");
            Console.WriteLine($"Min Value: {sbyte.MinValue}");
            Console.WriteLine($"Max Value: {sbyte.MaxValue}");
            Console.WriteLine();

            // byte
            Console.WriteLine("byte:");
            Console.WriteLine($"Size: {sizeof(byte)} bytes");
            Console.WriteLine($"Min Value: {byte.MinValue}");
            Console.WriteLine($"Max Value: {byte.MaxValue}");
            Console.WriteLine();

            // short
            Console.WriteLine("short:");
            Console.WriteLine($"Size: {sizeof(short)} bytes");
            Console.WriteLine($"Min Value: {short.MinValue}");
            Console.WriteLine($"Max Value: {short.MaxValue}");
            Console.WriteLine();

            // ushort
            Console.WriteLine("ushort:");
            Console.WriteLine($"Size: {sizeof(ushort)} bytes");
            Console.WriteLine($"Min Value: {ushort.MinValue}");
            Console.WriteLine($"Max Value: {ushort.MaxValue}");
            Console.WriteLine();

            // int
            Console.WriteLine("int:");
            Console.WriteLine($"Size: {sizeof(int)} bytes");
            Console.WriteLine($"Min Value: {int.MinValue}");
            Console.WriteLine($"Max Value: {int.MaxValue}");
            Console.WriteLine();

            // uint
            Console.WriteLine("uint:");
            Console.WriteLine($"Size: {sizeof(uint)} bytes");
            Console.WriteLine($"Min Value: {uint.MinValue}");
            Console.WriteLine($"Max Value: {uint.MaxValue}");
            Console.WriteLine();

            // long
            Console.WriteLine("long:");
            Console.WriteLine($"Size: {sizeof(long)} bytes");
            Console.WriteLine($"Min Value: {long.MinValue}");
            Console.WriteLine($"Max Value: {long.MaxValue}");
            Console.WriteLine();

            // ulong
            Console.WriteLine("ulong:");
            Console.WriteLine($"Size: {sizeof(ulong)} bytes");
            Console.WriteLine($"Min Value: {ulong.MinValue}");
            Console.WriteLine($"Max Value: {ulong.MaxValue}");
            Console.WriteLine();

            // float
            Console.WriteLine("float:");
            Console.WriteLine($"Size: {sizeof(float)} bytes");
            Console.WriteLine($"Min Value: {float.MinValue}");
            Console.WriteLine($"Max Value: {float.MaxValue}");
            Console.WriteLine();

            // double
            Console.WriteLine("double:");
            Console.WriteLine($"Size: {sizeof(double)} bytes");
            Console.WriteLine($"Min Value: {double.MinValue}");
            Console.WriteLine($"Max Value: {double.MaxValue}");
            Console.WriteLine();

            // decimal
            Console.WriteLine("decimal:");
            Console.WriteLine($"Size: {sizeof(decimal)} bytes");
            Console.WriteLine($"Min Value: {decimal.MinValue}");
            Console.WriteLine($"Max Value: {decimal.MaxValue}");
            Console.WriteLine();

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        //2. Print-a-Pyramid.
        public static void Pyramid(int n)
        {
            if (n==1)
            {
                Console.WriteLine('*');
            } else
            {
                for (int i = 1; i < n; i++)
                {
                    Console.Write(new string(' ', n - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
            }
        }

        //3. Guessing number
        public static void guessing()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4); // generate ran numbers from 1 to 4

            int guessedNumber = int.Parse(Console.ReadLine()); // Convert string input to an integer

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range.");
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
        }

        //4. birthday
        public static void birthday(int a, int b, int c)
        {
            DateTime birthDay = new DateTime(a, b, c);
            TimeSpan age = DateTime.Today - birthDay;
            int days = (int)age.TotalDays;
            Console.WriteLine(days);

            int daysToNextAnniversary = 10000 - (days % 10000);
            Console.WriteLine("the days to next Anniversary: " + daysToNextAnniversary);

        }

        //5. greeting
        public static void greeting()
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            if (hour >= 7 && hour < 11)
                Console.WriteLine("Good morning!");
            if (hour >= 12 && hour < 17)
                Console.WriteLine("Good afternoon!");

            if (hour >= 17 && hour < 19)
                Console.WriteLine("Good evening!");

            if (hour >= 19 || hour < 7)
                Console.WriteLine("Good night!");
        }

        //6. counting
        public static void counting()
        {
            for (int i = 1; i <= 4; i++) // 4 lines
            {
                for (int j = 0; j <= 24; j += i) // increment by 1
                {
                    Console.Write(j);
                    if (j < 24 && j + i <= 24) // cases that includes comma
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
