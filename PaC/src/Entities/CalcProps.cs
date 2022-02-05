using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaC.src.Interfaces;

namespace PaC.src.Entities
{
    public class CalcProps : ICalc
    {
        private int accounts = 0;
        private double wage = 0;

        // Com props é possível fazer uma verificação dos dados
        public int Accounts 
        { 
            get => accounts; 
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Valor Invalido");
                    return;
                }
                accounts = value;
            } 
        }
        public double Wage 
        { 
            get => wage; 
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Valor Invalido");
                    return;
                }
                wage = value;
            } 
        }
        public double TotalAccounts { get; private set; }


        // esse é uma forma mais rápida de escrever funções de uma linha
        public double Calcular() => Wage - TotalAccounts;

        public void MostrarDados()
        {
            Console.WriteLine($"Você possui {Accounts} contas mensais no valor total de {TotalAccounts.ToString("C")}.");
            // aqui eu uso o operador ? que funciona como um if basicamente
            Console.WriteLine($"Seu saldo está {(Calcular() > 0 ? "positivo": "negativo")} e será exibido abaixo: ");
            // ToString("C") converte o valor para currency
            Console.WriteLine($"{Calcular().ToString("C")}");
        }

        public void SolicitarDados()
        {
            // criando uma variavel temporaria p receber o valor
            double temp = 0;
            for(int i = 0; i < Accounts; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° conta:");
                // esse metodo sobrescreve qualquer valor que tinha na var
                // não é possível usar props no out
                Double.TryParse(Console.ReadLine(), out temp); 
                // aqui recebe o input
                TotalAccounts += temp;
            }
        }

    }
}