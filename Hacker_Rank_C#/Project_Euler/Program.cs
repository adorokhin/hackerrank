//usingSystem;classS{staticvoidMain(){inti=0;Predicate<int>t=n=>i%n==0;for(;i++<100;)Console.WriteLine((t(3)?"Fizz":"")+(t(5)?"Buzz":(t(3)?"":""+i)));}}

//usingC=System.Console;
//classSolution{staticvoidMain(){intl=int.Parse(C.ReadLine());
//while(l-->0){doubler=0;intn=int.Parse(C.ReadLine());for(inti=0;i<n;i++)r+=((i%2==0)?1:-1)/(2.0*i+1);
//C.WriteLine(r);}}}
//usingC=System.Console;classS{staticvoidMain(){for(intl=int.Parse(C.ReadLine());l-->0;){varr=0.0;for(intn=int.Parse(C.ReadLine()),i=0;i<n;i++)r+=(i%2<1?1:-1)/(2.0*i+1);C.WriteLine(r);}}}

using C = System.Console;
class S
{
    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l-- > 0; )
        {
            var r = 0d;
            for (int n = int.Parse(C.ReadLine()), i = 0; i < n; i++)
                r += (i % 2 < 1 ? 1 : -1) / (2.0 * i + 1);
            C.WriteLine(r);
        }
    }
}


