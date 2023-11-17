using System;

public class Program
{
    public static void Main()
    {
        // Example usage of the AddNumbers function
        int result = AddNumbers(5, 7);
        Console.WriteLine("The sum is: " + result);

        int result2 = MultiplyNumbers(5, 7);
        Console.WriteLine("The product is: " + result2);
    }

    // Definition of the AddNumbers function
    static int AddNumbers(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static int MultiplyNumbers(int number, params int[] numbers)
    {
        int product = number;
        foreach (int num in numbers)
        {
            product *= num;
        }
        return product;
    }



}
