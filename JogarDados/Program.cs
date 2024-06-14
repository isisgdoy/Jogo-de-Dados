using JogarDados;
using System;
using System.Diagnostics.Metrics;

namespace JogarDados // modulo
{
    class Program //classe
    {
        static void Main(string[] args) // metodos (funções) esse método deve receber como parâmetro um array de String (nomeado args)
        {
            MetodosJogo metodosJogo = new(); // chamando a classe para instancias os metodos 

            Console.Clear();

            metodosJogo.ConfigurarJogos(); // instanciando os metodos da classe metodoJogo
            metodosJogo.IniciarRodadas();

        }
    }
}