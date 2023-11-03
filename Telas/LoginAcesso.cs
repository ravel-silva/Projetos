using GerenciadorDeEstoque.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Telas
{

    public partial class LoginAcesso : Form
    {


        public LoginAcesso()
        {
            InitializeComponent();
            Hide();
        }
        public void MostrarImgAlx()
        {
            ImgAlx.Visible = true;
            ImgLoja.Visible = false;
        }
        public void MostrarImgLoja()
        {
            ImgLoja.Visible = true;
            ImgAlx.Visible = false;

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//verifica se a tecla enter e apertada atravez do "e.KeyChar" comparando com "(char)Keys.Enter" 
            {
                e.Handled = true; //evita que o caractere Enter seja inserido no controle.
                Form1 Tela = new Form1();
                Tela.Show();
            }

        }
    }

}


