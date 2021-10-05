using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_espaçonaves_do_star_wars.Repositorio
{
    class StarWarsRepositorio
    {
        public void Buscar(string sql, DataGridView dataGridView)
        {
            try
            {
                //Faz a conexão com o banco de dados
                string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();

                //Cria o comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);

                //O SqlDataAdapter , serve como uma ponte entre a DataSet e SQL Server para recuperar e salvar dados
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //Cria uma instância da Tabela
                DataTable table = new DataTable();

                //Preenche a tabela com os dados do banco de dados
                da.Fill(table);

                //Passa os dados da tabela para o DataGridView
                dataGridView.DataSource = table;

                //Fecha a conexão
                conn.Close();
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("" + ex);
            }
    }

        public void Inserir(string sql)
        {
            try
            {
                //Faz a conexão com o banco de dados
                string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();

                //Cria o comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + " Linhas alteradas");

                //Fecha a conexão
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0}",ex));
            }
        }

        public void Deletar(string sql)
        {
            try
            {
                //Faz a conexão com o banco de dados
                string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();

                //Cria o comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + " Linhas alteradas");

                //Fecha a conexão
                conn.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("" + ex);
            }
        }

        public void Atualizar(string sql)
        {
            try
            {
                //Faz a conexão com o banco de dados
                string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();

                //Cria o comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + " Linhas alteradas");

                //Fecha a conexão
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void BuscaViagens(string sql)
        {
            try
            {
                //Faz a conexão com o banco de dados
                string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Narde\Visual Studio\Projects\Gerenciador de espaçonaves do star wars\Gerenciador de espaçonaves do star wars\DataBase\StarWars.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();

                //Cria o comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                MessageBox.Show(cmd.ExecuteNonQuery() + " Linhas alteradas");

                //Fecha a conexão
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
