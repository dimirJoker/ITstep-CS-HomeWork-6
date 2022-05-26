using System;

namespace ITstep_CS_HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> myArr0 = new MyArray<int>();
            MyArray<int> myArr1 = new MyArray<int>();
            var rSeed = new Random();
            for (var i = 0; i < 10; i++)
            {
                myArr0.AddValue(rSeed.Next(100));
                myArr1.AddValue(rSeed.Next(100));
            }
            myArr0.InsertValue(0, 999);
            myArr0.InsertValue(7, 999);
            myArr0.AddValue(999);
            myArr1.InsertValue(0, 999);
            myArr1.InsertValue(7, 999);
            myArr1.AddValue(999);









            ////////////////////////////////////////////////////////////////
            MyArray<int> myArr0Memo = new MyArray<int>(); // save arr0
            for (var i = 0; i < myArr0.Length; i++)
            {
                myArr0Memo.AddValue(myArr0[i]);
            }
            ////////////////////////////////////////////////////////////////
            for (var i = 0; i < myArr0.Length; i++) // del arr0 reps
            {
                var toKill = false;
                for (var j = i + 1; j < myArr0.Length; j++)
                {
                    if (myArr0[i] == myArr0[j])
                    {
                        myArr0.RemoveByIndex(j);
                        toKill = true;
                    }
                }
                if (toKill == true)
                {
                    myArr0.RemoveByIndex(i);
                }
            }
            ////////////////////////////////////////////////////////////////
            MyArray<int> myArr0Unic = new MyArray<int>();
            for (var i = 0; i < myArr0.Length; i++) // save arr0 unic
            {
                myArr0Unic.AddValue(myArr0[i]);
            }
            ////////////////////////////////////////////////////////////////
            myArr0 = myArr0Memo; // load arr0 memo















            ////////////////////////////////////////////////////////////////
            MyArray<int> myArr1Memo = new MyArray<int>(); // save arr1
            for (var i = 0; i < myArr1.Length; i++)
            {
                myArr1Memo.AddValue(myArr1[i]);
            }
            ////////////////////////////////////////////////////////////////
            for (var i = 0; i < myArr1.Length; i++) // del arr1 reps
            {
                var toKill = false;
                for (var j = i + 1; j < myArr1.Length; j++)
                {
                    if (myArr1[i] == myArr1[j])
                    {
                        myArr1.RemoveByIndex(j);
                        toKill = true;
                    }
                }
                if (toKill == true)
                {
                    myArr1.RemoveByIndex(i);
                }
            }
            ////////////////////////////////////////////////////////////////
            MyArray<int> myArr1Unic = new MyArray<int>();
            for (var i = 0; i < myArr1.Length; i++) // save arr1 unic
            {
                myArr1Unic.AddValue(myArr1[i]);
            }
            ////////////////////////////////////////////////////////////////
            myArr1 = myArr1Memo; // load arr0 memo


























        }
    }
}
