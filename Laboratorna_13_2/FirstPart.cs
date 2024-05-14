namespace Laboratorna_13_2;

public class FirstPart
{
    public static void FirstPartCalc(string[] args)
    {
        double x, y, z;

        Console.WriteLine("Enter the value of x:");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of y:");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of z:");
        z = double.Parse(Console.ReadLine());

        #region Equations

#if DEBUG
        Console.WriteLine("Equation 1: W = max(x^3, (x + y)^2) z<=10");
#endif

#if DEBUG
        Console.WriteLine("Equation 2: W = min(|x - z|, |x + z|) z>10");
#endif

        double W;

#if DEBUG
        if (z <= 10)
        {
            W = Math.Max(Math.Pow(x, 3), Math.Pow(x + y, 2));
        }
        else
        {
            W = Math.Min(Math.Abs(x - z), Math.Abs(x + z));
        }
#else
            W = (z <= 10) ? Math.Max(Math.Pow(x, 3), Math.Pow(x + y, 2)) : Math.Min(Math.Abs(x - z), Math.Abs(x + z));
#endif

        Console.WriteLine($"Result: W = {W}");
        
        #endregion
    }
}
