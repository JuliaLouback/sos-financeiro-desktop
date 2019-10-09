using SOSFinanceiro.Apresentacao;
using SOSFinanceiro.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFinanceiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            login.BackColor = Color.Red;
            login.FlatStyle = FlatStyle.Flat;
            login.FlatAppearance.BorderColor = Color.Red;
            login.FlatAppearance.BorderSize = 1;
            cadastrar.BackColor = Color.Red;
            cadastrar.FlatStyle = FlatStyle.Flat;
            cadastrar.FlatAppearance.BorderColor = Color.Red;
            cadastrar.FlatAppearance.BorderSize = 1;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            Hide();
            cad.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //instância do método
            Controle controle = new Controle();
            // utilizando um método da classe Controle e passando os parametros
            controle.acessar(txtLogin.Text,txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Efetuando login no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaPrincipal tela = new TelaPrincipal();
                    tela.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
