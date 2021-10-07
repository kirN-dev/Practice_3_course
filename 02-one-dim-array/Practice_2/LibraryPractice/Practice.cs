
namespace LibraryArray
{
    public static class Practice
    {
        public static int SumEven(this SingleDimensionalArray numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i];
            }

            return sum;
        }
    }
}
