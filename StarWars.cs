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
    public partial class StarWars : Form
    {
        public StarWars()
        {
            InitializeComponent();
        }

        private void btnConexaoTeste_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"Data Source=DESKTOP-6AFO6DC\SQLEXPRESS;Initial Catalog=StarWars;Integrated Security=True";
                SqlConnection conn = new SqlConnection(conexao);
                conn.Open();
                conn.Close();
                this.btnConexaoTeste.Visible = false;
                MessageBox.Show("Tudo certo");
                this.btnNaves.Visible = true;
                this.btnPilotos.Visible = true;
                this.btnPlanetas.Visible = true;
                this.btnViagens.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo não deu certo. Você não é uma invasor é?");
            }
        }

        private void btnNaves_Click(object sender, EventArgs e)
        {
            new Naves().Show();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            new Pilotos().Show();
        }

        private void btnPlanetas_Click(object sender, EventArgs e)
        {
            new Planetas().Show();
        }

        private void btnViagens_Click(object sender, EventArgs e)
        {
            new Viagens().Show();
        }
    }
}
