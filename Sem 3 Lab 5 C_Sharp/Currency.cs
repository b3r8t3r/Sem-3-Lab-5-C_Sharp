using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_3_Lab_5_C_Sharp
{
    abstract class Currency
    {
        abstract public void Convert();
        abstract public double GetBack();

        abstract public void Print();
    }

    class Dollar : Currency
    {
        private double value;

        public Dollar()
        {
            value = 0;
        }

        public Dollar(double _value)
        {
            value = _value;
        }
        public override void Convert()
        {
            value /= 0.013655;
        }

        public override double GetBack()
        {
            return value;
        }

        public override void Print()
        {
            Console.WriteLine(value);
        }
    }

    class Euro : Currency
    {
        private double value;

        public Euro()
        {
            value = 0;
        }

        public Euro(double _value)
        {
            value = _value;
        }
        public override void Convert()
        {
            value /= 0.012057;
        }

        public override double GetBack()
        {
            return value;
        }

        public override void Print()
        {
            Console.WriteLine(value);
        }
    }
}
