
namespace Gerenciador_de_espaçonaves_do_star_wars
{
    partial class Viagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeroViagem = new System.Windows.Forms.TextBox();
            this.nomePiloto = new System.Windows.Forms.TextBox();
            this.nomeNave = new System.Windows.Forms.TextBox();
            this.dataSaida = new System.Windows.Forms.TextBox();
            this.dataChegada = new System.Windows.Forms.TextBox();
            this.cbAcao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroViagem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChegada = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroViagem
            // 
            this.numeroViagem.Location = new System.Drawing.Point(118, 119);
            this.numeroViagem.Name = "numeroViagem";
            this.numeroViagem.Size = new System.Drawing.Size(121, 20);
            this.numeroViagem.TabIndex = 0;
            // 
            // nomePiloto
            // 
            this.nomePiloto.Location = new System.Drawing.Point(118, 145);
            this.nomePiloto.Name = "nomePiloto";
            this.nomePiloto.Size = new System.Drawing.Size(121, 20);
            this.nomePiloto.TabIndex = 1;
            // 
            // nomeNave
            // 
            this.nomeNave.Location = new System.Drawing.Point(118, 171);
            this.nomeNave.Name = "nomeNave";
            this.nomeNave.Size = new System.Drawing.Size(121, 20);
            this.nomeNave.TabIndex = 2;
            // 
            // dataSaida
            // 
            this.dataSaida.Location = new System.Drawing.Point(118, 197);
            this.dataSaida.Name = "dataSaida";
            this.dataSaida.Size = new System.Drawing.Size(121, 20);
            this.dataSaida.TabIndex = 3;
            // 
            // dataChegada
            // 
            this.dataChegada.Location = new System.Drawing.Point(118, 223);
            this.dataChegada.Name = "dataChegada";
            this.dataChegada.Size = new System.Drawing.Size(121, 20);
            this.dataChegada.TabIndex = 4;
            // 
            // cbAcao
            // 
            this.cbAcao.FormattingEnabled = true;
            this.cbAcao.Items.AddRange(new object[] {
            "Buscar",
            "Inserir",
            "Deletar",
            "Atualizar"});
            this.cbAcao.Location = new System.Drawing.Point(118, 29);
            this.cbAcao.Name = "cbAcao";
            this.cbAcao.Size = new System.Drawing.Size(121, 21);
            this.cbAcao.TabIndex = 5;
            this.cbAcao.Text = "Selecione";
            this.cbAcao.SelectedIndexChanged += new System.EventHandler(this.cbAcao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ação";
            // 
            // lblNumeroViagem
            // 
            this.lblNumeroViagem.AutoSize = true;
            this.lblNumeroViagem.Location = new System.Drawing.Point(15, 122);
            this.lblNumeroViagem.Name = "lblNumeroViagem";
            this.lblNumeroViagem.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroViagem.TabIndex = 7;
            this.lblNumeroViagem.Text = "Numero da Viagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Piloto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Saída";
            // 
            // lblChegada
            // 
            this.lblChegada.AutoSize = true;
            this.lblChegada.Location = new System.Drawing.Point(21, 230);
            this.lblChegada.Name = "lblChegada";
            this.lblChegada.Size = new System.Drawing.Size(91, 13);
            this.lblChegada.TabIndex = 11;
            this.lblChegada.Text = "Data de Chegada";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 270);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblChegada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroViagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAcao);
            this.Controls.Add(this.dataChegada);
            this.Controls.Add(this.dataSaida);
            this.Controls.Add(this.nomeNave);
            this.Controls.Add(this.nomePiloto);
            this.Controls.Add(this.numeroViagem);
            this.Name = "Viagens";
            this.Text = "Viagens";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroViagem;
        private System.Windows.Forms.TextBox nomePiloto;
        private System.Windows.Forms.TextBox nomeNave;
        private System.Windows.Forms.TextBox dataSaida;
        private System.Windows.Forms.TextBox dataChegada;
        private System.Windows.Forms.ComboBox cbAcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroViagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblChegada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}