

using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao  Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimento()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
        

        
    }
}
