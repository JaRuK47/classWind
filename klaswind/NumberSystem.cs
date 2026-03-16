using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace klaswind
{
    public enum MeasureType { n2, n8, n10, n16 };
    public class NumberSystem
    {
        private int value;
        private MeasureType type;

        public NumberSystem(int value, MeasureType type)
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
            return System.String.Format("{0} {1}", this.value, typeVerbose);
        }

        public static NumberSystem operator +(NumberSystem instance, int number)
        {
            return new NumberSystem(instance.value + number, instance.type); ;
        }

        public static NumberSystem operator +(int number, NumberSystem instance)
        {
            return instance + number;
        }

        public static NumberSystem operator *(NumberSystem instance, int number)
        {
            return new NumberSystem(instance.value * number, instance.type); ;
        }

        public static NumberSystem operator *(int number, NumberSystem instance)
        {
            return instance * number;
        }

        public static NumberSystem operator -(NumberSystem instance, int number)
        {
            return new NumberSystem(instance.value - number, instance.type); ;
        }

        public static NumberSystem operator -(int number, NumberSystem instance)
        {
            return instance - number;
        }

        public static NumberSystem operator /(NumberSystem instance, int number)
        {
            return new NumberSystem(instance.value / number, instance.type); ;
        }

        public static NumberSystem operator /(int number, NumberSystem instance)
        {
            return instance / number;
        }

        public NumberSystem To(MeasureType newType)
        {
            var newValue = this.value;
            if (this.type == MeasureType.n2)
            {
                newValue = Convert.ToInt32(this.value.ToString(), 2);
            }
            if (this.type == MeasureType.n8)
            {
                newValue = Convert.ToInt32(this.value.ToString(), 8);
            }
            if (this.type == MeasureType.n16)
            {
                newValue = Convert.ToInt32(this.value.ToString(), 16);
            }

            switch (newType)
            {
                case MeasureType.n2:
                    newValue = int.Parse(Convert.ToString(newValue, 2));
                    break;
                case MeasureType.n8:
                    newValue = int.Parse(Convert.ToString(newValue, 8));
                    break;
                case MeasureType.n16:
                    newValue = int.Parse(Convert.ToString(newValue, 16));
                    break;
            }
            return new NumberSystem(newValue, newType);
        }

        public static NumberSystem operator +(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1.To(MeasureType.n10) + instance2.To(MeasureType.n10).value;
        }

        public static NumberSystem operator -(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1.To(MeasureType.n10) - instance2.To(MeasureType.n10).value;
        }

        public static NumberSystem operator *(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1.To(MeasureType.n10) * instance2.To(MeasureType.n10).value;
        }

        public static NumberSystem operator /(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1.To(MeasureType.n10) / instance2.To(MeasureType.n10).value;
        }
    }
}
