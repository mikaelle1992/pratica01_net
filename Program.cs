using System;

class Program
{
    static void Main()
    {
       //questão 03
        double numeroDouble = 7.99;
        int numeroInteiro = (int)numeroDouble;

        Console.WriteLine($"Número Double: {numeroDouble}");
        Console.WriteLine($"Número Inteiro (após conversão): {numeroInteiro}");


        //questão 04
        int x = 10;
        int y = 3;


        int soma = x + y;
        Console.WriteLine($"Adição: {x} + {y} = {soma}");

        int subtracao = x - y;
        Console.WriteLine($"Subtração: {x} - {y} = {subtracao}");


        int multiplicacao = x * y;
        Console.WriteLine($"Multiplicação: {x} * {y} = {multiplicacao}");

        int divisaoInteira = x / y;
        Console.WriteLine($"Divisão: {x} / {y} = {divisaoInteira}");

        //Questão 05
        int a = 5;
        int b = 8;

        if(a > b){
            Console.WriteLine($"O maior é: {a}");
        }else if(a < b){
            Console.WriteLine($"O maior é: {b}");

        }else{
            Console.WriteLine($"Números iguais");

        }

        //Questão 06
        string str1 = "Hello";
        string str2 = "World";

        bool saoIguais = str1 == str2;


        if (saoIguais)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings são diferentes.");
        }

        //Questão 07
        bool condicao1 = true;
        bool condicao2 = false;

        bool ambasSaoVerdadeiras = condicao1 && condicao2;

        if (ambasSaoVerdadeiras)
        {
            Console.WriteLine("Ambas as condições são verdadeiras.");
        }
        else
        {
            Console.WriteLine("Pelo menos uma das condições é falsa.");
        }


        //Questão 08
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        if(num3 > (num1 + num2))
        {
            Console.WriteLine("num3 é maior que num1 + num2");
        }else if(num1 > num2)
        {
            Console.WriteLine("num1 é maior que num2");

        }


    }
}