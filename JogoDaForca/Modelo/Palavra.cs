using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaForca.Modelo
{
    class Palavra
    {
        public string palavra = " ";

        public Palavra() {
        }

        public Palavra(string palavra) {
            this.palavra = palavra;
        }

        public int tam(){
            return palavra.Length;
        }

        //Retorna letra do indice pedido da palavra
        public char letra(int indice) {
            return palavra[indice];
        }
        //Verifica se tem a letra na palavra
        //Caso tenha : retorna os indices que elas se encontram
        //Caso não tenha : retorna -1
        public int[] verifLetra(char letra) {
            int[] aux = new int[100];
            int[] ret;
            int tam = 0;
            for(int i = 0; i < palavra.Length; i++) {
                if (palavra[i] == letra)
                    aux[tam++] = i;
            }
            if (tam==0) {
                ret = new int[1];
                ret[0] = -1;
                return ret;
            }
            ret = new int[tam];
            for(int i = 0; i < tam; i++)
                ret[i] = aux[i];

            return ret;
        }
    }
}
