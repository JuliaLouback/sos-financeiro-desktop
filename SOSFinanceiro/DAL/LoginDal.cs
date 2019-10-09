using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSFinanceiro.DAL
{
    class LoginDal
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        //verifica no banco de dados se existem os dados
        public bool verificarLogin(String login, String senha) {
            //comandos SQL para verificar no banco de dados
            cmd.CommandText = "select * from usuarios where Email=@login and Senha=@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try {
                //verifica no banco de dados 
                cmd.Connection = con.conectar();
                //guarda dentro da variavel os valores encontrados
                dr = cmd.ExecuteReader();
                // se a variavel não existever vazia então a varivel tem recebe o valor True se não recebe o valor False
                if (dr.HasRows) {
                    tem = true;
                }
            }
            catch (SqlException) { //em caso de erro aparece mensagem ao usuário se não houver erros a mensagem continuará vazia
                this.mensagem = "Erro com Banco Dados";
            }

            return tem;
        }

        public String cadastrar(String NomeCompleto, String Telefone, String Sexo, String Email, String Senha, String ConfirmarSenha)
        {
            //comandos para inserir
            return mensagem;
        }

    }
}
