using Gerenciador_de_espaçonaves_do_star_wars.Repositorio;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_espaçonaves_do_star_wars
{
    public partial class Planetas : Form
    {
        private StarWarsRepositorio repositorio = new StarWarsRepositorio();
        public Planetas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            #region
            if (this.cbAcao.Text.Equals("Buscar"))
            {
                if (this.cbAcao.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "select * from Planetas";
                    MessageBox.Show("Selecionando todo mundo da tabela planetas");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (this.idPlaneta.Text.Equals("") && !this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "select Nome from Planetas where Nome='" + this.nomePlaneta.Text + "';";
                    MessageBox.Show("Buscando pelo nome");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (!this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "select id from Planetas where id='" + this.idPlaneta.Text + "';";
                    MessageBox.Show("Buscando pelo id");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else
                {
                    string sql = "select * from Planetas where id='" + this.idPlaneta.Text + "' and Nome='" + this.nomePlaneta.Text + "';";
                    MessageBox.Show("Buscando por id e nome");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe os valores a serem inseridos");
                }
                else if (this.idPlaneta.Text.Equals("") && !this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "insert into Naves(Nome) values(" + this.nomePlaneta + ");";
                    MessageBox.Show("Inserindo pelo nome");
                    this.repositorio.Inserir(sql);
                }
                else if (!this.idPlaneta.Text.Equals("") && !this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "insert into Naves(id, Nome) values(" + this.idPlaneta + "," + this.nomePlaneta + ");";
                    MessageBox.Show("Inserindo pelo nome e id");
                    this.repositorio.Inserir(sql);
                }
                else
                {
                    MessageBox.Show("Insira o nome do Planeta");
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem deletados");
                }
                else if (this.idPlaneta.Text.Equals("") && !this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Planetas where Nome='" + this.nomePlaneta + "';";
                    MessageBox.Show("Deletando pelo nome");
                    this.repositorio.Deletar(sql);
                }
                else if (!this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Planetas where id='" + this.idPlaneta.Text + "';";
                    MessageBox.Show("Deletando pelo id");
                    this.repositorio.Deletar(sql);
                }
                else
                {
                    string sql = "delete * from Naves where id='" + this.idPlaneta.Text + "' and Nome='" + this.nomePlaneta.Text + "';";
                    MessageBox.Show("Deletando pelo id e nome");
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Insira os dados para atualizar");
                }
                else if (this.idPlaneta.Text.Equals("") && !this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe o id que deseja atualizar e o novo nome");
                }
                else if (!this.idPlaneta.Text.Equals("") && this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe o nome a substituir");
                }
                else
                {
                    string sql = "update Planetas set Nome = '" + this.nomePlaneta.Text + "' where id = '" + this.idPlaneta.Text + "';";
                    MessageBox.Show("Atualizando tabela");
                    this.repositorio.Atualizar(sql);
                }
            }
            #endregion

            else
            {
                MessageBox.Show("Escolha uma ação");
            }
        }
    }
}
