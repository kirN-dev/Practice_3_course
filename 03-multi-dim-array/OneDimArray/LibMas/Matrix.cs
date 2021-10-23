using System;
using System.IO;

namespace LibMas
{
    public class Matrix
    {
        private readonly Random random = new Random();
        private int[,] _matrix;

        public Matrix(int rowCount, int columnCount)
        {
            _matrix = new int[rowCount, columnCount];
        }

        public int RowCount => _matrix.GetLength(0);
        public int ColumnCount => _matrix.GetLength(1);

        public int this[int rowIndex, int columnIndex]
        {
            get => _matrix[rowIndex, columnIndex];
            set
            {
                if (rowIndex < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                _matrix[rowIndex, columnIndex] = value;
            }
        }

        public int[,] ToMatrix() => _matrix;

        public void RandomFill(int minValue, int maxValue)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; i++)
                {
                    _matrix[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public void Clear()
        {
            RandomFill(0, 0);
        }

        public void Save(string path)
        {
            using (StreamWriter saver = new StreamWriter(path))
            {
                saver.WriteLine(RowCount);
                saver.WriteLine(ColumnCount);

                for (int i = 0; i < RowCount; i++)
                {
                    for (int j = 0; j < ColumnCount; i++)
                    {
                        saver.WriteLine(_matrix[i, j]);
                    }
                }
            }
        }

        public void Open(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException();
            }

            using (StreamReader opener = new StreamReader(path))
            {
                int rowCount = int.Parse(opener.ReadLine());
                int columnCount = int.Parse(opener.ReadLine());

                _matrix = new int[rowCount, columnCount];

                for (int i = 0; i < RowCount; i++)
                {
                    for (int j = 0; j < ColumnCount; i++)
                    {
                        _matrix[i, j] = int.Parse(opener.ReadLine());
                    }
                }
            }
        }
    }
}
