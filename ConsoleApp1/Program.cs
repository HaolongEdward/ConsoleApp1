using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        //Given by any nature number n, you have 2 identical sets which contains {2^i | 0<=i<=n}
        //want to know how many different ways get number by adding elements from those two sets.
        //Each element can be use only once. 
        //for example 2 = 2 = 1+1 which means the solution is *2* different ways.
        //a bigger example:
        //        13 = 8 + 4 + 1 
        //           = 8 + 2 + 2 + 1 
        //           = 4 + 4 + 2 + 2 + 1


        //this project assuming inputs are all legal
        static void Main(string[] args)
        {
            List<string> binaryRepresentation = GetBinaryRepresentation(GetBinaryString());


            //this line of code doesnt work as expected.
            //Console.Write(binaryRepresentation.ToString());

            Console.WriteLine(IsDone(binaryRepresentation));
            //Console.WriteLine(ExponentialDecrease("2^1"));
            
            Console.WriteLine("Any key to quit: ");
            Console.ReadLine();
        }

        static List<List<int>> GetSolution(int target)
        {


            //return something for now to shut up compiler
            return new List<List<int>>();
        }

        //should be working now??? tried 15 and 11, returns are same as excepted
        static Boolean IsDone(List<string> lastSolution)
        {
            //if (twoToX == "2^0")
            //{ return true; }

            for (int i = 0; i< lastSolution.Count; i++)
            {
                //Console.WriteLine(lastSolution[i]);
                if (lastSolution[i] == "2^0")
                { return true; }
                else if (lastSolution[i] == "0")
                { return false; }
                else if (lastSolution[i + 1] == "0")
                { return false; }
                else if (ExponentialDecrease(lastSolution[i]) != lastSolution[i + 1])
                { }
            }

            return true;
        }

        //2^x -> 2^(x-1)
        static string ExponentialDecrease(string twoToX)
        {
            string exponentString = twoToX.Substring(twoToX.IndexOf('^')+1);
            int exponent = int.Parse(exponentString);
            StringBuilder builder = new StringBuilder();
            builder.Append("2^");
            builder.Append(exponent - 1);
            return builder.ToString();
        }

        //
        static List<List<string>> BreakDownByIgnoreTerms(List<string> binaryRepresentation, List<string> ignoredTerms)
        {

            
            return new List<List<string>>();
        }

        static List<string> GetBinaryRepresentation(string binargString)
        {
            List<string> sumOf2sExponent = new List<string>();
            for (int i = binargString.Length - 1; i >= 0; i--)
            {
                if (binargString[i] == '0')
                { sumOf2sExponent.Add("0"); }
                else if (binargString[i] == '1')
                { sumOf2sExponent.Add("2^" + i); }
                else
                {
                    Console.WriteLine("something happened!!");
                }
            }

            return sumOf2sExponent;
        }

        static string GetBinaryString()
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }
        
    }
}
