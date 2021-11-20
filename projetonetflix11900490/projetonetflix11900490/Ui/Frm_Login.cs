using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetonetflix11900490.Code.BLL;
using projetonetflix11900490.Code.DTO;

namespace projetonetflix11900490.Ui
{
    public partial class Frm_Login : Form
    {
        LoginBLL loginprodutoBBL = new LoginBLL();
        LoginDTO loginprodutoDTO = new LoginDTO();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginprodutoDTO.Nome = txtNome.Text;
            loginprodutoDTO.Senha = txtSenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginprodutoBBL.RealizarLogin(loginprodutoDTO) == true)
            {

                Frm_Netflix frm_rede = new Frm_Netflix();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
