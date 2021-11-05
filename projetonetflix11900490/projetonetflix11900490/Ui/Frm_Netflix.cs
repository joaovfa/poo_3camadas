using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importação da camada de negócio
using projetonetflix11900490.Code.BLL;
using projetonetflix11900490.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace projetonetflix11900490.Ui
{
    public partial class Frm_Netflix : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        NetflixBLL medbll = new NetflixBLL();
        NetflixDTO meddto = new NetflixDTO();

        public Frm_Netflix()
        {
            InitializeComponent();
        }

        private void Frm_Netflix_Load(object sender, EventArgs e)
        {
            dgvNetflix.DataSource = medbll.Listar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Usuario = txtUsuario.Text;
            meddto.Titulo_assitido_no_momento = txtAssistindo_no_momento.Text;


            if (txtUsuario.Text != "" || txtAssistindo_no_momento.Text != "")
            {
                //Envio do dto preenchido para o método inserir
                medbll.Inserir(meddto);

                //Mensagem de sucesso
                MessageBox.Show("Cadastrado com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpeza dos componentes
                txtId.Clear();
                txtUsuario.Clear();
                txtAssistindo_no_momento.Clear();

            }
            else
            {
                //Mensagem de erro
                MessageBox.Show("Erro, preencha todos os campos!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvNetflix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuario clicar em um registro da lista, os dados serão preenchidos
            txtId.Text = dgvNetflix.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dgvNetflix.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAssistindo_no_momento.Text = dgvNetflix.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);
            meddto.Usuario = (txtUsuario.Text);
            meddto.Titulo_assitido_no_momento = (txtAssistindo_no_momento.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtUsuario.Clear();
            txtAssistindo_no_momento.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);

            //Envio do dto preenchido para o método excluir
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtUsuario.Clear();
            txtAssistindo_no_momento.Clear();
        }
    }
}
