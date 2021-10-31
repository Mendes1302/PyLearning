using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyLearning
{
    public partial class Form4 : Form
    {
        string[] questoes = { "1) Pergunta para que o comando print serve?",
                               "2) Devemos sempre usar parênteses sempre que usar uma função print no Python?",
                              "3) O Recuo é importante na programação Python?",
                              "4) O que acontece se eu não usar recuo no Python?",
                              "5) Os comentários em Python são escritos com um caractere especial, qual é esse caractere?",
                              "6) Para fazer um comentário de múltiplas linhas ou multilinha eu preciso adicionar:",
                              "7) Qual são tipos de variáveis?",
                              "8) E possível diferenciar variáveis só mudando de letra minúscula e maiúscula?",
                              "9) Uma variável criada fora de uma função ela é global?",
                              "10) É possível criar uma variável de mesmo nome uma global e outra em uma função?",
                              "11) É possível converter um tipo numérico pra outro?"
        };

        //matriz linha por coluna (linha = questoes, coluna = radio)
        string[,] radio = new string[12,3] { { "Imprimir uma mensagem", "Copiar algo da tela", "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "o python não responde", "da um erro no python", "Nenhuma das alternativas anteriores"},
                                            { "#",                     "!",                    "@" },
                                            { "Aspas tripla",          "Aspas duplas",         "Aspas simples" },
                                            { "str",                   "int",                  "Todas as anteriores" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" }
        };

        int[] respostas = {0,0,0,0,0,0,0,0,0,0,0,0};

        int counter = 0;


        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter>0)
            {
                int controle =0;
               
                if(radio_a.Checked == true)
                {
                    controle = 1;
                }
                else if (radio_b.Checked == true)
                {
                    controle = 2;
                }
                else if (radio_c.Checked == true)
                {
                    controle = 3;
                }

                respostas[counter - 1] = controle;
            }

            if (counter == 1 || counter == 2 || counter == 3 || counter == 5 || counter == 6 || counter == 8 || counter == 9 || counter == 10 || counter == 11)
            {
                if (radio_a.Checked)
                {
                    MessageBox.Show("Resposta correta");
                }
                else 
                {
                    MessageBox.Show("Resposta errada");
                }
            }
            


            button1.Text = "Próximo";
            questao.Visible = true;
            radio_a.Visible = true;
            radio_a.Checked = false;
            radio_b.Visible = true;
            radio_b.Checked = false;
            radio_c.Visible = true;
            radio_c.Checked = false;
            questao.Text = questoes[counter];
            radio_a.Text = radio[counter, 0];
            radio_b.Text = radio[counter, 1];
            radio_c.Text = radio[counter, 2];

            if (radio_a.Text == "")
            {
                radio_a.Visible = false;
            }
            else if (radio_b.Text == "")
            {
                radio_b.Visible = false;
            }
            else if (radio_c.Text == "")
            {
                radio_c.Visible = false;
            }

            


            counter++;



            if (counter == 11)
            {
                label1.Text = "Parabéns, você chegou ao fim do Quiz";
                questao.Visible = false;
                gabarito.Visible = true;
               // gabarito.Text = 
                radio_b.Visible = false;
                radio_c.Visible = false;

                counter = 0;
            }

        }

    }
}
