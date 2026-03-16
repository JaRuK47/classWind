using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaswind
{
    public enum MeasureType { n2, n8, n10, n16 };
    public class NumberSystem
    {
        private double value;
        private MeasureType type;

        public NumberSystem(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }

        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.n2:
                    typeVerbose = "с.с. 2";
                    break;
                case MeasureType.n8:
                    typeVerbose = "с.с. 8";
                    break;
                case MeasureType.n10:
                    typeVerbose = "с.с. 10";
                    break;
                case MeasureType.n16:
                    typeVerbose = "с.с. 16";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }

        public static NumberSystem operator +(NumberSystem instance, double number)
        {
            return new NumberSystem(instance.value + number, instance.type); ;
        }

        public static NumberSystem operator +(double number, NumberSystem instance)
        {
            return instance + number;
        }

        public static NumberSystem operator *(NumberSystem instance, double number)
        {
            return new NumberSystem(instance.value * number, instance.type); ;
        }

        public static NumberSystem operator *(double number, NumberSystem instance)
        {
            return instance * number;
        }

        public static NumberSystem operator -(NumberSystem instance, double number)
        {
            return new NumberSystem(instance.value - number, instance.type); ;
        }

        public static NumberSystem operator -(double number, NumberSystem instance)
        {
            return instance - number;
        }

        public static NumberSystem operator /(NumberSystem instance, double number)
        {
            return new NumberSystem(instance.value / number, instance.type); ;
        }

        public static NumberSystem operator /(double number, NumberSystem instance)
        {
            return instance / number;
        }

        public NumberSystem To(MeasureType newType)
        {
            var newValue = this.value;
            if (this.type == MeasureType.n10)
            {
                switch (newType)
                {
                    case MeasureType.n10:
                        newValue = this.value;
                        break;
                    case MeasureType.n2:
                        newValue = this.value / 1000;
                        break;
                    // если в  а.е.
                    case MeasureType.n8:
                        newValue = this.value / 149597870700;
                        break;
                    // если в парсек
                    case MeasureType.n16:
                        newValue = this.value / (3.0856776 * Math.Pow(10, 16));
                        break;
                }
            }
            return new NumberSystem(newValue, newType);
        }
    }
}
