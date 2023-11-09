using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
    public partial class Form1 : Form
    {
        string palavraSecreta;
        string palavraEmConstrucao;
        int erros;
        List<char> letrasTentadas;

        List<string> palavras = new List<string>
        {
            "PROGRAMACAO", "DESENVOLVIMENTO", "C#",
            "WINDOWS", "APLICACAO", "INTERFACE",
        };

        List<string> temas = new List<string>
        {
            "Informática", "Tecnologia", "Linguagens de Programação",
            "Sistemas Operacionais", "Software", "Desenvolvimento",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void NovoJogo()
        {
            Random random = new Random();
            int indicePalavra = random.Next(palavras.Count);
            palavraSecreta = palavras[indicePalavra].ToUpper();
            palavraEmConstrucao = new string('_', palavraSecreta.Length);
            erros = 0;
            letrasTentadas = new List<char>();

            lblPalavra.Text = palavraEmConstrucao;
            lblTema.Text = "Tema: " + temas[indicePalavra];
            lblLetrasTentadas.Text = "Letras Tentadas: ";
            txtLetra.Text = "";
        }

        private bool VerificarResultado()
        {
            if (erros >= 6)
            {
                MessageBox.Show("Você perdeu! A palavra era: " + palavraSecreta);
                return true;
            }

            if (!palavraEmConstrucao.Contains('_'))
            {
                MessageBox.Show("Parabéns! Você venceu!");
                return true;
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            Control lblPalavra = this.Controls["lblPalavra"];

            char letra = txtLetra.Text.ToUpper()[0];

            if (letrasTentadas.Contains(letra))
            {
                MessageBox.Show("Você já tentou essa letra.");
                return;
            }

            letrasTentadas.Add(letra);
            lblLetrasTentadas.Text = "Letras Tentadas: " + string.Join(", ", letrasTentadas);

            if (palavraSecreta.Contains(letra))
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == letra)
                    {
                        lblPalavra.Text = lblPalavra.Text.Remove(i, 1).Insert(i, letra.ToString());
                    }
                }
            }
            else
            {
                erros++;
            }

            if (VerificarResultado())
            {
                NovoJogo();
            }

            txtLetra.Text = "";
        }

        private void lblTema_Click(object sender, EventArgs e)
        {

        }
    }
}
