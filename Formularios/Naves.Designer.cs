
namespace Gerenciador_de_espaçonaves_do_star_wars
{
    partial class Naves
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewNaves = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idNave = new System.Windows.Forms.TextBox();
            this.nomeNave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAcao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNaves
            // 
            this.dataGridViewNaves.AllowUserToAddRows = false;
            this.dataGridViewNaves.AllowUserToDeleteRows = false;
            this.dataGridViewNaves.AllowUserToResizeColumns = false;
            this.dataGridViewNaves.AllowUserToResizeRows = false;
            this.dataGridViewNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNaves.Location = new System.Drawing.Point(255, 12);
            this.dataGridViewNaves.Name = "dataGridViewNaves";
            this.dataGridViewNaves.ReadOnly = true;
            this.dataGridViewNaves.Size = new System.Drawing.Size(258, 248);
            this.dataGridViewNaves.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idNave
            // 
            this.idNave.Location = new System.Drawing.Point(74, 89);
            this.idNave.Name = "idNave";
            this.idNave.Size = new System.Drawing.Size(121, 20);
            this.idNave.TabIndex = 12;
            // 
            // nomeNave
            // 
            this.nomeNave.Location = new System.Drawing.Point(74, 125);
            this.nomeNave.Name = "nomeNave";
            this.nomeNave.Size = new System.Drawing.Size(121, 20);
            this.nomeNave.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome";
            // 
            // cbAcao
            // 
            this.cbAcao.FormattingEnabled = true;
            this.cbAcao.Items.AddRange(new object[] {
            "Buscar",
            "Inserir",
            "Deletar",
            "Atualizar"});
            this.cbAcao.Location = new System.Drawing.Point(74, 22);
            this.cbAcao.Name = "cbAcao";
            this.cbAcao.Size = new System.Drawing.Size(121, 21);
            this.cbAcao.TabIndex = 16;
            this.cbAcao.Text = "Selecione a ação";
            this.cbAcao.SelectedIndexChanged += new System.EventHandler(this.cbAcao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ação";
            // 
            // Naves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 272);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeNave);
            this.Controls.Add(this.idNave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewNaves);
            this.Name = "Naves";
            this.Text = "Naves";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNaves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idNave;
        private System.Windows.Forms.TextBox nomeNave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAcao;
        private System.Windows.Forms.Label label5;
    }
}

