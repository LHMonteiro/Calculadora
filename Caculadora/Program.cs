using System;
using System.ComponentModel.Design;

namespace Caculadora // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public static double valor1, valor2;
        static void Main()
        {    

            Menu();

        }

        public static void Menu()
        {
            Console.WriteLine("opção 1 - +");
            Console.WriteLine("opção 2 - -");
            Console.WriteLine("opção 3 - *");
            Console.WriteLine("opção 4 - /");

            string operação = Console.ReadLine();


            switch (operação)
            {
                case "1":
                    Soma();
                    break;
                case "2":
                    Subitrair();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
            }
        }

        public static void Soma()
        {   
            
            Console.WriteLine("digite o numero 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o numero 2: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a resposta é {valor1+valor2}");
        }

        public static void Multiplicar()
        {
            Console.WriteLine("digite o numero 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o numero 2: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"a resposta é {valor1*valor2}");
        }

        public static void Dividir()
        {
            Console.WriteLine("digite o numero 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o numero 2: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            if(valor2 == 0){
                Console.WriteLine("não pode haver divição por zero");
            } else{
                Console.WriteLine($"o resultado é: {valor1/valor2}");
            }
        }

        public static void Subitrair()
        {
            Console.WriteLine("digite o numero 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o numero 2: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"a resposta é {valor1-valor2}");
        }


    }
}
