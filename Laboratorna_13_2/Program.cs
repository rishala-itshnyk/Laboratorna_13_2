using System;
using Laboratorna_13_2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Executing FirstPart...");
        FirstPart.FirstPartCalc(args);
        
        Console.WriteLine("\nExecuting SecondPart...");
        SecondPart.SecondPartCalc(args);

        Console.WriteLine("\nProgram execution complete.");
    }
}