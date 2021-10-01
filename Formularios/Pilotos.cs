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
                if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos";
                    MessageBox.Show("Selecionando todo mundo da tabela Pilotos");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where id='" + this.pilotoId.Text + "';";
                    MessageBox.Show("Buscando pelo id");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where Nome='" + this.pilotoNome.Text + "';";
                    MessageBox.Show("Buscando pelo Nome");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where Planeta='" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Buscando pelo Planeta");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where Nome='" + this.pilotoNome.Text + "' and Planeta = '" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Buscando pelo nome e planeta");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where id='" + this.pilotoId.Text + "' and Planeta = '" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Buscando pelo id e planeta");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else if (!this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "select * from Pilotos where Nome='" + this.pilotoNome.Text + "' and id = '" + this.pilotoId.Text + "';";
                    MessageBox.Show("Buscando pelo id e nome");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
                else
                {
                    string sql = "select * from Pilotos where id='" + this.pilotoId.Text + "' and Nome='" + this.pilotoNome.Text + "' and Planeta='" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Buscando por id nome e planeta");
                    repositorio.Buscar(sql, this.dataGridViewPiloto);
                }
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Digite os dados a serem inseridos");
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Digite os dados a serem inseridos");
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe o planeta que o piloto nasceu");
                }
                else if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe o nome do piloto");
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "insert into Pilotos(Nome, Planeta) values('" + this.pilotoNome.Text + "', '" + this.pilotoPlaneta.Text + "');";
                    MessageBox.Show("Inserindo pelo nome e planeta");
                    this.repositorio.Inserir(sql);
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {                    
                    MessageBox.Show("Informe o nome do piloto");
                }
                else if (!this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {                    
                    MessageBox.Show("Informe o planeta q o piloto nasceu");
                }
                else
                {
                    string sql = "insert into Pilotos(id, Nome, Planeta) values ('" + this.pilotoId.Text + "', '" + this.pilotoNome.Text + "', '" + this.pilotoPlaneta.Text + "');";
                    MessageBox.Show("Inserindo por id nome e planeta");
                    this.repositorio.Inserir(sql);
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem deletados");
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Pilotos where id='" + this.pilotoId.Text + "';";
                    MessageBox.Show("Deletando pelo id");
                    this.repositorio.Deletar(sql);
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from pilotos where Nome='" + this.pilotoNome.Text + "';";
                    MessageBox.Show("Deletando pelo Nome");
                    this.repositorio.Deletar(sql);
                }
                else if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from pilotos where Planeta = '" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Deletando pelo Planeta");
                    this.repositorio.Deletar(sql);
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Pilotos where Nome='" + this.pilotoNome.Text + "' and Planeta = '" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Deletando pelo nome e planeta");
                    this.repositorio.Deletar(sql);
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Pilotos where id='" + this.pilotoId.Text + "' and Planeta = '" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Deletando pelo id e planeta");
                    this.repositorio.Deletar(sql);
                }
                else if (!this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "delete * from Pilotos where Nome='" + this.pilotoNome.Text + "' and id = '" + this.pilotoId.Text + "';";
                    MessageBox.Show("Deletando pelo id e nome");
                    this.repositorio.Deletar(sql);
                }
                else
                {
                    string sql = "select * from Pilotos where id='" + this.pilotoId.Text + "' and Nome='" + this.pilotoNome.Text + "' and Planeta='" + this.pilotoPlaneta.Text + "';";
                    MessageBox.Show("Deletando por id nome e planeta");
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if (this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if (this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if (!this.pilotoId.Text.Equals("") && this.pilotoNome.Text.Equals("") && !this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "update Pilotos set Planeta = '" + this.pilotoPlaneta.Text + "' where id= '" + this.pilotoId.Text + "' ;";
                    MessageBox.Show("Atualizando planeta");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.pilotoId.Text.Equals("") && !this.pilotoNome.Text.Equals("") && this.pilotoPlaneta.Text.Equals(""))
                {
                    string sql = "update Pilotos set Nome = '" + this.pilotoNome.Text + "' where id= '" + this.pilotoId.Text + "' ;";
                    MessageBox.Show("Atualizando Nome");
                    this.repositorio.Atualizar(sql);
                }
                else
                {
                    string sql = "update Pilotos set Nome = '" + this.pilotoNome.Text + "' where id= '" + this.pilotoId.Text + "' and set Plateta ='" + this.pilotoPlaneta.Text + "' where id= '" + this.pilotoId.Text + "';";
                    MessageBox.Show("Atualizando Nome e Planeta");
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
