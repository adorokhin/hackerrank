using C = System.Console;
class S
{
    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l-- > 0; )
        {
            long UpperLimit = long.Parse(C.ReadLine());
            long a = 1, b = 2, curr_fib = 0, sum=2;
            bool found = false;
            while (!found)
            { 
                curr_fib = a+b;
                if (curr_fib >= UpperLimit)
                    break;
                if (curr_fib % 2 == 0)
                    sum += curr_fib;
                a = b;
                b = curr_fib;
            }
            C.WriteLine(sum);
        }
    }
}
