using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Calculator
{
    internal class Program
    {

        static string[] options = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
        static int a, b;

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator:\n");
            for (int i = 0; i < options.Length; i++) Console.WriteLine("{0}. {1}", i + 1, options[i]);

            Console.Write("\nInput nomor menu [1..{0}]: ", options.Length);
            int optionSelected = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (optionSelected)
            {
                case 1:
                    InputValues();
                    ShowResult(options[optionSelected - 1], '+', a, b, SimpleCalculate(a, b, '+'));
                    break;
                case 2:
                    InputValues();
                    ShowResult(options[optionSelected - 1], '-', a, b, SimpleCalculate(a, b, '-'));
                    break;
                case 3:
                    InputValues();
                    ShowResult(options[optionSelected - 1], '*', a, b, SimpleCalculate(a, b, '*'));
                    break;
                case 4:
                    InputValues();
                    if (b == 0) Console.WriteLine("\nBilangan tidak bisa dengan angka 0");
                    else ShowResult(options[optionSelected - 1], '/', a, b, SimpleCalculate(a, b, '/'));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static void InputValues()
        {
            Console.Write("Inputkan nilai a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            b = int.Parse(Console.ReadLine());
        }

        static int SimpleCalculate(int a, int b, char calcType)
        {
            int result = 0;

            if (calcType == '+') result = a + b;
            else if (calcType == '-') result = a - b;
            else if (calcType == '*') result = a * b;
            else if (calcType == '/') result = a / b;

            return result;
        }

        static void ShowResult(string type, char operator_type, int a, int b, int result)
        {
            Console.WriteLine("\nHasil {0} {1} {2} {3} = {4}", type, a, operator_type, b, result);
        }
    }
}