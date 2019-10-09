using SOSFinanceiro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSFinanceiro.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha) {

            //instanciando outra classe 
            LoginDal loginDal = new LoginDal();
            // Nessa classe será usada o método verificar login e serão passadas as informações escritas pelo usuário
            // Nessa variavel tem retornará sim ou não
            tem = loginDal.verificarLogin(login,senha);
            if (!loginDal.mensagem.Equals("")) {
                this.mensagem = loginDal.mensagem;
            }
            return tem; // retorna para o formulário
        }

        public String cadastrar(String NomeCompleto, String Telefone, String Sexo, String Email, String Senha, String ConfirmarSenha) {
            return mensagem;
        }
    }
}
