
namespace Gerenciador_de_espaçonaves_do_star_wars
{
    partial class StarWars
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConexaoTeste = new System.Windows.Forms.Button();
            this.btnNaves = new System.Windows.Forms.Button();
            this.btnPilotos = new System.Windows.Forms.Button();
            this.btnPlanetas = new System.Windows.Forms.Button();
            this.btnViagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema da Resistência";
            // 
            // btnConexaoTeste
            // 
            this.btnConexaoTeste.Location = new System.Drawing.Point(311, 166);
            this.btnConexaoTeste.Name = "btnConexaoTeste";
            this.btnConexaoTeste.Size = new System.Drawing.Size(151, 23);
            this.btnConexaoTeste.TabIndex = 1;
            this.btnConexaoTeste.Text = "Testar Conexão";
            this.btnConexaoTeste.UseVisualStyleBackColor = true;
            this.btnConexaoTeste.Click += new System.EventHandler(this.btnConexaoTeste_Click);
            // 
            // btnNaves
            // 
            this.btnNaves.Location = new System.Drawing.Point(126, 195);
            this.btnNaves.Name = "btnNaves";
            this.btnNaves.Size = new System.Drawing.Size(119, 23);
            this.btnNaves.TabIndex = 2;
            this.btnNaves.Text = "Naves";
            this.btnNaves.UseVisualStyleBackColor = true;
            this.btnNaves.Visible = false;
            this.btnNaves.Click += new System.EventHandler(this.btnNaves_Click);
            // 
            // btnPilotos
            // 
            this.btnPilotos.Location = new System.Drawing.Point(251, 195);
            this.btnPilotos.Name = "btnPilotos";
            this.btnPilotos.Size = new System.Drawing.Size(130, 23);
            this.btnPilotos.TabIndex = 3;
            this.btnPilotos.Text = "Pilotos";
            this.btnPilotos.UseVisualStyleBackColor = true;
            this.btnPilotos.Visible = false;
            this.btnPilotos.Click += new System.EventHandler(this.btnPilotos_Click);
            // 
            // btnPlanetas
            // 
            this.btnPlanetas.Location = new System.Drawing.Point(387, 195);
            this.btnPlanetas.Name = "btnPlanetas";
            this.btnPlanetas.Size = new System.Drawing.Size(147, 23);
            this.btnPlanetas.TabIndex = 4;
            this.btnPlanetas.Text = "Planetas";
            this.btnPlanetas.UseVisualStyleBackColor = true;
            this.btnPlanetas.Visible = false;
            this.btnPlanetas.Click += new System.EventHandler(this.btnPlanetas_Click);
            // 
            // btnViagens
            // 
            this.btnViagens.Location = new System.Drawing.Point(540, 195);
            this.btnViagens.Name = "btnViagens";
            this.btnViagens.Size = new System.Drawing.Size(138, 23);
            this.btnViagens.TabIndex = 5;
            this.btnViagens.Text = "Historico De Viagens";
            this.btnViagens.UseVisualStyleBackColor = true;
            this.btnViagens.Visible = false;
            this.btnViagens.Click += new System.EventHandler(this.btnViagens_Click);
            // 
            // StarWars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.btnViagens);
            this.Controls.Add(this.btnPlanetas);
            this.Controls.Add(this.btnPilotos);
            this.Controls.Add(this.btnNaves);
            this.Controls.Add(this.btnConexaoTeste);
            this.Controls.Add(this.label1);
            this.Name = "StarWars";
            this.Text = "Sistema da Resistência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConexaoTeste;
        private System.Windows.Forms.Button btnNaves;
        private System.Windows.Forms.Button btnPilotos;
        private System.Windows.Forms.Button btnPlanetas;
        private System.Windows.Forms.Button btnViagens;
    }
}