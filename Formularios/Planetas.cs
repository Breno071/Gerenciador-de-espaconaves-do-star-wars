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
                if (this.idPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Planetas";
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else
                {
                    string sql = $"select * from Planetas where ID={this.nomePlaneta.Text}";
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (!this.nomePlaneta.Text.Equals(""))
                {
                    string sql = $"insert into Planetas(Nome) values ({this.nomePlaneta.Text});";
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
                if (this.idPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem deletados");
                }  
                else
                {
                    string sql = $"delete from Planetas where ID={this.idPlaneta.Text};";
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.idPlaneta.Text.Equals("") || this.nomePlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Insira o id a ser atualizado");
                }
                else
                {
                    string sql = "update Planetas set Nome = '" + this.nomePlaneta.Text + "' where ID = '" + this.idPlaneta.Text + "';";
                    this.repositorio.Atualizar(sql);
                }
            }
            #endregion

            else
            {
                MessageBox.Show("Escolha uma ação");
            }
        }

        private void cbAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbAcao.Text.Equals("Inserir"))
            {
                this.label2.Visible = false;
                this.idPlaneta.Visible = false;
            }
            else
            {
                this.label2.Visible = true;
                this.idPlaneta.Visible = true;
            }
        }
    }
}
