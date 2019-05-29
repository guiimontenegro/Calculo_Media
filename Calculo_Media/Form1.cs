using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtMedia.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;
            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            n4 = Convert.ToDouble(txtNota4.Text);
            media = (n1 + n2 + n3 + n4) / 4;
            txtMedia.Text = media.ToString();
            /* No codigo estamos declarando as variaveis do tipo 
             * double: n1,n2,n3 e media.
             * nas linhas seguintes, as variaveis recebem o conteudo
             * do textbox e sao convertidas para double.
             * A variavael média recebe a formula(n1+n2+n3+n4)/4
             * txtmedia recebe o conteudo da variavel média, que é o
             * resultado do calculo.*/

            if (media < 5)
                MessageBox.Show("Aluno foi reprovado!");
            else if (media >= 7)
                MessageBox.Show("Aluno foi aprovado!");
            else
                MessageBox.Show("Aluno em recuperação");
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
