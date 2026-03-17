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
        private System.String value;
        private MeasureType type;

        public NumberSystem(System.String value, MeasureType type)
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
            return new NumberSystem(Convert.ToString(int.Parse(instance.To(MeasureType.n10).value) + number), MeasureType.n10).To(instance.type); ;
        }

        public static NumberSystem operator +(int number, NumberSystem instance)
        {
            return instance + number;
        }

        public static NumberSystem operator *(NumberSystem instance, int number)
        {
            return new NumberSystem(Convert.ToString(int.Parse(instance.To(MeasureType.n10).value) * number), MeasureType.n10).To(instance.type); ;
        }

        public static NumberSystem operator *(int number, NumberSystem instance)
        {
            return instance * number;
        }

        public static NumberSystem operator -(NumberSystem instance, int number)
        {
            return new NumberSystem(Convert.ToString(int.Parse(instance.To(MeasureType.n10).value) - number), MeasureType.n10).To(instance.type); ;
        }

        public static NumberSystem operator -(int number, NumberSystem instance)
        {
            var inDecimal = instance.To(MeasureType.n10);
            int newValue = number - int.Parse(inDecimal.value);
            var result = new NumberSystem(newValue.ToString(), MeasureType.n10);
            return result.To(instance.type);
        }

        public static NumberSystem operator /(NumberSystem instance, int number)
        {
            return new NumberSystem(Convert.ToString(int.Parse(instance.To(MeasureType.n10).value) / number), MeasureType.n10).To(instance.type); ;
        }

        public static NumberSystem operator /(int number, NumberSystem instance)
        {
            var inDecimal = instance.To(MeasureType.n10);
            int newValue = number / int.Parse(inDecimal.value);
            var result = new NumberSystem(newValue.ToString(), MeasureType.n10);
            return result.To(instance.type);
        }

        public NumberSystem To(MeasureType newType)
        {
            if (this.type == newType)
                return new NumberSystem(this.value, this.type);

            int decimalValue;

            switch (this.type)
            {
                case MeasureType.n2:
                    decimalValue = Convert.ToInt32(this.value, 2);
                    break;
                case MeasureType.n8:
                    decimalValue = Convert.ToInt32(this.value, 8);
                    break;
                case MeasureType.n16:
                    decimalValue = Convert.ToInt32(this.value, 16);
                    break;
                case MeasureType.n10:
                default:
                    decimalValue = int.Parse(this.value);
                    break;
            }

            string resultValue;

            switch (newType)
            {
                case MeasureType.n2:
                    resultValue = Convert.ToString(decimalValue, 2);
                    break;
                case MeasureType.n8:
                    resultValue = Convert.ToString(decimalValue, 8);
                    break;
                case MeasureType.n16:
                    resultValue = Convert.ToString(decimalValue, 16).ToUpper();
                    break;
                case MeasureType.n10:
                default:
                    resultValue = decimalValue.ToString();
                    break;
            }

            return new NumberSystem(resultValue, newType);
        }

        public static NumberSystem operator +(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1 + int.Parse(instance2.To(MeasureType.n10).value);
        }

        public static NumberSystem operator -(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1 - int.Parse(instance2.To(MeasureType.n10).value);
        }

        public static NumberSystem operator *(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1 * int.Parse(instance2.To(MeasureType.n10).value);
        }

        public static NumberSystem operator /(NumberSystem instance1, NumberSystem instance2)
        {
            return instance1 / int.Parse(instance2.To(MeasureType.n10).value);
        }
    }
}
