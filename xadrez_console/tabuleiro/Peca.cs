using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtsMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {

            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtsMovimentos = 0;

        }




    }
}
