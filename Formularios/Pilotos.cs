using Gerenciador_de_espaçonaves_do_star_wars.Repositorio;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_espaçonaves_do_star_wars
{
    public partial class Pilotos : Form
    {
        private StarWarsRepositorio repositorio = new StarWarsRepositorio();
        public Pilotos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            #region
            if (this.cbAcao.Text.Equals("Buscar"))
            {
                if (this.pilotoId.Text.Equals(""))
                {
                    string sql = "select * from Pilotos";
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }     
                else
                {
                    string sql = $"select * from Pilotos where id={this.pilotoId.Text};";
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (this.pilotoNome.Text.Equals("") || this.planeta.Text.Equals(""))
                {
                    MessageBox.Show("Digite os dados a serem inseridos");
                }
                
                else
                {
                    string sql = $"insert into Pilotos(Nome, PlanetaID) values ('{this.pilotoNome.Text}', {this.planeta.Text});";
                    this.repositorio.Inserir(sql);
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.pilotoId.Text.Equals(""))
                {
                    MessageBox.Show("Informe o id a ser deletado");
                }
                else
                {
                    string sql = $"delete Pilotos where id={this.pilotoId.Text};";
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.pilotoId.Text.Equals("") || this.pilotoNome.Text.Equals("") || this.planeta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else
                {
                    string sql = $"update Pilotos set Nome='{this.pilotoNome.Text}', PlanetaID={this.planeta.Text};";
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
