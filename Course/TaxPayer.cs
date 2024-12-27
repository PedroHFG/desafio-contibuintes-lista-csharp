using System.Globalization;


namespace Course
{
    internal class TaxPayer
    {
        public double SalaryIncome { get; set; }
        public double ServicesIncome { get; set; }
        public double CapitalIncome { get; set; }
        public double HealthSpending { get; set; }
        public double EducationSpending { get; set; }

        public TaxPayer(double salaryIncome, double servicesIncome, double capitalIncome, double healthSpending, double educationSpending)
        {
            SalaryIncome = salaryIncome;
            ServicesIncome = servicesIncome;
            CapitalIncome = capitalIncome;
            HealthSpending = healthSpending;
            EducationSpending = educationSpending;
        }

        public double SalaryTax()
        {
            double salaryPerMonth = SalaryIncome / 12;
            double salaryTax;

            if (salaryPerMonth < 3000.0)
            {
                salaryTax = 0.0;
            }
            else if (salaryPerMonth < 5000.0)
            {
                salaryTax = salaryPerMonth * 0.10 * 12;
            }
            else
            {
                salaryTax = salaryPerMonth * 0.20 * 12;
            }

            return salaryTax;
        }

        public double ServicesTax()
        {
            return (ServicesIncome > 0) ? ServicesIncome * 0.15 : 0.0;
        }

        public double CapitalTax()
        {
            return (CapitalIncome > 0) ? CapitalIncome * 0.20 : 0.0;
        }

        public double GrossTax()
        {
            return SalaryTax() + ServicesTax() + CapitalTax();
        }

        public double TaxRebate()
        {
            double maxRebate = GrossTax() * 0.30;
            double totalSpent = HealthSpending + EducationSpending;
            double rebate;

            if (totalSpent < maxRebate)
            {
                rebate = totalSpent;
            }
            else
            {
                rebate = maxRebate;
            }

            return GrossTax() - rebate;
        }

        public override string? ToString()
        {
            return "Imposto bruto total: " + GrossTax().ToString("F2", CultureInfo.InvariantCulture)
                + "\nAbatimento: " + (GrossTax() - TaxRebate()).ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto devido: " + TaxRebate().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
