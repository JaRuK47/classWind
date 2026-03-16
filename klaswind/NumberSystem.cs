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
            return String.Format("{0} {1}", this.value, this.type);
        }
    }
}
