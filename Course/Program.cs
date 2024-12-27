using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Quantos contribuites você vai digitar? ");
            int taxPayerQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= taxPayerQuantity; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Digite os dados do {i}º contribuite:");
                Console.Write("Renda anual com salário: ");
                double salaryIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Renda anual com prestação de serviços: ");
                double servicesIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Renda anual com ganho de capital: ");
                double capitalIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Gastos médicos: ");
                double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Gastos educacionais: ");
                double educationSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new TaxPayer(salaryIncome, servicesIncome, capitalIncome, healthSpending, educationSpending));
            }

            for (int i = 0; i < taxPayerQuantity; i++)
            {
                
                Console.WriteLine();
                Console.WriteLine($"Resumo do {i + 1}º contribuinte:");
                Console.WriteLine(list[i]);
            }
        }
    }
}
