
namespace Gerenciador_de_espaçonaves_do_star_wars
{
    partial class Pilotos
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
            this.pilotoId = new System.Windows.Forms.TextBox();
            this.pilotoNome = new System.Windows.Forms.TextBox();
            this.planeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPiloto = new System.Windows.Forms.DataGridView();
            this.cbAcao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiloto)).BeginInit();
            this.SuspendLayout();
            // 
            // pilotoId
            // 
            this.pilotoId.Location = new System.Drawing.Point(158, 118);
            this.pilotoId.Name = "pilotoId";
            this.pilotoId.Size = new System.Drawing.Size(121, 20);
            this.pilotoId.TabIndex = 0;
            // 
            // pilotoNome
            // 
            this.pilotoNome.Location = new System.Drawing.Point(158, 176);
            this.pilotoNome.Name = "pilotoNome";
            this.pilotoNome.Size = new System.Drawing.Size(121, 20);
            this.pilotoNome.TabIndex = 1;
            // 
            // planeta
            // 
            this.planeta.Location = new System.Drawing.Point(158, 236);
            this.planeta.Name = "planeta";
            this.planeta.Size = new System.Drawing.Size(121, 20);
            this.planeta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Planeta ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPiloto
            // 
            this.dataGridViewPiloto.AllowUserToAddRows = false;
            this.dataGridViewPiloto.AllowUserToDeleteRows = false;
            this.dataGridViewPiloto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiloto.Location = new System.Drawing.Point(358, 12);
            this.dataGridViewPiloto.Name = "dataGridViewPiloto";
            this.dataGridViewPiloto.ReadOnly = true;
            this.dataGridViewPiloto.Size = new System.Drawing.Size(379, 335);
            this.dataGridViewPiloto.TabIndex = 7;
            // 
            // cbAcao
            // 
            this.cbAcao.FormattingEnabled = true;
            this.cbAcao.Items.AddRange(new object[] {
            "Buscar",
            "Inserir",
            "Deletar",
            "Atualizar"});
            this.cbAcao.Location = new System.Drawing.Point(158, 13);
            this.cbAcao.Name = "cbAcao";
            this.cbAcao.Size = new System.Drawing.Size(121, 21);
            this.cbAcao.TabIndex = 8;
            this.cbAcao.Text = "Selecione a ação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ação";
            // 
            // Pilotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAcao);
            this.Controls.Add(this.dataGridViewPiloto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planeta);
            this.Controls.Add(this.pilotoNome);
            this.Controls.Add(this.pilotoId);
            this.Name = "Pilotos";
            this.Text = "Pilotos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiloto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pilotoId;
        private System.Windows.Forms.TextBox pilotoNome;
        private System.Windows.Forms.TextBox planeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPiloto;
        private System.Windows.Forms.ComboBox cbAcao;
        private System.Windows.Forms.Label label4;
    }
}