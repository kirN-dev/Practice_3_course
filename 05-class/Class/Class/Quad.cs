using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Quad
    {
        public Quad(int first, int second, int third, int fourth)
        {
            First = first;
            Second = second;
            Third = third;
            Fourth = fourth;
        }

        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public int Fourth { get; set; }

        public bool IsEqual()
        {
            return First == Second && Second == Third && Third == Fourth;
        }

        public bool IsEqual(Quad anotherQuad)
        {
            bool isFirst = First == anotherQuad.First;
            bool isSecond = Second == anotherQuad.Second;
            bool isThird = Third == anotherQuad.Third;
            bool isFourth = Fourth == anotherQuad.Fourth;

            return isFirst == isSecond && isSecond == isThird && isThird == isFourth;
        }

        public Quad Add(Quad quad)
        {
            return new Quad(First + quad.First, 
                            Second + quad.Second, 
                            Third + quad.Third, 
                            Fourth + quad.Fourth);
        }

    }
}
