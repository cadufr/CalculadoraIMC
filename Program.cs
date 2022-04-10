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

            if(imc < 17.00)
            {
                Console.WriteLine("Muito abaixo do peso normal");
            }

            else if(imc >= 17.00 && imc < 18.50)
            {
                Console.WriteLine("Abaixo do peso normal");
            }

            else if(imc >= 18.50 && imc < 25.00)
            {
                Console.WriteLine("Peso normal");
            }

            else if(imc >=  25.00 && imc < 30.00)
            {
                Console.WriteLine("Sobrepeso");
            }

            else if(imc >= 30.00 && imc < 35.00)
            {
                Console.WriteLine("Obesidade grau I");
            }

            else if(imc >= 35.00 && imc < 40.00)
            {
                Console.WriteLine("Obesidade grau II");
            }

            else if(imc >= 40.00 && imc < 45.00)
            {
                Console.WriteLine("Obesidade grau III");
            }

        }
    }
}