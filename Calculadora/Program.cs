using System;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Calculadora
{
    class Programa
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora em C#\n");
            Console.WriteLine("Informe a operação que você deseja realizar:\n\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair\n");
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Substracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("### Calculadora em C# ###\n\nInforme o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float soma = primeiroNumero + segundoNumero;
            Console.WriteLine($"\nO resultado da soma de {primeiroNumero} e {segundoNumero} é: {soma}");
            Console.ReadKey();
            Menu();
        }

        static void Substracao()
        {
            Console.Clear();

            Console.WriteLine("### Calculadora em C# ###\n\nInforme o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float subtracao = primeiroNumero - segundoNumero;

            Console.WriteLine($"O resultado da subtração de {primeiroNumero} e {segundoNumero} é: {subtracao}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("### Calculadora em C# ###\n\nInforme o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float divisao = primeiroNumero / segundoNumero;

            Console.WriteLine($"O resultado da divisao de {primeiroNumero} e {segundoNumero} é: {divisao}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("### Calculadora em C# ###\n\nInforme o primeiro número: ");
            float primeiroNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            float segundoNumero = float.Parse(Console.ReadLine());

            float multiplicacao = primeiroNumero * segundoNumero;

            Console.WriteLine($"O resultado da multiplicação de {primeiroNumero} e {segundoNumero} é: {multiplicacao}");
            Console.ReadKey();

            Menu();
        }
    }
}
