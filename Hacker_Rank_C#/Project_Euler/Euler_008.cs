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
        //string s = @"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        byte[] arrBytes = StringToByteArray(s);

        long prod = 1;
        long max_prod = 0;
        //int pos = 0;
        //string sNums = "";

        for (int i = 0; i < arrBytes.Length - sample_len; i++)
        {
            prod = 1;
            for (int j = 0; j < sample_len; j++)
            {
                if (arrBytes[i + j] == 0)
                {
                    prod = 0;
                    i += (j+1);
                    break;
                }

                prod *= arrBytes[i+j];
            }

            if (prod > max_prod)
            {
                max_prod = prod;
                //pos = i;
                //sNums = string.Format("{0} {1} {2} {3} {4}", arrBytes[i], arrBytes[i + 1], arrBytes[i + 2], arrBytes[i + 3], arrBytes[i + 4]);
            }
        }
        //C.WriteLine("{0}\t{1}\t{2}", max_prod, pos, sNums);
        return max_prod;
    }

    static long GetProduct2(string s, int sample_len)
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
            prod = GetProduct2(sTestCase, K);
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
                prod = GetProduct2(sTestCase, K);
                C.WriteLine(prod);
            }
        }
        C.ReadLine();
    }
}


