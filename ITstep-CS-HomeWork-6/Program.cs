﻿
using System;

namespace ITstep_CS_HomeWork_6
{
    internal class Program
    {
        static void PrintUnicValue(MyArray<int> firstArray, MyArray<int> SecondArray)
        {
            var tempArr = new MyArray<int>();
            for (var i = 0; i < firstArray.Length; i++)
            {
                tempArr.Add(firstArray[i]);
            }
            for (var i = 0; i < SecondArray.Length; i++)
            {
                tempArr.Add(SecondArray[i]);
            }
            for (var i = 0; i < tempArr.Length; i++)
            {
                var toKill = false;
                for (var j = i + 1; j < tempArr.Length; j++)
                {
                    if (tempArr[j] == tempArr[i])
                    {
                        tempArr.Remove(j);
                        toKill = true;
                    }
                }
                if (toKill == true)
                {
                    tempArr.Remove(i);
                }
                else
                {
                    Console.Write($"{tempArr[i]}; ");
                }
            }
        }
        static void Main(string[] args)
        {
            MyArray<int> myArr0 = new MyArray<int>();
            MyArray<int> myArr1 = new MyArray<int>();
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