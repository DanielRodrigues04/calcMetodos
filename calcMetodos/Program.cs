using System;

namespace Calculadora
{
    class Program
    {


        static void Main(string[] args)
        {

            escreveNomeGrupo();
            Calcular();
            Console.ReadKey();

        }

        private static void Calcular()
        {
            double numero1, numero2;
            double resultado = 0;

            Console.WriteLine("Digite o primeiro numero");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            numero2 = double.Parse(Console.ReadLine());


            Console.Clear();

            while (resultado != 5)
            {
                Console.WriteLine("Digite 1 para SOMAR");
                Console.WriteLine("Digite 2 para SUBTRAIR");
                Console.WriteLine("Digite 3 para MULTIPLICAÇÃO");
                Console.WriteLine("Digite 4 para DIVISÃO");
                Console.WriteLine("[Tecla 5 para SAIR]");

                resultado = int.Parse(Console.ReadLine()); //enter para continuar a aplicação

                if (resultado == 1)
                {
                    Console.WriteLine("Soma = {0}", numero1 + numero2);
                }
                if (resultado == 2)
                {
                    Console.WriteLine("Subtração = {0}", numero1 - numero2);
                }
                if (resultado == 3)
                {
                    Console.WriteLine("Multiplicação = {0}", numero1 * numero2);
                }
                if (resultado == 4)
                {
                    Console.WriteLine("Divisão = {0}", numero1 / numero2);
                }
                if (resultado == 5)
                {

                    Environment.Exit(0);

                }

                Console.ReadLine();
                Console.Clear();
                Calcular();
            }
        }

        private static void escreveNomeGrupo()
        {
            Console.WriteLine("Daniel Filipe Tavares Rodrigues, Yan Percegona Weiss ");
        }
    }
}

