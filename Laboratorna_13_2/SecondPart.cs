namespace Laboratorna_13_2;

public class SecondPart
{
    public static void SecondPartCalc(string[] args)
    {
        double A, B, C;

        Console.WriteLine("Enter the value of angle A in degrees:");
        A = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of angle B in degrees:");
        B = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of angle C in degrees:");
        C = double.Parse(Console.ReadLine());

        // Convert degrees to radians
        A = A * Math.PI / 180;
        B = B * Math.PI / 180;
        C = C * Math.PI / 180;

        #region Inequality

#if DEBUG
        Console.WriteLine("Proving the inequality: cosA + cosB + cosC <= 3/2");
#endif

        double cosA = Math.Cos(A);
        double cosB = Math.Cos(B);
        double cosC = Math.Cos(C);

        double result = cosA + cosB + cosC;

#if DEBUG
        Console.WriteLine($"Result: cosA + cosB + cosC = {result}");
#endif

#if DEBUG
        if (result <= 1.5)
        {
            Console.WriteLine("The inequality is proven: cosA + cosB + cosC <= 3/2");
        }
        else
        {
            Console.WriteLine("The inequality is not proven.");
        }
#else
            if (result <= 1.5)
            {
                Console.WriteLine("The inequality is true: cosA + cosB + cosC <= 3/2");
            }
            else
            {
                Console.WriteLine("The inequality is not true.");
            }
#endif

        #endregion
    }
}