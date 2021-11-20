using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importação da camada de negócio e da camada de acesso a dados
using projetonetflix11900490.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using projetonetflix11900490.Code.DAL;
using System.Data;

namespace projetonetflix11900490.Code.BLL
{
    class NetflixBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "netflix";

        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(NetflixDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Usuario}','{medDto.Titulo_assitido_no_momento}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(NetflixDTO meddDto) 
        {
            string alterar = $"update {tabela} set usuario = '{meddDto.Usuario}', assistindo_no_momento = '{meddDto.Titulo_assitido_no_momento}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(NetflixDTO medDto) 
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
