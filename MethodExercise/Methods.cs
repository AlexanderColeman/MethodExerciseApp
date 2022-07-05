using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise;

public class Methods
{
    public string GetString(string prompt)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();
        return input;
    }

    public void Add()
    {
        
        Console.WriteLine("\n\nWe are going to add some number today. Please enter two numbers to add ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int sum = x + y;
        Console.WriteLine($"The sum is: {sum}");
    }
    public void Subtract(int x, int y)
    {
        int result = x - y;
        Console.WriteLine("Now onto subtraction, Im going to pick these two numbers because the above selections were terrible");
        Console.WriteLine($"The value of {x} - {y} is: {result}");
        
    }
    public int Mulitply(int x, int y)
    {
        return x * y;
    }
    public int Divide(int x, int y)
    {
        return x/y;
    }

    public void AddParam(params int[] arr)
    {
        Console.WriteLine("\n\n\nHere are the numbers in your Array that will be added together");
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
        int sum = 0;
        for(int i =0; i< arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"The sum is {sum}");
        
    }



}
