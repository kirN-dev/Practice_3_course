using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryArray
{
    public class SingleDimensionalArray
    {
        private readonly Random _random = new Random();
        private readonly SaveSystem _saveSystem = new SaveSystem();
        private readonly string _defaultExtension = "array";
        private int[] _array;

        public SingleDimensionalArray(int length)
        {
            _array = new int[length];
            Extension = _defaultExtension;
        }

        public SingleDimensionalArray(int length, string extension)
        {
            _array = new int[length];
            Extension = extension;
        }

        public int Length => _array.Length;
        public string Extension { get; }

        public int this[int index]
        {
            get
            {
                if (IsOutOfRange(index))
                {
                    throw new IndexOutOfRangeException();
                }

                return _array[index];
            }
            set
            {
                if (IsOutOfRange(index))
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }

        private bool IsOutOfRange(int index)
        {
            return index < 0 || index >= Length;
        }
        public int[] ToArray() => _array;

        public void Initialize(int min = 1, int max = 10)
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _random.Next(min, max);
            }
        }

        public void Clear()
        {
            Initialize(0, 0);
        }

        public void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(Length);

                for (int i = 0; i < Length; i++)
                {
                    writer.WriteLine(_array[i]);
                }
            }
        }

        public void Open(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException();
            }

            using (StreamReader reader = new StreamReader(path))
            {
                _array = new int[int.Parse(reader.ReadLine())];

                for (int i = 0; i < Length; i++)
                {
                    _array[i] = int.Parse(reader.ReadLine());
                }
            }
        }

        #region Сеарилизация в файл

        public void Serialize(string path)
        {
            _saveSystem.Save(_array, path);
        }

        public void Deserialize(string path)
        {
            _saveSystem.Open(path);
        }
        #endregion
    }
}
