using Gerenciador_de_espaçonaves_do_star_wars.Repositorio;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_espaçonaves_do_star_wars
{
    public partial class Naves : Form
    {
        private StarWarsRepositorio repositorio = new StarWarsRepositorio();
        public Naves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            #region
            if (this.cbAcao.Text.Equals("Buscar"))
            {
                
                if (this.idNave.Text.Equals(""))
                {
                    string sql = "select * from Naves";
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
                else
                {
                    string sql = $"select * from Naves where id={this.idNave.Text};";
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe os valores a serem inseridos");
                }
                else
                {
                    string sql = $"insert into Naves(Nome) values ('{this.nomeNave.Text}');";
                    this.repositorio.Inserir(sql);
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.idNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem deletados");
                }
                else
                {
                    string sql = "delete from Naves where id=" + this.idNave.Text + ";";
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.idNave.Text.Equals("") || this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Insira o id a ser atualizado");
                }
                
                else
                {
                    string sql = "update Naves set Nome = '" + this.nomeNave.Text + "' where id = " + this.idNave.Text + ";";
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
                this.label3.Visible = false;
                this.idNave.Visible = false;
            }
            else
            {
                this.label3.Visible = true;
                this.idNave.Visible = true;
            }
        }
    }
}
