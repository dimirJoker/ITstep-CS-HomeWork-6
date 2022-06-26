using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintUnicValue(List<int> firstArray, List<int> SecondArray)
        {
            var tempArr = new List<int>();
            for (var i = 0; i < firstArray.Count; i++)
            {
                tempArr.Add(firstArray[i]);
            }
            for (var i = 0; i < SecondArray.Count; i++)
            {
                tempArr.Add(SecondArray[i]);
            }
            for (var i = 0; i < tempArr.Count; i++)
            {
                var toKill = false;
                for (var j = i + 1; j < tempArr.Count; j++)
                {
                    if (tempArr[j] == tempArr[i])
                    {
                        tempArr.RemoveAt(j);
                        toKill = true;
                    }
                }
                if (toKill == true)
                {
                    tempArr.RemoveAt(i);
                }
                else
                {
                    Console.Write($"{tempArr[i]}; ");
                }
            }
        }
        static void Main(string[] args)
        {
            var myArr0 = new List<int>();
            var myArr1 = new List<int>();
            var rSeed = new Random();
            for (var i = 0; i < 10; i++)
            {
                myArr0.Add(rSeed.Next(100));
                myArr1.Add(rSeed.Next(100));
            }
            myArr0.Insert(0, 999);
            myArr0.Insert(7, 999);
            myArr0.Add(999);
            myArr1.Insert(0, 999);
            myArr1.Insert(7, 999);
            myArr1.Add(999);
            PrintUnicValue(myArr0, myArr1);
        }
    }
}
