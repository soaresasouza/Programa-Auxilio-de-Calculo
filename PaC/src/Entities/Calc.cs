namespace PaC.src.Entities
{
    public class Calc
    {
        public double CalcOp()
        {

            Console.WriteLine("Insira o valor do seu salário mensal: ");
            double.TryParse(Console.ReadLine(), out double Wage);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Insira a quantidade de contas mensais que você possui: ");
            double.TryParse(Console.ReadLine(), out double Accounts);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Insira o valor total das suas contas mensais: ");
            double.TryParse(Console.ReadLine(), out double TotalAccounts);
            Console.WriteLine("-----------------------------------------------------");

            double Balance = Wage - TotalAccounts;

            if (Wage  > TotalAccounts)
            {
                Console.WriteLine($"Você possui {Accounts} contas mensais no valor total de R${TotalAccounts}.");
                Console.WriteLine("Seu saldo está positivo e será exibido abaixo: ");
            }
            else
            {
                Console.WriteLine($"Você possui {Accounts} contas mensais no valor total de R${TotalAccounts}.");
                Console.WriteLine("Seu saldo está negativo e será exibido abaixo: ");
            }

            return Balance;
        }
    }
}