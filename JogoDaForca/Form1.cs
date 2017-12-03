using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        private Modelo.JogoForca jogoForca;
        private bool debugOn = false;

        public Form1()
        {
            InitializeComponent();
            jogoForca = new Modelo.JogoForca();
            textBox1.Text = jogoForca.impressao;

            string nSei = "N SEI ONDE APARECE ISSO";//fiquei com medo de tirar
            if (debugOn)
                label1.Text = nSei;
        }

        private void processarLetra(char letra)
        {
            if (!jogoForca.getFimDeJogo()) {
                jogoForca.jogada(letra);

                textBox1.Text = jogoForca.impressao;

                if (!jogoForca.getFimDeJogo()) {
                    if (jogoForca.getQvidas() == 5)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem02;
                    else if (jogoForca.getQvidas() == 4)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem03;
                    else if (jogoForca.getQvidas() == 3)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem04;
                    else if (jogoForca.getQvidas() == 2)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem05;
                    else if (jogoForca.getQvidas() == 1)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem06;
                } else {
                    if (jogoForca.getResultado())
                        MessageBox.Show("Fim de Jogo. Você ganhou, PARABÉNS!!");
                    else {
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem07;
                        MessageBox.Show("Fim de Jogo. Você perdeu!!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processarLetra('A');
            ((Button)sender).Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processarLetra('B');
            ((Button)sender).Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processarLetra('C');
            ((Button)sender).Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processarLetra('D');
            ((Button)sender).Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processarLetra('E');
            ((Button)sender).Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processarLetra('F');
            ((Button)sender).Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            processarLetra('G');
            ((Button)sender).Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processarLetra('H');
            ((Button)sender).Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processarLetra('I');
            ((Button)sender).Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            processarLetra('J');
            ((Button)sender).Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            processarLetra('K');
            ((Button)sender).Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            processarLetra('L');
            ((Button)sender).Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            processarLetra('M');
            ((Button)sender).Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            processarLetra('N');
            ((Button)sender).Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            processarLetra('O');
            ((Button)sender).Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            processarLetra('P');
            ((Button)sender).Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            processarLetra('Q');
            ((Button)sender).Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            processarLetra('R');
            ((Button)sender).Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            processarLetra('S');
            ((Button)sender).Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            processarLetra('T');
            ((Button)sender).Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            processarLetra('U');
            ((Button)sender).Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            processarLetra('V');
            ((Button)sender).Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            processarLetra('W');
            ((Button)sender).Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            processarLetra('X');
            ((Button)sender).Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            processarLetra('Y');
            ((Button)sender).Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            processarLetra('Z');
            ((Button)sender).Enabled = false;
        }
    }
}
