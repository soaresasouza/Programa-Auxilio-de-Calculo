using System;
using PaC.src.Entities;

namespace PaC
{
    class Program
    {
        static void Main(string[] args)
        {

            Calc newCalc = new Calc();

            Console.WriteLine("Olá, seja bem-vindo ao Programa de Auxílio de Cálculo, iriei te ajudar a calcular seus gastos mensais!");
            Console.WriteLine("Vamos lá?!!");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine(newCalc.CalcOp());
        }
    }
}