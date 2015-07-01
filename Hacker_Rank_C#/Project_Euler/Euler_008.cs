using C = System.Console;
using System.Linq;
using System.Diagnostics;

//Largest product in a series
//Problem 8
//The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
//Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?

class S
{

    static byte[] StringToByteArray(string s)
    {
        byte[] arrBytes = s.Select(c => byte.Parse(c.ToString())).ToArray();
        return arrBytes;
    }
    
    static long GetProduct(string s, int sample_len)
    {
        Trace.WriteLine(string.Format("Given {0}\nFind largest product of {1} consecutive digits.", s, sample_len));

        byte[] arrBytes = StringToByteArray(s);

        long prod = 0, max_prod = 0;
        int head = 0, tail=0;

        for (int i = 0; i < arrBytes.Length; i++)
        {
            tail = i;
            head = tail + sample_len -1;
            if (head >= arrBytes.Length)
                break;

            if (arrBytes[tail] == 0)
            {
                prod = 0;
                continue;
            }
            

            //Trace.WriteLine("First = " + first.ToString() + " arr[" + i.ToString() + "] = " + arrBytes[i].ToString());

            if (prod == 0)
            {
                for (int j = tail; j <= head; j++)
                {
                    if (arrBytes[j] == 0)
                    {
                        prod = 0;
                        continue;
                    }
                    if (prod == 0)
                        prod = 1;
                    prod *= arrBytes[j];
                }
            }
            else
            {
                //Trace.Write("Prev Prod = " + prod.ToString());
                if (arrBytes[head] == 0)
                {
                    i = head;
                    prod = 0;
                    continue;
                }
                prod  = prod/arrBytes[tail-1]*arrBytes[head];
                //Trace.WriteLine(" /=" + first.ToString() + " *= " + arrBytes[i + sample_len-1].ToString() + " = " + prod.ToString());
            }

            if (prod > max_prod)
            {
                max_prod = prod;
                //Trace.WriteLine(" New Max Prod " + prod.ToString());
                //pos = i;
                //sNums = string.Format("{0} {1} {2} {3} {4}", arrBytes[i], arrBytes[i + 1], arrBytes[i + 2], arrBytes[i + 3], arrBytes[i + 4]);
            }
        }
        //C.WriteLine("{0}\t{1}\t{2}", max_prod, pos, sNums);
        return max_prod;

    }

    static void Main(string[] args)
    {
        //1≤T≤100 
        //1≤K≤7 
        //K≤N≤1000
        string sTestCase = "1234567890";
        string L1;
        string[] sArr = null;
        int N, K = 5;
        long prod;

        if (args.Length == 0)
        {
            prod = GetProduct(sTestCase, K);
            C.WriteLine(prod);

        }
        else
        {
            for (int TestCases = int.Parse(C.ReadLine()); TestCases-- > 0; )
            {
                L1 = C.ReadLine();
                sArr = L1.Split(' ');
                N = int.Parse(sArr[0]);
                K = int.Parse(sArr[1]);
                sTestCase = C.ReadLine();
                prod = GetProduct(sTestCase, K);
                C.WriteLine(prod);
            }
        }
        C.ReadLine();
    }
}


