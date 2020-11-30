using System.Globalization;
using System.Text;

namespace AluguelDeCarros.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basice payment: ");
            sb.Append(BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("\nTax: ");
            sb.Append(Tax.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("\nTotal Payment: ");
            sb.Append(TotalPayment.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
