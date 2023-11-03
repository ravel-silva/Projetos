using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.Properties;



namespace GerenciadorDeEstoque.Telas
{

    public partial class TelaLogin : Form
    {
        LoginAcesso loginAcesso = new LoginAcesso();

        public TelaLogin()
        {
            InitializeComponent();

        }



        private void Acesso11_Click(object sender, EventArgs e)
        {
            LoginAcesso LoginAlx = new LoginAcesso();
            LoginAlx.MostrarImgAlx();
            LoginAlx.Show();
        }

        private void Acesso12_Click(object sender, EventArgs e) //loja
        {
            LoginAcesso LoginLoja = new LoginAcesso();
            LoginLoja.MostrarImgLoja();
            LoginLoja.Show();
        }
    }
}

