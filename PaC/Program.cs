using System;
using PaC.src.Entities;

namespace PaC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Dicas e coisas importantes:
                - lembra de colocar um gitignore no projeto. Ele ajuda a reduzir o upload e retira uns arquivo meio inútil como arquivos de compilação
                - tem alguns trechos de codigo repetidos propositalmente
            */
            CalcOriginal();
            // CalcComConstrutor();
            // CalcComProps();
        }

        static void Apresentar()
        {
            Console.WriteLine("Olá, seja bem-vindo ao Programa de Auxílio de Cálculo, iriei te ajudar a calcular seus gastos mensais!");
            Console.WriteLine("Vamos lá?!!");
            Console.WriteLine("-----------------------------------------------------");
        }

        static void CalcOriginal()
        {
            Calc newCalc = new Calc();
            Apresentar();
            Console.WriteLine(newCalc.CalcOp());
        }
        
        // aqui é usado algo conhecido como tuple 
        // dá para retornar mais de um tipo de dados com isso
        static (double, int) SolicitarDados() 
        {
            Console.WriteLine("Insira o valor do seu salário mensal: ");
            double.TryParse(Console.ReadLine(), out double Wage);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Insira a quantidade de contas mensais que você possui: ");
            int.TryParse(Console.ReadLine(), out int Accounts);
            Console.WriteLine("-----------------------------------------------------");
            return (Wage, Accounts); // tuple literal
        }

        static void CalcComConstrutor()
        {
            Apresentar();
            
            var data = SolicitarDados();
            // data.Item1 = Wage
            // data.Item2 = Accounts
            CalcContrutor C = new CalcContrutor(data.Item1, data.Item2);
            C.SolicitarDados();
            // essa linha não é necessária, ela só foi usada para entender melhor o programa
            C.Calcular(); 
            C.MostrarDados();
        }

        static void CalcComProps()
        {
            Apresentar();
            var data = SolicitarDados();
            CalcProps C = new CalcProps();
            C.Wage = data.Item1;
            C.Accounts = data.Item2;
            C.SolicitarDados();
            C.MostrarDados();
        }
    }
}