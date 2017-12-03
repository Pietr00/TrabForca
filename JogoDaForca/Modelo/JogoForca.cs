using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaForca.Modelo
{
    class JogoForca
    {
        private int qVidas;
        private int qAcertos;
        private bool fimDeJogo;
        private bool resultado;
        private BancoPalavras bancoPalavras;
        private Palavra palavraSorteada;
        public string impressao = "";

        public JogoForca() {
            bancoPalavras = new BancoPalavras();
            palavraSorteada = bancoPalavras.sortear();
            fimDeJogo = false;
            qAcertos = 0;
            qVidas = 6;
            for(int i=0; i<palavraSorteada.tam(); i++){
                impressao += "_ ";
            }
        }

        public bool getFimDeJogo() {
            return fimDeJogo;
        }

        public int getQvidas() {
            return qVidas;
        }

        public bool getResultado() {
            return resultado;
        }


        public void jogada(char letra) {
            int[] aux;
            aux = palavraSorteada.verifLetra(letra);

            if (aux[0] < 0) {
                qVidas--;
                if (qVidas == 0) {
                    fimDeJogo = true;
                    resultado = false;
                }
            } else {
                qAcertos += aux.Length;
                string aux2 = impressao;
                impressao = "";
                for (int i = 0; i < palavraSorteada.tam(); i++) {
                    bool aux3 = false;
                    for (int j = 0; j < aux.Length; j++) {
                        if (aux[j] == i) aux3 = true;
                    }
                    if (aux3) impressao += letra + " ";
                    else impressao += aux2[2*i] + " ";
                }
                if (qAcertos == palavraSorteada.tam()) {
                    fimDeJogo = true;
                    resultado = true;
                }
            }
        }
    }
}
