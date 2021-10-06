using System;
using System.IO;

namespace LibMas
{
    public class Array
    {
        private readonly Random random = new Random();
        private int[] _array;

        public Array(int count)
        {
            Length = count;
            _array = new int[count];
        }

        public int Length { get; private set; }

        public int this[int index]
        {
            get => _array[index];
            set 
            {
                if(index > Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }

        public void RandomFill(int minValue, int maxValue)
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = random.Next(minValue, maxValue);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = default;
            }
        }

        public void Save(string path)
        {
            using (StreamWriter saver = new StreamWriter(path))
            {
                saver.WriteLine(Length);

                for (int i = 0; i < Length; i++)
                {
                    saver.WriteLine(_array[i]);
                }
            }
        }

        public void Open(string path)
        {
            using (StreamReader opener = new StreamReader(path))
            {
                Length = int.Parse(opener.ReadLine());
                _array = new int[Length];

                for (int i = 0; i < Length; i++)
                {
                    _array[i] = int.Parse(opener.ReadLine());
                }
            }
        }
    }
}
