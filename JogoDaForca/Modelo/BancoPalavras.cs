using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaForca.Modelo
{
    class BancoPalavras
    {
        private Palavra[] palavra = new Palavra[12];

        public BancoPalavras() {
            palavra[0] = new Palavra("BANANA");
            palavra[1] = new Palavra("SELVA");
            palavra[2] = new Palavra("CAJÚ");
            palavra[3] = new Palavra("PIPOCA");
            palavra[4] = new Palavra("ARARAQUARA");
            palavra[5] = new Palavra("DONINHA");
            palavra[6] = new Palavra("PETRÓLEO");
            palavra[7] = new Palavra("PAPAGAIO");
            palavra[8] = new Palavra("BRASIL");
            palavra[9] = new Palavra("SKATE");
            palavra[10] = new Palavra("VOLKSWAGEN");
            palavra[11] = new Palavra("HYUNDAI");
        }

        public Palavra sortear() {
            Random rand = new Random();
            return palavra[rand.Next(0, 12)];
        }
    }
}
