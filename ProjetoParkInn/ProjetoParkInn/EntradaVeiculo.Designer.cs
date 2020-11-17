namespace ProjetoParkInn
{
    partial class EntradaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PlacaVeículo = new System.Windows.Forms.TextBox();
            this.txt_ClienteVeículo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ConfirmaEntrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada de Veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Placa:";
            // 
            // txt_PlacaVeículo
            // 
            this.txt_PlacaVeículo.Location = new System.Drawing.Point(223, 140);
            this.txt_PlacaVeículo.Name = "txt_PlacaVeículo";
            this.txt_PlacaVeículo.Size = new System.Drawing.Size(197, 20);
            this.txt_PlacaVeículo.TabIndex = 19;
            // 
            // txt_ClienteVeículo
            // 
            this.txt_ClienteVeículo.Location = new System.Drawing.Point(223, 258);
            this.txt_ClienteVeículo.Name = "txt_ClienteVeículo";
            this.txt_ClienteVeículo.Size = new System.Drawing.Size(197, 20);
            this.txt_ClienteVeículo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente:";
            // 
            // txt_ModeloVeiculo
            // 
            this.txt_ModeloVeiculo.Location = new System.Drawing.Point(223, 199);
            this.txt_ModeloVeiculo.Name = "txt_ModeloVeiculo";
            this.txt_ModeloVeiculo.Size = new System.Drawing.Size(197, 20);
            this.txt_ModeloVeiculo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Modelo:";
            // 
            // btn_ConfirmaEntrada
            // 
            this.btn_ConfirmaEntrada.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaEntrada.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaEntrada.Location = new System.Drawing.Point(248, 332);
            this.btn_ConfirmaEntrada.Name = "btn_ConfirmaEntrada";
            this.btn_ConfirmaEntrada.Size = new System.Drawing.Size(150, 40);
            this.btn_ConfirmaEntrada.TabIndex = 24;
            this.btn_ConfirmaEntrada.Text = "CONFIRMAR";
            this.btn_ConfirmaEntrada.UseVisualStyleBackColor = false;
            this.btn_ConfirmaEntrada.Click += new System.EventHandler(this.btn_ConfirmaEntrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // EntradaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ConfirmaEntrada);
            this.Controls.Add(this.txt_ModeloVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ClienteVeículo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PlacaVeículo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaVeiculo";
            this.Text = "Entrada de Veículos";
            this.Load += new System.EventHandler(this.EntradaCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PlacaVeículo;
        private System.Windows.Forms.TextBox txt_ClienteVeículo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ModeloVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ConfirmaEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}