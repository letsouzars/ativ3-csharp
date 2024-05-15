using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        string nome;
                        Console.WriteLine("Qual seu nome?");
                        nome = Console.ReadLine();
                        Consol"e.WriteLine(nome);*/
            /* int idade;
             Console.WriteLine("Qual é a sua idade");
             idade = int.Parse(Console.ReadLine());
             Console.WriteLine(idade);*/

            /*float altura;
            double salario;
            Console.WriteLine("Qual a sua altura?");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salario?");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura é: " + altura + " e voce ganha " + salario);*/

            /*double n1 = double.Parse(Console.ReadLine());
            double n2;
            n2 = double.Parse(Console.ReadLine());
            double total = n1 / n2;
            Console.WriteLine(total.ToString("F3"));*/

            /*   Console.WriteLine("Digite um número: ");
               int numero = int.Parse(Console.ReadLine());

               if(numero > 0 && numero < 100)
               {
                   Console.WriteLine("O numero é maior que  0 menor que 100");
               }*/









            /* lista 3.5
            #1*/
            /*        Console.WriteLine("Informe o login:");
                    string login = Console.ReadLine();
                    Console.WriteLine("Informe a senha:");
                    string senha = Console.ReadLine();
                    if (login == "admin" && senha == "1234")
                    {
                        Console.WriteLine("pode acessar");
                    }
                    else
                    {
                        Console.WriteLine("login ou senha incorreto");
                    }
        */


            /*#2*/


            /*   Console.WriteLine("Informe a quantidade de blusas em estoque:");
               int quantidadeBlusas = int.Parse(Console.ReadLine());
               if (quantidadeBlusas > 40){
                   Console.WriteLine("ESTOQUE OK");
               }
               else if (quantidadeBlusas > 20 && quantidadeBlusas <= 40){
                   Console.WriteLine("ATENÇÃO AO ESTOQUE");
               }
               else{
                   Console.WriteLine("ESTOQUE CRITICO");
               }
   */


            /*#3*/
            /* Console.WriteLine("Informe sua idade:");
             int idade = int.Parse(Console.ReadLine());
             Console.WriteLine("Informe seu salário (em R$):");
             double salario = double.Parse(Console.ReadLine());
             if (idade >= 18 && salario > 2000) {
                 Console.WriteLine("PODE VIAJAR");
             }
             else
             {
                 Console.WriteLine("NÃO PODE VIAJAR");
             }*/


            /*#4*/
            /*   Console.WriteLine("Escolha uma opção de aula (digite o número correspondente):");
               int escolha = int.Parse(Console.ReadLine());
               if (escolha == 1 || escolha == 2)
               {
                   Console.WriteLine("DESENHO E PINTURA");
               }
               else if (escolha == 3 || escolha == 4)
               {
                   Console.WriteLine("DISCURSO E DEBATE");
               }
               else
               {
                   Console.WriteLine("DANÇA");
               }*/



            /*#5*/

            /*    Console.WriteLine("Digite um número:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0 && numero > 100)
                {
                    Console.WriteLine("número especial");
                }
                else
                {
                    Console.WriteLine("fora do intervalo");
                }*/


            /*lista 4*/


            /*1*/
            /* Console.WriteLine("digite o número do funcionário:");
             int numeroFuncionario = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o número de horas trabalhadas:");
             int horasTrabalhadas = int.Parse(Console.ReadLine());
             Console.WriteLine("digite o valor recebido por hora (em R$):");
             double valorPorHora = double.Parse(Console.ReadLine());
             double salario = horasTrabalhadas * valorPorHora;
             Console.WriteLine("número do funcionário: " + numeroFuncionario);
             Console.WriteLine("salário do funcionário: R$" + salario);*/

            /*2*/


            /*Console.WriteLine("Informe o código da peça 1:");
            int codigoPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de peças 1:");
            int numeroPecas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 1:");
            double valorUnitario1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código da peça 2:");
            int codigoPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de peças 2:");
            int numeroPecas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 2:");
            double valorUnitario2 = double.Parse(Console.ReadLine());
            double totalPeca1 = numeroPecas1 * valorUnitario1;
            double totalPeca2 = numeroPecas2 * valorUnitario2;
            double valorTotal = totalPeca1 + totalPeca2;
            Console.WriteLine("VALOR A PAGAR: R$" + valorTotal.ToString("F2"));*/


            /*3*/
/*
            Console.WriteLine("Informe o valor de A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C:");
            double C = double.Parse(Console.ReadLine());

            //área do triângulo retângulo
            double areaTriangulo = A * C / 2.0;
            Console.WriteLine("Área do triângulo retângulo: " + areaTriangulo);

            //área do círculo
            double areaCirculo = 3.14159 * C * C;
            Console.WriteLine("Área do círculo: " + areaCirculo);

            //área do trapézio
            double areaTrapezio = (A + B) / 2.0 * C;
            Console.WriteLine("Área do trapézio: " + areaTrapezio);

            // área do quadrado
            double areaQuadrado = B * B;
            Console.WriteLine("Área do quadrado: " + areaQuadrado);

            // área do retângulo
            double areaRetangulo = A * B;
            Console.WriteLine("Área do retângulo: " + areaRetangulo);*/





























        }
    }
}
