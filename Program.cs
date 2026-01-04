using System;

namespace AllTasksInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------
            // Task 1: Read a string and print it
            // -----------------------
            Console.WriteLine("=== Task 1 ===");
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();
            Console.WriteLine("You entered: " + userString);
            Console.WriteLine();

            // -----------------------
            // Task 2: Variables of different types
            // -----------------------
            Console.WriteLine("=== Task 2 ===");
            double myDouble = 2.75;
            string myString = "Hello C#";
            char myChar = 'B';
            bool myBool = false;
            int myInt = 42;
            const int myConst = 100;

            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("String: " + myString);
            Console.WriteLine("Char: " + myChar);
            Console.WriteLine("Bool: " + myBool);
            Console.WriteLine("Int: " + myInt);
            Console.WriteLine("Const: " + myConst);
            Console.WriteLine();

            // -----------------------
            // Task 3: Cars array
            // -----------------------
            Console.WriteLine("=== Task 3 ===");
            string[] cars = { "BMW", "Audi", "Toyota", "Honda" };
            Console.WriteLine("Cars in the array:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("Array length: " + cars.Length);
            Console.WriteLine();

            // -----------------------
            // Task 4: Read first name, last name, year
            // -----------------------
            Console.WriteLine("=== Task 4 ===");
            Console.Write("Input your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input your year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstName + " " + lastName + " " + year);
            Console.WriteLine();

            // -----------------------
            // Task 5: Array input and print
            // -----------------------
            Console.WriteLine("=== Task 5 ===");
            int[] arr = new int[10];
            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element - " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\n\n=== End of Program ===");
        }
    }
}
