using System;

class Program
{
    static void Main()
    {
        // Example usage of the AddNumbers function
        int result = AddNumbers(5, 7);
        Console.WriteLine("The sum is: " + result);

        int result2 = MultiplyNumbers(5, 7);
        Console.WriteLine("The sum is: " + result);
    }

    // Definition of the AddNumbers function
    static int AddNumbers(params int[] numbers)
    {
        int sum = 0

        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static int MultiplyNumbers(int num1, int num2)
    {
        int product = num1 * num2;
        return product
    }
}
