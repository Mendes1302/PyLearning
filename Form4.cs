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

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questao.Text = "2)Devemos sempre usar parênteses sempre que usar uma função print no Python?";
            radio_a.Text = "Verdadeiro";
            radio_b.Text = "Falso";
            radio_c.Visible = false;
        }

        private void radio_b_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
