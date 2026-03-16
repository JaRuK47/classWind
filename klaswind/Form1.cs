namespace klaswind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var measureItems = new string[]
        {
            "c.c. 2",
            "c.c. 8",
            "c.c. 10",
            "c.c. 16",
        };

            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "c.c. 2":
                    measureType = MeasureType.n2;
                    break;
                case "c.c. 8":
                    measureType = MeasureType.n8;
                    break;
                case "c.c. 10":
                    measureType = MeasureType.n10;
                    break;
                case "c.c. 16":
                    measureType = MeasureType.n16;
                    break;
                default:
                    measureType = MeasureType.n10;
                    break;
            }
            return measureType;
        }

        private void Calculate()
        {
            try
            {
                var firstValue = int.Parse(txtFirst.Text);
                var secondValue = int.Parse(txtSecond.Text);

                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);

                var firstNS = new NumberSystem(firstValue, firstType);
                var secondNS = new NumberSystem(secondValue, secondType);

                NumberSystem sumLength;

                switch (cmbOperation.Text)
                {
                    case "+":
                        sumLength = firstNS + secondNS;
                        break;
                    case "-":
                        sumLength = firstNS - secondNS;
                        break;
                    case "*":
                        sumLength = firstNS * secondNS;
                        break;
                    case "/":
                        sumLength = firstNS / secondNS;
                        break;
                    default:
                        sumLength = new NumberSystem(0, MeasureType.n10);
                        break;
                }

                txtResult.Text = sumLength.Verbose();
            }
            catch (FormatException)
            {
            }
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
