using Gerenciador_de_espaçonaves_do_star_wars.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                
                if (this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    string sql = "select * from Naves";
                    MessageBox.Show("Selecionando todo mundo da tabela naves");
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
                else if(this.idNave.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    string sql = "select Nome from Naves where Nome='" + this.nomeNave.Text + "';";
                    MessageBox.Show("Buscando pelo nome");
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
                else if (!this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    string sql = "select id from Naves where id='" + this.idNave.Text + "';";
                    MessageBox.Show("Buscando pelo id");
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
                else
                {
                    string sql = "select * from Naves where id='" + this.idNave.Text + "' and Nome='" + this.nomeNave.Text + "';";
                    MessageBox.Show("Buscando por id e nome");
                    this.repositorio.Buscar(sql, this.dataGridViewNaves);
                }
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                if (this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe os valores a serem inseridos");
                }
                else if (this.idNave.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    string sql = "insert into Naves(Nome) values(" + this.nomeNave + ");";
                    MessageBox.Show("Inserindo pelo nome");
                    this.repositorio.Inserir(sql);
                }
                else if (!this.idNave.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    string sql = "insert into Naves(id, Nome) values(" + this.idNave + "," + this.nomeNave + ");";
                    MessageBox.Show("Inserindo pelo nome e id");
                    this.repositorio.Inserir(sql);
                }
                else
                {
                    MessageBox.Show("Insira o nome da Nave");
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem deletados");
                }
                else if (this.idNave.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    string sql = "delete * from Naves where Nome='" + this.nomeNave + "';";
                    MessageBox.Show("Deletando pelo nome");
                    this.repositorio.Deletar(sql); 
                }
                else if (!this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    string sql = "delete * from Naves where id='" + this.idNave.Text + "';";
                    MessageBox.Show("Deletando pelo id");
                    this.repositorio.Deletar(sql);
                }
                else
                {
                    string sql = "delete * from Naves where id='" + this.idNave.Text + "' and Nome='" + this.nomeNave.Text + "';";
                    MessageBox.Show("Deletando pelo id e nome");
                    this.repositorio.Deletar(sql);
                }
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Insira os dados para atualizar");
                }
                else if (this.idNave.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe o id que deseja atualizar e o novo nome");
                }
                else if (!this.idNave.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    MessageBox.Show("Informe o nome a substituir");
                }
                else
                {
                    string sql = "update Naves set Nome = '" + this.nomeNave.Text + "' where id = '" + this.idNave.Text + "';";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
