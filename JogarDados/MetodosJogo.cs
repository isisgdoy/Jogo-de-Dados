using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarDados
{
    public class MetodosJogo
    {
        // criação das variaveis para acessar os jogadores de qqlr metodo

        public static string? Jogador1; // ? informa que a variavel pode ser nula, sem um valor definido
        public static string? Jogador2;

        // variavel para armazenar a pontuação dos jogos 

        public static byte PontosJogador1;
        public static byte PontosJogador2;

        // variavel para armazenar a rodada atual

        public static byte RodadaAtual;


        public void ConfigurarJogos()
        {
            RodadaAtual = 0; // campo/fields (variavel criada pra ser acessado em qqlr metodo)

            CriarJogadores(); //  metodos
            AtualizarPlacar();//  metodos

            Console.WriteLine($"\n Jogadores {Jogador1} e {Jogador2} criados. Pressione qulaquer tecla pra continuar.");
            Console.ReadKey(); // Obtém o próximo caractere ou tecla de função pressionada pelo usuário. // Console é a classe e ReadKey é o metodo

        }


        public static void CriarJogadores()
        {
            Console.WriteLine("Informe o nome do primeiro jogador:");
            Jogador1 = Console.ReadLine()!;
            PontosJogador1 = 0;

            Console.WriteLine("Informe o nome do segundo jogador:");
            Jogador2 = Console.ReadLine()!;
            PontosJogador2 = 0;

        }

        public static void AtualizarPlacar()
        {
            Console.Clear(); //é usado para limpar as mensagens do console
            Console.WriteLine($"Pontos do jogador {Jogador1}: {PontosJogador1}");
            Console.WriteLine($"Ponstos do jogador {Jogador2}: {PontosJogador2}");
            Console.WriteLine();

            if (RodadaAtual == 0)
            {

                Console.WriteLine("Jogo nao iniciado...");
            }

        }


        public void IniciarRodadas()
        {
            AtualizarPlacar();
            if (RodadaAtual == 3)
            {
                FinalizarJogo();
                return;
            }

            RodadaAtual++; // incrementando no metodo RodadaAtual

            Console.WriteLine($"Rodada {RodadaAtual} iniciada!\n");
            Console.WriteLine($"Jogador {Jogador1} precisone enter para fazer sua jogada...");
            Console.ReadLine();
            byte ValorTiradoJogador1 = JogarDado();
            Console.WriteLine($"Valor do dado jogado pelo {Jogador1}: {ValorTiradoJogador1}");

            Console.WriteLine($"Rodada {RodadaAtual} iniciada!\n");
            Console.WriteLine($"Jogador {Jogador2} precisone enter para fazer sua jogada...");
            Console.ReadLine();
            byte ValorTiradoJogador2 = JogarDado();
            Console.WriteLine($"Valor do dado jogado pelo {Jogador2}: {ValorTiradoJogador2}");

            if (ValorTiradoJogador1 == ValorTiradoJogador2)
            {
                Console.WriteLine($"O jogador {Jogador1} tirou: {ValorTiradoJogador1} e o {Jogador2} tirou: {ValorTiradoJogador2}. Empate!");
                Console.WriteLine("Pressione ENTER para continuar com o jogo...");
                Console.ReadLine();
            }
            else
            {
                string Vencedor;

                if (ValorTiradoJogador1 > ValorTiradoJogador2)
                {
                    Vencedor = Jogador1;
                    PontosJogador1++;

                }
                else
                {
                    Vencedor = Jogador2;
                    PontosJogador2++;

                }

                Console.WriteLine($"{Jogador1} tirou o numero {ValorTiradoJogador1} e {Jogador2} tirou o numero {ValorTiradoJogador2}. O vencedor foi: {Vencedor}, da rodada {RodadaAtual}");
                Console.WriteLine("Pressione ENTER para continuar o jogo...");
                Console.ReadLine();

            }

            IniciarRodadas();

        }
        public static byte JogarDado()
        {
            Random gerador = new Random(); // gera numeros aleatórios 
            return Convert.ToByte(gerador.Next(1, 6)); //Converte um valor especificado em um inteiro sem sinal de 8 bits.

        }
        public static void FinalizarJogo()
        {

            AtualizarPlacar();
            Console.WriteLine("Jogo finalizado!!!");

            if (PontosJogador1 == PontosJogador2)
            {
                Console.WriteLine("Empate!");
            }
            else if (PontosJogador1 > PontosJogador2)
            {
                Console.WriteLine($"O jogador {Jogador1} venceu com {PontosJogador1} pontos!");
            }
            else
            {
                Console.WriteLine($"O jogador {Jogador2} venceu com {PontosJogador2} pontos!");
            }
        }

    }
}

