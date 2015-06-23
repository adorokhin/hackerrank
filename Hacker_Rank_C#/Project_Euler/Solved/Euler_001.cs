using C = System.Console;
class S
{
    static long GetSumHelper(long nGivenNumber, long nDivizor)
    {
        if (nGivenNumber <= nDivizor)
            return 0;
        long nunOfElements = (nGivenNumber-1)/nDivizor;
        long result = (nunOfElements * (nDivizor + nDivizor * nunOfElements)) / 2;
        return result;
    }

    static long GetSum(long n)
    {
        return GetSumHelper(n, 3) + GetSumHelper(n, 5) - GetSumHelper(n, 15);

    }

    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l-- > 0; )
        {
            /*
            long sum = 0;
            long s3 = 0;
            long s5 = 0;
            long s15 = 0;
            */ 
            long n = long.Parse(C.ReadLine());
            /*
            for (int i = 0; i < n; i++)
            {
                if ((i%3==0) || (i%5==0))
                    sum+=i;
            }
            s3 = GetSum(n, 3);
            s5 = GetSum(n, 5);
            s15 = GetSum(n, 15);
            
            C.WriteLine((s3+s5-s15).ToString() + "\t\t" + sum.ToString() + "\t( " + s3.ToString() + "\t" + s5.ToString() + "\t" + s15.ToString() + " )");
             */
            C.WriteLine(GetSum(n));
        }
    }
}
