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
    public partial class TelaAtrasados : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TUCVR5C;Initial Catalog=login;Integrated Security=True");
        int Id_lanc = 0;

        public TelaAtrasados()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;

            adicionar.FlatStyle = FlatStyle.Flat;
            adicionar.FlatAppearance.BorderColor = Color.LimeGreen;
            adicionar.FlatAppearance.BorderSize = 1;

            //
            voltar.FlatStyle = FlatStyle.Flat;
            voltar.FlatAppearance.BorderColor = Color.Red;
            voltar.FlatAppearance.BorderSize = 1;

            FillDataGridView();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                    if (adicionar.Text == "Editar")
                    {

                        SqlCommand sqlCmd = new SqlCommand("dbo.AddorEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@Id", Id_lanc);
                        sqlCmd.Parameters.AddWithValue("@DataPrev", dataPrev.Value.ToShortDateString().Trim());
                        sqlCmd.Parameters.AddWithValue("@DataEfet", dataEfet.Value.ToShortDateString().Trim());
                        bool isChecked = receita.Checked;
                        if (isChecked)
                        {
                            sqlCmd.Parameters.AddWithValue("@Categoria", "Receita");
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@Categoria", "Despesa");
                        }
                        sqlCmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(valor.Value));
                        sqlCmd.Parameters.AddWithValue("@Descricao", descricao.Text.Trim());
                        if ((dataEfet.Value.ToShortDateString() != "01/01/2019") || isChecked)
                        {
                            sqlCmd.Parameters.AddWithValue("@Situacao", "Efetivada");
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@Situacao", "Não Efetivada");
                        }
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Editado com sucesso", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sqlCon.Close();
                    }  

                    FillDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarAtrasado", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                //sqlDa.SelectCommand.Parameters.AddWithValue("@Descricao", descricaoPes.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                tabela.DataSource = dtbl;
                tabela.Columns["Id_lanc"].Visible = false;
                this.tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        private void tabela_DoubleClick(object sender, EventArgs e)
        {
            if (tabela.CurrentRow.Index != -1)
            {
                Id_lanc = Convert.ToInt32(tabela.CurrentRow.Cells[0].Value.ToString());
                dataPrev.Value = (DateTime)tabela.CurrentRow.Cells[1].Value;
                dataEfet.Value = (DateTime)tabela.CurrentRow.Cells[2].Value;
                if (tabela.CurrentRow.Cells[3].Value.Equals("Receita"))
                {
                    receita.Checked = true;
                    despesa.Checked = false;

                }
                else if (tabela.CurrentRow.Cells[3].Value.Equals("Despesa"))
                {
                    despesa.Checked = true;
                    receita.Checked = false;
                }
                valor.Text = tabela.CurrentRow.Cells[4].Value.ToString();
                descricao.Text = tabela.CurrentRow.Cells[5].Value.ToString();
                adicionar.Text = "Editar";
            }
        }


        private void tabela_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // tabela.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                tabela.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
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
