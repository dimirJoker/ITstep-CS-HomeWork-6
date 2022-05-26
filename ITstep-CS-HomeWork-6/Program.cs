using System;

namespace ITstep_CS_HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> myArray = new MyArray<int>();
            var rSeed = new Random();
            for (var i = 0; i < 10; i++)
            {
                myArray.AddValue(rSeed.Next(100));
            }
            myArray.InsertValue(5, 555);
            myArray.InsertValue(myArray.Length, 222);
            myArray.UpdateValue(9, 999);
            myArray.UpdateValue(myArray.Length, 333);
        }
    }
}
