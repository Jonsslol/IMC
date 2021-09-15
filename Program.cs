using System;

namespace atividade_2
{
    class Program
    {

        static void Main(string[] args)
        {
            var qtdPessoas = 5; //Define um quantizador de pessoas que irá influenciar nas iterações que o programa fará
            var _alturas = new double[qtdPessoas]; //Define um vetor para armazenar os valores de altura com tamanho igual a qtdPessoas
            var _pesos = new double[qtdPessoas]; //Define um vetor para armazenar os valores de peso com tamanho igual a qtdPessoas
            var _imcs = new double[qtdPessoas]; //Define um vetor para armazenar os valores do IMC calculado com tamanho igual a qtdPessoas

            for (var i = 0; i < qtdPessoas; i++) //Laço de repetição para solicitação de dados ao usuário e cálculo, com valor inicial 0 (para manipular os vetores); condição de continuidade: enquanto i (contador) for menor que o valor de qtdPessoas; passo: incrementa i (contador) em +1
            {
                _pesos[i] = ReceberPeso(i);
                _alturas[i] = ReceberAltura(i);
                Console.WriteLine();
                _imcs[i] = CalcularImc(_pesos[i], _alturas[i]);
            }

            Console.WriteLine("Resultados:");
            for (var i = 0; i < qtdPessoas; i++) //Laço de repetição para display dos resultados com estrutura semelhante ao anterior
            {
                MostrarResultado(_imcs[i]);
            }
        }

        
        static void MostrarResultado(double imc){
             var situacao = "Abaixo do peso";

            if (imc >= 18.5 && imc < 25)
            {
                situacao = "Peso normal";
            }
            else if (imc > 25)
            {
                situacao = "Acima do peso";
            }

            Console.WriteLine($"Resultado {imc.ToString("f2")} / Situação: {situacao}");
        }

        static double ReceberAltura(int i)
        {
            Console.Write($"Informe a altura da pessoa {i + 1}: ");
            return double.Parse(Console.ReadLine().Replace(".",","));
        }

        static double ReceberPeso(int i)
        {
            Console.Write($"Informe o peso da pessoa {i + 1}: ");
            return double.Parse(Console.ReadLine().Replace(".",","));
        }

        static double CalcularImc(double peso, double altura)
        {
            return peso / (Math.Pow(altura, 2));
        }
    }
}

