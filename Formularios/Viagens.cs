using Gerenciador_de_espaçonaves_do_star_wars.Repositorio;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_espaçonaves_do_star_wars
{
    public partial class Viagens : Form
    {
        private StarWarsRepositorio repositorio = new StarWarsRepositorio();
        public Viagens()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            #region
            if (this.cbAcao.Text.Equals("Buscar"))
            {
                if (this.numeroViagem.Text.Equals(""))
                {
                    string sql = $"select * from HistoricoViagens;";
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else
                {
                    string sql = $"select * from HistoricoViagens where id = 1;";
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                
                if (this.piloto.Text.Equals("") || this.nave.Text.Equals("") || this.dataSaida.Text.Equals(""))
                {
                    MessageBox.Show("Digite os dados a serem inseridos");
                }
                else
                {
                    string sql = "insert into HistoricoViagens(Pilotoid, Naveid, DataSaida) values ('" + this.piloto.Text + "', '" + this.nave.Text + "', '" + this.dataSaida.Text + "');";
                    this.repositorio.InserirViagens(sql, this.piloto.Text);
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.numeroViagem.Text.Equals(""))
                {
                    MessageBox.Show("Informe o numero da viagem a ser deletado");
                }
                else
                {
                    string sql = "delete from HistoricoViagens where id=" + this.numeroViagem.Text + ";";                    
                    this.repositorio.Deletar(sql);
                }                
            }
            #endregion

            //Atualizar
            #region
            else if (this.cbAcao.Text.Equals("Atualizar"))
            {
                if (this.numeroViagem.Text.Equals(""))
                {
                    MessageBox.Show("informe o id a ser atualizado e os novos dados");
                }
                else if(this.piloto.Text.Equals("") || this.nave.Text.Equals("") || this.dataSaida.Text.Equals("") || this.dataChegada.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados a serem atualizados");
                }
                else
                {
                    string sql = $"update HistoricoViagens set Pilotoid={this.piloto.Text}, Naveid={nave.Text}, DataSaida='{this.dataSaida.Text}', DataChegada='{this.dataChegada.Text}' where id={this.numeroViagem.Text}";
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
                this.lblNumeroViagem.Visible = false;
                this.lblChegada.Visible = false;
                this.dataChegada.Visible = false;
                this.numeroViagem.Visible = false;
            }
            else
            {
                this.lblNumeroViagem.Visible = true;
                this.lblChegada.Visible = true;
                this.dataChegada.Visible = true;
                this.numeroViagem.Visible = true;
            }
        }
    }
}
