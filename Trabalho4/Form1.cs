﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "ximenes")
            {
                MessageBox.Show("Usuario Invalido/Campo Obrigatorio");  
                return;

            }
            else if (textBox2.Text != "40")
            {
                MessageBox.Show("Senha Invalido/Campo Obrigatorio");
                return;
            }
            else
            {
                Form2 form2 = new Form2();
                form2.textoReceber = textBox1.Text;
                form2.ShowDialog();
                this.Close();
            }
        }

    }
}
