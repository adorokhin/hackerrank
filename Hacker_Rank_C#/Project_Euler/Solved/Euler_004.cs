﻿using C = System.Console;
using System.Collections;

class S
{
    private static ArrayList GeneratePalindromes()
    {
        ArrayList arrPals = new ArrayList();
        string s = null;
        for (uint i = 101101; i <= 999999; i++)
        {
            s = i.ToString();
            if (s.Substring(0, 3) == (s.Substring(5, 1) + s.Substring(4, 1) + s.Substring(3, 1)))
                arrPals.Add(i);
        }
        return arrPals;
    }
    private static void PalsFactored()
    {
        ArrayList arrPals = new ArrayList();
        uint FirstFactor = 0, SecondFactor = 0;
        foreach (uint nPal in GeneratePalindromes())
        {
            C.Write(nPal);
            for (FirstFactor = 100; FirstFactor <= 999; FirstFactor++)
            {
                if (nPal % FirstFactor == 0)
                {
                    SecondFactor = nPal / FirstFactor;
                    if (SecondFactor >= 100 && SecondFactor <= 999)
                    {
                        C.Write("\t{0}x{1}", FirstFactor, SecondFactor);
                        if (!arrPals.Contains(nPal))
                            arrPals.Add(nPal);
                    }
                }
            }
            C.WriteLine();
        }

        C.WriteLine();
        foreach (uint nPal in arrPals)
            C.Write(nPal + ",");
    }
    
    static void Main()
    {
        //PalsFactored();

        ArrayList arrPalindroms = new ArrayList(){ 
                101101,102201,105501,106601,108801,110011,111111,117711,119911,121121,122221,123321,127721,128821,129921,131131,133331,
                135531,137731,138831,140041,141141,142241,143341,147741,149941,154451,155551,156651,159951,161161,162261,165561,168861,
                171171,174471,178871,180081,182281,184481,187781,188881,189981,198891,201102,202202,204402,209902,210012,212212,213312,
                214412,215512,216612,219912,220022,221122,222222,225522,227722,231132,232232,234432,235532,238832,239932,242242,244442,
                246642,249942,252252,255552,256652,257752,258852,259952,262262,266662,270072,272272,273372,276672,277772,279972,280082,
                282282,284482,286682,289982,290092,292292,294492,296692,297792,299992,301103,302203,303303,306603,308803,320023,321123,
                324423,329923,330033,333333,335533,343343,345543,348843,354453,357753,359953,363363,366663,367763,369963,371173,372273,
                374473,375573,377773,378873,384483,391193,393393,397793,399993,401104,402204,404404,405504,407704,408804,409904,412214,
                414414,416614,420024,421124,424424,425524,426624,428824,432234,434434,436634,438834,440044,441144,442244,443344,444444,
                445544,447744,452254,456654,459954,461164,462264,464464,468864,469964,470074,471174,474474,476674,477774,484484,485584,
                487784,488884,489984,491194,493394,505505,506605,507705,508805,509905,510015,512215,513315,514415,515515,519915,520025,
                522225,523325,525525,528825,531135,534435,535535,536635,543345,545545,548845,549945,550055,551155,554455,555555,560065,
                561165,564465,565565,570075,571175,573375,575575,576675,577775,579975,580085,585585,588885,589985,592295,595595,601106,
                602206,603306,604406,606606,611116,612216,616616,618816,619916,623326,630036,631136,636636,639936,642246,648846,649946,
                650056,652256,653356,654456,656656,657756,660066,661166,663366,666666,672276,675576,678876,689986,693396,696696,698896,
                723327,729927,737737,747747,749947,770077,780087,793397,801108,802208,804408,807708,809908,819918,821128,824428,828828,
                840048,853358,855558,861168,886688,888888,906609};
        

        for (int l = int.Parse(C.ReadLine()); l-- > 0; )
        {
            int TestNumber = int.Parse(C.ReadLine());
            int nCurr=0;
            int nPrev=0;
            foreach(int n in arrPalindroms)
            {
                nPrev = (nCurr == 0) ? n : nCurr;
                nCurr=n;
                if(n>TestNumber)
                    break;
            }
            C.WriteLine(nPrev);
        }
    }
}

