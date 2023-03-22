using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
     //(exercicío 1)
     //int laranjasCompradas;
     //double valorTotal;

//Console.Write("Digite o número de laranjas compradas: ");
//laranjasCompradas = Convert.ToInt32(Console.ReadLine());

//if (laranjasCompradas < 12)
//{
//    valorTotal = laranjasCompradas * 0.35;
//}
//else
//{
//    valorTotal = laranjasCompradas * 0.28;
//}

//Console.WriteLine("O valor total da compra é: R$ {0}", valorTotal);

//exercício 2

//int anoNascimento, idade;

//Console.Write("Digite o ano de nascimento: ");
//anoNascimento = int.Parse(Console.ReadLine());

//idade = DateTime.Now.Year - anoNascimento;

//if (idade >= 16)
//{
//    Console.WriteLine("Você poderá votar nas próximas eleições.");
//}
//else
//{
//    Console.WriteLine("Você ainda não poderá votar nas próximas eleições.");
//}

//exercício 3

//double ladoA, ladoB, ladoC;

//Console.Write("Digite o valor do primeiro lado: ");
//ladoA = double.Parse(Console.ReadLine());

//Console.Write("Digite o valor do segundo lado: ");
//ladoB = double.Parse(Console.ReadLine());

//Console.Write("Digite o valor do terceiro lado: ");
//ladoC = double.Parse(Console.ReadLine());

//if (ladoA == ladoB && ladoB == ladoC)
//{
//    Console.WriteLine("O triângulo é equilátero.");
//}
//else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
//{
//    Console.WriteLine("O triângulo é isósceles.");
//}
//else
//{
//    Console.WriteLine("O triângulo é escaleno.");
//}

//exercício 4

//double a, b, c, delta, x1, x2;

//Console.Write("Digite o valor de A: ");
//a = double.Parse(Console.ReadLine());

//Console.Write("Digite o valor de B: ");
//b = double.Parse(Console.ReadLine());

//Console.Write("Digite o valor de C: ");
//c = double.Parse(Console.ReadLine());

//delta = Math.Pow(b, 2) - 4 * a * c;

//if (delta < 0)
//{
//    Console.WriteLine("A equação não possui raízes reais.");
//}
//else if (delta == 0)
//{
//    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//    Console.WriteLine("A equação possui uma raiz real: {0}", x1);
//}
//else
//{
//    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//    Console.WriteLine("A equação possui duas raízes reais: {0} e {1}", x1, x2);
//}

//exercício 5

//Console.Write("Digite um número inteiro: ");
//int numero = int.Parse(Console.ReadLine());

//if (numero % 3 == 0 && numero % 5 == 0)
//{
//    Console.WriteLine("O número é divisível por 3 e por 5");
//}
//else if (numero % 3 == 0)
//{
//    Console.WriteLine("O número é divisível por 3");
//}
//else if (numero % 5 == 0)
//{
//    Console.WriteLine("O número é divisível por 5");
//}
//else
//{
//    Console.WriteLine("O número não é divisível por 3 nem por 5");
//}

//exercío 6

//int angulo1, angulo2, angulo3;

//Console.WriteLine("Digite o valor do primeiro ângulo do triângulo:");
//angulo1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do segundo ângulo do triângulo:");
//angulo2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o valor do terceiro ângulo do triângulo:");
//angulo3 = int.Parse(Console.ReadLine());

//if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
//{
//    Console.WriteLine("O triângulo é retângulo.");
//}
//else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
//{
//    Console.WriteLine("O triângulo é obtusângulo.");
//}
//else
//{
//    Console.WriteLine("O triângulo é acutângulo.");
//}

//xercício 7
// Lê os 3 valores inteiros
//Console.Writeline("Digite o primeiro valor: ");
//int valor1 = int.Parse(Console.ReadLine());

//Console.Writeline("Digite o segundo valor: ");
//int valor2 = int.Parse(Console.ReadLine());

//Console.Writeline("Digite o terceiro valor: ");
//int valor3 = int.Parse(Console.ReadLine());

//// Ordena os valores em ordem crescente
//if (valor1 > valor2)
//{
//    int aux = valor1;
//    valor1 = valor2;
//    valor2 = aux;
//}

//if (valor1 > valor3)
//{
//    int aux = valor1;
//    valor1 = valor3;
//    valor3 = aux;
//}

//if (valor2 > valor3)
//{
//    int aux = valor2;
//    valor2 = valor3;
//    valor3 = aux;
//}

// Exibe os valores em ordem crescente
//Console.WriteLine("Valores em ordem crescente: " + valor1 + ", " + valor2 + ", " + valor3);

//exercício 8
//using System;

//        class Program {
//static void Main(string[] args) {
//    Console.WriteLine("Digite um ano:");
//    int ano = int.Parse(Console.ReadLine());

//    if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) {
//        Console.WriteLine("{0} é um ano bissexto.", ano);
//    } else {
//        Console.WriteLine("{0} não é um ano bissexto.", ano);
//    }

//exercício 9
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Digite o primeiro número:");
//        double num1 = double.Parse(Console.ReadLine());

//        Console.WriteLine("Digite o segundo número:");
//        double num2 = double.Parse(Console.ReadLine());

//        Console.WriteLine("Digite a operação (+, -, * ou /):");
//        char operacao = char.Parse(Console.ReadLine());

//        double resultado = 0;

//        switch (operacao)
//        {
//            case '+':
//                resultado = num1 + num2;
//                break;
//            case '-':
//                resultado = num1 - num2;
//                break;
//            case '*':
//                resultado = num1 * num2;
//                break;
//            case '/':
//                resultado = num1 / num2;
//                break;
//            default:
//                Console.WriteLine("Operação inválida.");
//                return;
//        }

//        Console.WriteLine("O resultado da operação é: {0}", resultado);
//    }


// exercício 10

//importante lembrar que a classe Random utiliza um algoritmo para gerar números aleatórios baseados em um valor inicial, chamado de semente. Se a semente não for alterada, os números gerados serão sempre os mesmos. Por isso, é recomendado que a semente seja alterada antes de gerar números aleatórios, para garantir que os resultados sejam realmente aleatórios. Isso pode ser feito passando um valor inteiro como parâmetro para o construtor da classe Random. Caso não seja necessário controlar a semente, pode-se utilizar o construtor padrão da classe Random, que utiliza o relógio do sistema como semente.

//Random random = new Random();
//int numeroAleatorio = random.Next(1, 11);
//Random random = new Random();
//double numeroAleatorio = random.NextDouble();
//}
//   
//

