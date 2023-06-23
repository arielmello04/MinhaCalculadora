using System;

namespace Calculadora
{ 
    class Program 
    { 
        static void Main(String[] args)
        {
            Menu();
          
            Console.ReadLine();
        }

        static void Menu()
        {
            Console.WriteLine("Bem vindo, o que deseja fazer?");
            Console.WriteLine("======================");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação" );
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("======================");
            Console.WriteLine("Selecione uma das opções!");

            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default:Menu(); break;

            }

            /*if(res == 1)
            {
                Console.WriteLine("Você escolheu soma...");
                Soma();
            }else if (res == 2){
                Console.WriteLine("Você escolheu subtração...");
                Soma();
            }else if (res == 3){
                Console.WriteLine("Você escolheu multiplicação...");
                Soma();
            }else if (res == 4){
                Console.WriteLine("Você escolheu divisão...");
                Soma();
            }*/

        }

        static void Soma()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadLine();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadLine();

            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadLine();

            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadLine();

            Menu();
        }

    }


}

