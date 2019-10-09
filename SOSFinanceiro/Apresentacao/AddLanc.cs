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
    public partial class AddLanc : Form
    {
        public AddLanc()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            enviarLanc.BackColor = Color.Red;
            enviarLanc.FlatStyle = FlatStyle.Flat;
            enviarLanc.FlatAppearance.BorderColor = Color.Red;
            enviarLanc.FlatAppearance.BorderSize = 1;
        }

        SqlConnection sqlcon = null;
        private String strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=login;Data Source=DESKTOP-TUCVR5C";
        private SqlConnection sqlCon;
        private String strSql = string.Empty;

        private void labelVoltarP_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
            Hide();
        }

        private void AddLanc_Load(object sender, EventArgs e)
        {

        }

        private void enviarLanc_Click(object sender, EventArgs e)
        {
            strSql = "insert into lancamentos(DataPrevista,DataEfetivada,Categoria,Valor,Descricao) values (@DataPrev,@DataEfet,@Categoria,@Valor,@Descricao)";
            //string theDate = dateTimePicker1.Value.ToShortDateString();

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql,sqlCon);
            comando.Parameters.Add("@DataPrev",SqlDbType.DateTime).Value = dataPrev.Value.ToShortDateString();
            comando.Parameters.Add("@DataEfet", SqlDbType.DateTime).Value = dataEfet.Value.ToShortDateString();
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoria.Text;
            comando.Parameters.Add("@Valor", SqlDbType.Decimal).Value = valor.Text;
            comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = descricao.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("O cadastro foi efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                sqlCon.Close();
            }
        }
    }
}
