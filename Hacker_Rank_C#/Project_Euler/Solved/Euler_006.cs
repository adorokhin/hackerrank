using C = System.Console;

class S
{
    static long SumOfSquares(long n)
    {
        return (long)((n*(n+1)*(2*n+1))/6.0);
    }

    static long SquaresOfSum(long n)
    {
        return (long)(System.Math.Pow(((n*(1+n))/2), 2.0));
    }

    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l--> 0; )
        {
            int Range = int.Parse(C.ReadLine());
            C.WriteLine(SquaresOfSum(Range) - SumOfSquares(Range));
        }
    }
}

