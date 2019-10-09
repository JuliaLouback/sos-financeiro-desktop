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
    public partial class pesquisas : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TUCVR5C;Initial Catalog=login;Integrated Security=True");
        public pesquisas()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.Fixed3D;

            pesquisarDia.FlatStyle = FlatStyle.Flat;
            pesquisarDia.FlatAppearance.BorderColor = Color.Silver;
            pesquisarDia.FlatAppearance.BorderSize = 1;

            pesquisarMes.FlatStyle = FlatStyle.Flat;
            pesquisarMes.FlatAppearance.BorderColor = Color.Silver;
            pesquisarMes.FlatAppearance.BorderSize = 1;

            pesquisarPeriodo.FlatStyle = FlatStyle.Flat;
            pesquisarPeriodo.FlatAppearance.BorderColor = Color.Silver;
            pesquisarPeriodo.FlatAppearance.BorderSize = 1;

            voltar.FlatStyle = FlatStyle.Flat;
            voltar.FlatAppearance.BorderColor = Color.Red;
            voltar.FlatAppearance.BorderSize = 1;
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarDia", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Descricao", (int)pesquisaDias.Value);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                tabelas.DataSource = dtbl;
                tabelas.Columns["Id_lanc"].Visible = false;
                this.tabelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.tabelas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        void FillDataGridView1()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarMes", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                int mes = 0;
                switch (comboBox1.Text) {
                    case "Janeiro": mes = 01;
                        break;
                    case "Fevereiro": mes = 02;
                        break;
                    case "Março":
                        mes = 03;
                        break;
                    case "Abril":
                        mes = 04;
                        break;
                    case "Maio":
                        mes = 05;
                        break;
                    case "Junho":
                        mes = 06;
                        break;
                    case "Julho":
                        mes = 07;
                        break;
                    case "Agosto":
                        mes = 08;
                        break;
                    case "Setembro":
                        mes = 09;
                        break;
                    case "Outubro":
                        mes = 10;
                        break;
                    case "Novembro":
                        mes = 11;
                        break;
                    case "Dezembro":
                        mes = 12;
                        break;
                }
                sqlDa.SelectCommand.Parameters.AddWithValue("@Descricao", mes);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                tabelas.DataSource = dtbl;
                tabelas.Columns["Id_lanc"].Visible = false;
                this.tabelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.tabelas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        void FillDataGridView2()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarPeriodo", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Inicio", inicio.Value.ToShortDateString().Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@Final", final.Value.ToShortDateString().Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                tabelas.DataSource = dtbl;
                tabelas.Columns["Id_lanc"].Visible = false;
                this.tabelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.tabelas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        private void pesquisarDia_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
            Hide();
        }

        private void pesquisarMes_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void pesquisarPeriodo_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void tabelas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("Efetivada"))
            {
                // tabela.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                tabelas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
            else if (e.Value != null && e.Value.Equals("Não Efetivada"))
            {
                // tabela.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                tabelas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.Show();
            Hide();
        }
    }


}
