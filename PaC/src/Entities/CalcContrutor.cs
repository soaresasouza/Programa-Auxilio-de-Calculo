using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaC.src.Interfaces;

namespace PaC.src.Entities
{
    public class CalcContrutor: ICalc
    {
        private double wage = 0;
        private int accounts = 0;
        // Para esse programa eu entendi que cada conta pode ter um valor diferente 
        private double totalAccounts = 0;

        public CalcContrutor(double wage, int accounts)
        {
            this.wage = wage;
            this.accounts = accounts;
        }
        // esse é uma forma mais rápida de escrever funções de uma linha
        public double Calcular() => wage - totalAccounts;

        public void MostrarDados()
        {
            Console.WriteLine($"Você possui {accounts} contas mensais no valor total de {totalAccounts.ToString("C")}.");
            var saldo = Calcular();
            // aqui eu uso o operador ? que funciona como um if basicamente
            Console.WriteLine($"Seu saldo está {(saldo > 0 ? "positivo": "negativo")} e será exibido abaixo: ");
            // ToString("C") converte o valor para currency
            Console.WriteLine($"{saldo.ToString("C")}");

        }
        public void SolicitarDados()
        {
            // criando uma variavel temporaria p receber o valor
            double temp = 0;
            for(int i = 0; i < accounts; i++)
            {
                Console.WriteLine($"Digite o valor da {i + 1}° conta: ");
                // esse metodo sobrescreve qualquer valor que tinha na var
                Double.TryParse(Console.ReadLine(), out temp); 
                // aqui recebe o input
                totalAccounts += temp;
            }
        }
    }
}