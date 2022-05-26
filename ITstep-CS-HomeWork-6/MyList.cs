namespace ITstep_CS_HomeWork_6
{
    internal class MyArray<T>
    {
        private T[] _mainArray = new T[0];
        public int Length
        {
            get
            {
                return _mainArray.Length;
            }
        }
        public void AddValue(T value)
        {
            T[] tempArr = new T[_mainArray.Length + 1];
            for (var i = 0; i < _mainArray.Length; i++)
            {
                tempArr[i] = _mainArray[i];
            }
            tempArr[tempArr.Length - 1] = value;
            _mainArray = tempArr;
        }
        public void InsertValue(int index, T value)
        {
            if (index < _mainArray.Length)
            {
                T[] tempArr = new T[_mainArray.Length + 1];
                var j = 0;
                for (var i = 0; i < _mainArray.Length; i++)
                {
                    if (i == index)
                    {
                        tempArr[j] = value;
                        j++;
                    }
                    tempArr[j] = _mainArray[i];
                    j++;
                }
                _mainArray = tempArr;
            }
            else
            {
                System.Console.Write("Index out of range!");
                System.Console.ReadKey(true);
                System.Console.WriteLine();
            }
        }
        public void UpdateValue(int index, T value)
        {
            if (index < _mainArray.Length)
            {
                for (var i = 0; i < _mainArray.Length; i++)
                {
                    if (i == index)
                    {
                        _mainArray[i] = value;
                    }
                }
            }
            else
            {
                System.Console.Write("Index out of range!");
                System.Console.ReadKey(true);
                System.Console.WriteLine();
            }
        }
    }
}
