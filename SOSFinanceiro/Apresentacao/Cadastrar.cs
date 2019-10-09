using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSFinanceiro.Apresentacao
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            enviarCadastro.BackColor = Color.Red;
            enviarCadastro.FlatStyle = FlatStyle.Flat;
            enviarCadastro.FlatAppearance.BorderColor = Color.Red;
            enviarCadastro.FlatAppearance.BorderSize = 1;
        }

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=DESKTOP-TUCVR5C;Initial Catalog=login;Integrated Security=True";
        private string strSql = string.Empty;

        private void enviarCadastro_Click(object sender, EventArgs e)
        {
            strSql = "insert into usuarios(NomeCompleto,Telefone,Sexo,Email,Senha) values(@nomeC,@telefone,@sexo,@email,@senha)";
            sqlCon = new SqlConnection(strCon); 
            SqlCommand comando = new SqlCommand(strSql,sqlCon);
            comando.Parameters.Add("@nomeC",SqlDbType.VarChar).Value = nomeCompleto.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone.Text;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso","Cadastro Realizado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                Hide();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("O cadastro não foi realizado","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally {
                sqlCon.Close();
            }

        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.Show();
        }

    }
}
