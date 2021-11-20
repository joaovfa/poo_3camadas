using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Importação da camada de negócio e da camada de acesso a dados
using projetonetflix11900490.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using projetonetflix11900490.Code.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace projetonetflix11900490.Code.BLL
{
    class LoginBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "login";

        public bool RealizarLogin(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where nome='{login.Nome}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
