using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    /// <summary>
    /// Класс - четверка чисел
    /// </summary>
    class Quad
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public Quad(int first, int second, int third, int fourth)
        {
            First = first;
            Second = second;
            Third = third;
            Fourth = fourth;
        }
        //Свойства
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public int Fourth { get; set; }
        /// <summary>
        /// Проверяет равны ли между собой числа в четверке
        /// </summary>
        /// <returns>Результат сравнения</returns>
        public bool IsEqual()
        {
            return First == Second && Second == Third && Third == Fourth;
        }
        /// <summary>
        /// Проверяет равны ли между собой две четверки
        /// </summary>
        /// <returns>Результат сравнения</returns>
        public bool IsEqual(Quad anotherQuad)
        {
            bool isFirst = First == anotherQuad.First;
            bool isSecond = Second == anotherQuad.Second;
            bool isThird = Third == anotherQuad.Third;
            bool isFourth = Fourth == anotherQuad.Fourth;

            return isFirst == isSecond && isSecond == isThird && isThird == isFourth;
        }
        /// <summary>
        /// Складывает соответсвующие значения двух четверок
        /// </summary>
        /// <param name="anotherQuad"></param>
        /// <returns></returns>
        public Quad Add(Quad anotherQuad)
        {
            return new Quad(First + anotherQuad.First,
                            Second + anotherQuad.Second, 
                            Third + anotherQuad.Third, 
                            Fourth + anotherQuad.Fourth);
        }
        /// <summary>
        /// Сложение двух четверок
        /// </summary>
        /// <param name="quad1"></param>
        /// <param name="quad2"></param>
        /// <returns></returns>
        public static Quad operator +(Quad quad1, Quad quad2)
        {
            return new Quad(quad1.First + quad2.First,
                            quad1.Second + quad2.Second,
                            quad1.Third + quad2.Third,
                            quad1.Fourth + quad2.Fourth);
        }
        /// <summary>
        /// Сумма всех чисел четверки
        /// </summary>
        /// <returns>Сумма чисел</returns>
        private int Sum()
        {
            return First + Second + Third + Fourth;
        }
        /// <summary>
        /// Проерка суммы чесел четверки. Истина если у первой сумма бульше
        /// </summary>
        public static bool operator >(Quad quad1, Quad quad2)
        {
            return quad1.Sum() > quad2.Sum();
        }
        /// <summary>
        /// Проерка суммы чесел четверки. Истина если у первой сумма меньше
        /// </summary>
        public static bool operator <(Quad quad1, Quad quad2)
        {
            return quad1.Sum() < quad2.Sum();
        }
        /// <summary>
        /// Увелечение всех чисел на 1
        /// </summary>
        public static Quad operator ++(Quad quad)
        {
            return new Quad(quad.First++,
                            quad.Second++,
                            quad.Third++,
                            quad.Fourth++);
        }
        /// <summary>
        /// Уменьшение всех чисел на 1
        /// </summary>
        public static Quad operator --(Quad quad)
        {
            return new Quad(quad.First--,
                            quad.Second--,
                            quad.Third--,
                            quad.Fourth--);
        }
        /// <summary>
        /// Сравнение двух четверок
        /// </summary>
        public static bool operator ==(Quad quad1, Quad quad2)
        {
            return quad1.IsEqual(quad2);
        }
        /// <summary>
        /// Сравнение двух четверок
        /// </summary>
        public static bool operator !=(Quad quad1, Quad quad2)
        {
            return !(quad1 == quad2);
        }
    }
}
