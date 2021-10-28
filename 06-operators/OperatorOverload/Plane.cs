using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    /// <summary>
    /// Самолет
    /// </summary>
    class Plane
    {
        private int _power;
        private int _maxSpeed;
        private int _countFuel;

        public Plane(int power, int maxSpeed, int countFuel)
        {
            Power = power;
            MaxSpeed = maxSpeed;
            CountFuel = countFuel;
        }

        public int Power
        {
            get => _power;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _power = value;
            }
        }
        public int MaxSpeed 
        {
            get => _maxSpeed;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _maxSpeed = value;
            }
        }
        public int CountFuel 
        {
            get => _countFuel;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _countFuel = value;
            }
        }

        public int DifferentPower(Plane anotherPlane)
        {
            return Math.Abs(Power - anotherPlane.Power);
        }

        public void SetParameters(int power, int maxSpeed, int countFuel)
        {
            Power = power;
            MaxSpeed = maxSpeed;
            CountFuel = countFuel;
        }

        public void SetParameters(int power, int countFuel)
        {
            Power = power;
            CountFuel = countFuel;
        }

        public void SetParameters(int countFuel)
        {
            CountFuel = countFuel;
        }
    }
}
