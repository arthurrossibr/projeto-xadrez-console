using System;
using tabuleiro;
using xadrex;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 1));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 5));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 2));

                Tela.ImprimirTabuleiro(tab);

                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
