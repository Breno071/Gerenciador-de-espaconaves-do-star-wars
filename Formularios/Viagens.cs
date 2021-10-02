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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            #region
            if (this.cbAcao.Text.Equals("Buscar"))
            {
                if (this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = "select * from HistoricoViagens";
                    MessageBox.Show("Selecionando todo mundo da tabela HistoricoViagens");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = "select * from HistoricoViagens where NumeroViagem='" + this.numeroViagem.Text + "';";
                    MessageBox.Show("Buscando pelo Numero da Viagem");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = "select * from HistoricoViagens where Piloto='" + this.nomePiloto.Text + "';";
                    MessageBox.Show("Buscando pelo Piloto");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("select * from HistoricoViagens where Piloto='{0}' and NumeroViagem='{1}'", this.nomePiloto.Text, this.numeroViagem.Text);
                    MessageBox.Show("Buscando pelo Piloto e id");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = "select * from HistoricoViagens where Nave='" + this.nomeNave.Text + "';";
                    MessageBox.Show("Buscando pelo Planeta");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals(""))
                {
                    string sql = "select * from HistoricoViagens where Nave='" + this.nomeNave.Text + "';";
                    MessageBox.Show("Buscando pelo Planeta");
                    this.repositorio.Buscar(sql, this.dataGridView1);
                }
                
            }
            #endregion

            //Inserir
            #region
            else if (this.cbAcao.Text.Equals("Inserir"))
            {
                
                if (this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    MessageBox.Show("Digite os dados a serem inseridos");
                }
                else if (!this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && !this.dataSaida.Text.Equals(""))
                {
                    string sql = "insert into HistoricoViagens(Piloto, Nave, DataSaida) values ('" + this.nomePiloto.Text + "', '" + this.nomeNave.Text + "', '" + this.dataSaida.Text + "');";
                    MessageBox.Show("Inserindo na tabela");
                    this.repositorio.Inserir(sql);
                }
                else
                {
                    MessageBox.Show("Informe os dados a serem inseridos");
                }
            }
            #endregion

            //Deletar
            #region
            else if (this.cbAcao.Text.Equals("Deletar"))
            {
                if (this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    MessageBox.Show("Informe o numero da viagem a ser deletado");
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals(""))
                {
                    string sql = "delete from HistoricoViagens where numeroViagem=" + this.numeroViagem.Text + ";";
                    MessageBox.Show("Deletando pelo numero da viagem");
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
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}' where NumeroViagem='{1}'",this.nomePiloto.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando piloto");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}', Nave='{1}' where NumeroViagem={2}", this.nomePiloto.Text, this.nomeNave.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando piloto e nave");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && !this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}', Nave='{1}', DataSaida='{2}' where NumeroViagem={3};", this.nomePiloto.Text, this.nomeNave.Text, this.dataSaida.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Piloto nave e data de saida");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && !this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Nave='{0}', DataSaida='{1}', DataChegada='{2}' where NumeroViagem={3};", this.nomeNave.Text, this.dataSaida.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Nave data de saida e data de chegada");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && !this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set DataSaida='{0}', DataChegada='{1}' where NumeroViagem={2});", this.dataSaida.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando data de chegada e data de saida");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Nave='{0}', DataChegada='{1}' where NumeroViagem={2}", this.nomeNave.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Nave e data de chegada");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}', DataChegada='{1}' where NumeroViagem={2}", this.nomePiloto.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Piloto e data de chegada");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set DataChegada='{0}' where NumeroViagem={1}", this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando data de chegada");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && !this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Nave='{0}', DataSaida='{1}', where NumeroViagem={2}", this.nomeNave.Text, this.dataSaida.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando nave e data de saida");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && !this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && !this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}'. Nave='{1}', DataChegada='{2}' where numeroViagem={3}",this.nomePiloto.Text, this.nomeNave.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Piloto nave e data de chegada");
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && !this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    string sql = String.Format("update HistoricoViagens set Nave='{0}' where='{1}'", this.nomeNave.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando Nave");
                    this.repositorio.Atualizar(sql);
                }
                else if (!this.numeroViagem.Text.Equals("") && this.nomePiloto.Text.Equals("") && this.nomeNave.Text.Equals("") && this.dataSaida.Text.Equals("") && this.dataChegada.Text.Equals(""))
                {
                    MessageBox.Show("Insira os dados a serem atualizados");
                }  
                else
                {
                    string sql = String.Format("update HistoricoViagens set Piloto='{0}', Nave='{1}', DataSaida='{2}', DataChegada='{3}' where NumeroViagem='{4}'", this.nomePiloto.Text, this.nomeNave.Text, this.dataSaida.Text, this.dataChegada.Text, this.numeroViagem.Text);
                    MessageBox.Show("Atualizando todos os dados");
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
