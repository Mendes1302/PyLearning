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
    public partial class Quiz : Form
    {
        string[] questoes = { 
                              "1) O Comando Print tem que função?",
                              "2) Devemos sempre usar parênteses sempre que usar uma função print no Python?",
                              "3) O Recuo é importante na programação Python?",
                              "4) O que acontece se eu não usar recuo no Python?",
                              "5) Os comentários em uma única linha em Python são escritos com um caractere especial, qual é esse caractere?",
                              "6) Para fazer um comentário de múltiplas linhas ou multilinha eu preciso adicionar:",
                              "7) Marque a opção que contenha um tipo de variavel :",
                              "8) E possível diferenciar variáveis só mudando de letra minúscula e maiúscula?",
                              "9) Uma variável criada fora de uma função,é global?",
                              "10) É possível criar uma variável de mesmo nome dentro e fora de uma função?",
                              "11) É possível converter um tipo numérico pra outro?",
                              "12) Para imprimir em letras maiúsculas um texto utiliza-se:",
                              "13) Para imprimir em letras minúsculas um texto utiliza-se:",
                              "14) Para remover espaço em branco ao redor de texto utiliza-se:",
                              "15) Para substituir uma letra por outra em um texto utiliza-se:",
                              "16) O format(), pode ser usado para concatenar uma string com número?",
                              "17) É permitido usar valores Booleanos para comparação em uma instrução if?",
                              "18) Python divide os operadores em quantos grupos ?",
                              "19) A instrução elif é a forma de Python de dizer:",
                              "20) A palavra-chave else captura qualquer coisa que não seja capturada pelas condições anteriores?",
                              "21) Não podemos colocar uma instrução if dentro de outra instrução if?",
                              ""
        };

        //matriz linha por coluna (linha = questoes, coluna = radio)
        string[,] radio = new string[22,3] { { "Imprimir uma mensagem", "Copiar algo da tela", "Criar uma variável" },
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
                                            { "upper",            "lower",                "" },
                                            { "upper",            "lower",                "" },
                                            { "replace",            "strip",                "split" },
                                            { "replace",            "strip",                "split" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "falso" ,                "" },
                                            {"5",                       "6",                   "7"},
                                            { "Se as condições anteriores não eram verdadeiras, tente esta condição",            "Se as condições anteriores não eram falsas, tente esta condição", "Se as condições anteriores eram verdadeiras, tente esta condição" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" },
                                            { "Verdadeiro",            "Falso",                "" }
        };

        int[] respostas = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        int counter = 0;

        double resp_ok = 0;

        public Quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 22)
            {
                this.Close();
                return;
            }
        

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

            if(counter>0)
            {
                if(radio_a.Checked == false && radio_b.Checked == false && radio_c.Checked == false)
                {
                    
                   DialogResult x =  MessageBox.Show("Prosseguir sem Responder ?","Alerta",MessageBoxButtons.YesNo);
                   if(x == DialogResult.No)
                    {
                        return;
                    }
 
                }
                

                    
            }

            

            if (counter == 1 || counter == 2 || counter == 3 || counter == 5 || counter == 6 || counter == 8 || counter == 9 || counter == 10 || counter == 11 ||
                counter == 12|| counter == 15 || counter == 16 || counter == 17 || counter == 19 || counter == 20)
            {
                if (radio_a.Checked)
                {
                    MessageBox.Show("Resposta correta");
                    resp_ok++;
                }
                else if (radio_b.Checked|| radio_c.Checked)
                {
                    MessageBox.Show("Resposta errada");
                }
            }
            else if (counter == 4|| counter == 13|| counter == 14 || counter == 21)
            {
                if (radio_b.Checked)
                {
                    MessageBox.Show("Resposta correta");
                    resp_ok++;
                }
                else if(radio_a.Checked|| radio_c.Checked)
                {
                    MessageBox.Show("Resposta errada");
                }
            }
            else
            {
                if (radio_c.Checked)
                {
                    MessageBox.Show("Resposta correta");
                    resp_ok++;
                }
                else if (radio_a.Checked || radio_b.Checked)
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

            double porce = Math.Round(resp_ok/0.21);

            
            if (counter == 22)
            {
                questao.Visible = false;
                gab.Visible =true;
                acer.Visible = true;
                erro.Visible = true;
                label1.Text = "Quiz Finalizado";
                gab.Text = "A porcentagem de acertos foi:";
                acer.Text = ("Acertos foram : " + porce + "%");
                erro.Text = "Seus Erros : " + (100 - porce) + "%";
                radio_a.Visible = false;
                radio_b.Visible = false;
                radio_c.Visible = false;
                button1.Text = "Finalizar";
                //counter = 0;
            }


        }

        private void questao_TextChanged(object sender, EventArgs e)
        {

        }

        private void gabarito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
