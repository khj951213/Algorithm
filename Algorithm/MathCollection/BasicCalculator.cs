namespace MathCollection;
public class BasicCalculator
{
    private double res = 0;

    public BasicCalculator(double a, string o, double b)
    {
        switch (o)
        {
            case "+":
                res = plus(a, b);
                break;
            case "-":
                res = minus(a, b);
                break;
            case "*":
                res = multiply(a, b);
                break;
            case "/":
                res = division(a, b);
                break;
            default:
                throw new Exception("Not allowed operaiton method");
        }
    }

    public double plus(double a, double b)
    {
        return a + b;
    }

    public double minus(double a, double b)
    {
        return a - b;
    }

    public double multiply(double a, double b)
    {
        return a * b;
    }

    public double division(double a, double b)
    {
        return a / b;
    }

    public double result()
    {
        return Math.Round(res, 2);
    }
}

