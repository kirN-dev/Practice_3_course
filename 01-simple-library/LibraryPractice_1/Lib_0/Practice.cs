using System;

namespace Lib_0
{
    /// <summary>
    /// Найти сумму n целых, четных, случайных чисел, распределенных в 
    /// диапазоне от 0 до n. Вывести на экран на одной строке 
    /// сгенерированные числа, на другой строке результат.
    /// </summary>
    public class Practice
    {
        Random random = new Random();

        /// <summary>
        /// Находит сумму n целых, четных, случайных чисел, распределенных в 
        /// диапазоне от 0 до count.
        /// </summary>
        /// <param name="count">Количество чисел и граница генарции</param>
        /// <param name="sum">Сумма четных чисел</param>
        /// <param name="numbers">Сгенерированные числа</param>
        public void SumEvenWithOut(int count, out int sum, out string numbers)
        {
            sum = 0;
            numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);
                numbers += number.ToString() + " ";
                sum += number;
            }
        }

        /// <summary>
        /// Находит сумму n целых, четных, случайных чисел, распределенных в 
        /// диапазоне от 0 до count.
        /// </summary>
        /// <param name="count">Количество чисел и граница генарции</param>
        /// <returns>Сумма четных чисел и сгенерированные числа</returns>
        public (int sum, string numbers) SumEvenWithTuple(int count)
        {
            int sum = 0;
            string numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);
                numbers += number.ToString() + " ";
                sum += number;
            }

            return (sum, numbers);
        }
    }
}
