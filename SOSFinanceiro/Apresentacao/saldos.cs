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
    public partial class saldos : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TUCVR5C;Initial Catalog=login;Integrated Security=True");

        public saldos()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            FillDataGridView();
            FillDataGridView1();
            FillDataGridView2();

            voltar.FlatStyle = FlatStyle.Flat;
            voltar.FlatAppearance.BorderColor = Color.Red;
            voltar.FlatAppearance.BorderSize = 1;
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarReceita", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                saldoReceita.DataSource = dtbl;
                this.saldoReceita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.saldoReceita.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        void FillDataGridView1()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarPendente", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                saldoPendente.DataSource = dtbl;
                this.saldoPendente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.saldoPendente.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
            }
        }

        void FillDataGridView2()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ListarAtrasado2", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                saldoAtrasado.DataSource = dtbl;
                this.saldoAtrasado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.saldoAtrasado.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

                sqlCon.Close();
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
