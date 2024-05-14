namespace Laboratorna_13_2.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void TestFirstPartCalc()
    {
        // Arrange
        double x = 3, y = 4, z = 5;
        double expected = Math.Max(Math.Pow(x, 3), Math.Pow(x + y, 2)); // Expected result = max(27, 49) = 49

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader($"{x}\n{y}\n{z}\n"));

            // Act
            FirstPart.FirstPartCalc(new string[] { });

            // Assert
            string[] lines = sw.ToString().Trim().Split('\n');
            string lastLine = lines[lines.Length - 1];
            Assert.AreEqual($"Result: W = {expected}", lastLine);
        }
    }
    [Test]
    public void TestSecondPartCalc()
    {
        // Arrange
        double A = 30, B = 60, C = 90; // A = 30°, B = 60°, C = 90°
        double cosA = Math.Cos(A * Math.PI / 180);
        double cosB = Math.Cos(B * Math.PI / 180);
        double cosC = Math.Cos(C * Math.PI / 180);
        double expected = cosA + cosB + cosC; // Expected result = cos(30) + cos(60) + cos(90) = 0.5 + 0.5 + 0 = 1

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader($"{A}\n{B}\n{C}\n"));

            // Act
            SecondPart.SecondPartCalc(new string[] { });

            // Assert
            string[] lines = sw.ToString().Trim().Split('\n');
            string lastLine = lines[lines.Length - 1];
            Assert.AreEqual($"The inequality is proven: cosA + cosB + cosC <= 3/2", lastLine);
        }
    }
}

