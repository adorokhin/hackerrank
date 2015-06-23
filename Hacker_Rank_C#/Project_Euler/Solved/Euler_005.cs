using C = System.Console;
using System.Collections;

class S
{
    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l--> 0;)
        {
            int Range = int.Parse(C.ReadLine());
            int[] arrFactors = new int[Range-1];
            int i = 0;
            for (;i<Range-1; i++)
                arrFactors[i]=i+2;

            int curr_factor = 0;
            long Product = 1;
            for(i=0; i<arrFactors.Length; i++)
            {
                bool found = false;
                curr_factor = arrFactors[i];
                for (int j = i; j<arrFactors.Length; j++)
                {
                    if (arrFactors[j] % curr_factor == 0)
                    {
                        arrFactors[j] = arrFactors[j] / curr_factor;
                        found = true;
                    }
                }
                if(found)
                    Product *= curr_factor;
            }
            C.WriteLine(Product);
        }
    }
}

