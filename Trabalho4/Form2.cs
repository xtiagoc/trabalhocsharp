using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho4
{
    public partial class Form2 : Form
    {
        public string textoReceber;

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Curitiba";
            label6.Text = textoReceber;
            dateTimePicker1.MaxDate = DateTime.Today;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Campo Nome Obrigatorio");
                return;
            }
            else if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Por favor, selecione um genero");
                return;
            }
            else
            {
                MessageBox.Show("Tudo Certo! Pode prosseguir");
                return;
                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedItem = "Curitiba";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
