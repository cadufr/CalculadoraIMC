﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é  {1} e seu peso é {2}", nome, altura , peso);
            Console.WriteLine("Seu IMC é {0}", imc);

        }
    }
}