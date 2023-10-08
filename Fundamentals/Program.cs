﻿using System;
using Microsoft.VisualBasic;

namespace Fundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nLEARNING C#\n" +
                "\nQual programa você deseja executar?\n" +
                "\n(1) Simple Calculator" +
                "\n(2) Age Calculator" +
                "\n(3) Tip Calculator" +
                "\n(4) Currency Converter" +
                "\n(5) Fish Regulation" +
                "\n(6) Swimmer Categorization" +
                "\n(7) Sales Management System" +
                "\n(8) Review Student Scores" +
                "\n(9) Choose Courses" +
                "\n(10) Palindromes" +
                "\n(11) Pay Raise" +
                "\n(12) Array Sum" +
                "\n(13) Array Functions" +
                "\n(14) Option 14" +
                "\n(15) Option 15" +
                "\n(0) Sair");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("CALCULADORA\n");
                        SimpleCalculator.run();
                        Main(args);
                        break;
                    case 2:
                        Console.WriteLine("CALCULADORA DE IDADE\n");
                        AgeCalculator.run();
                        Main(args);
                        break;
                    case 3:
                        Console.WriteLine("CALCULADORA DE GORJETAS\n");
                        TipCalculator.run();
                        Main(args);
                        break;
                    case 4:
                        Console.WriteLine("CONVERSOR DE MOEDAS\n");
                        CurrencyConverter.run();
                        Main(args);
                        break;
                    case 5:
                        Console.WriteLine("IMPOSTO SOBRE PEIXE\n");
                        FishRegulation.run();
                        Main(args);
                        break;
                    case 6:
                        Console.WriteLine("CATEGORIZADOR DE NADADORES\n");
                        SwimmerCategorization.run();
                        Main(args);
                        break;
                    case 7:
                        Console.WriteLine("SISTEMA DE GERENCIAMENTO DE VENDAS\n");
                        SalesManagement sl = new SalesManagement();
                        sl.run();
                        Main(args);
                        break;
                    case 8:
                        Console.WriteLine("ANÁLISE DE NOTAS\n");
                        ReviewScores.run();
                        Main(args);
                        break;
                    case 9:
                        Console.WriteLine("ESCOLHER CURSOS\n");
                        ChooseCourses.run();
                        Main(args);
                        break;
                    case 10:
                        Console.WriteLine("PALÍNDROMOS\n");
                        Palindromes.run();
                        Main(args);
                        break;
                    case 11:
                        Console.WriteLine("ANÁLISE DE AUMENTO DE SALÁRIO\n");
                        PayRaise.run();
                        Main(args);
                        break;
                    case 12:
                        Console.WriteLine("SOMA DE ARRAYS\n");
                        ArraySum.run();
                        Main(args);
                        break;
                    case 13:
                        Console.WriteLine("FUNÇÕES DE ARRAYS\n");
                        ArrayFunctions.run();
                        Main(args);
                        break;
                    case 14:
                        Console.WriteLine("OPÇÃO 14 - Implement your code here\n");
                        Main(args);
                        break;
                    case 15:
                        Console.WriteLine("OPÇÃO 15 - Implement your code here\n");
                        Main(args);
                        break;
                    case 0:
                        Console.WriteLine("\nPrograma finalizado.");
                        break;
                    default:
                        throw new ArgumentException("Por gentileza, informe um número inteiro dentre as opções disponíveis.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }

            //ConsoleInteraction.Strings();

        }
    }
}

