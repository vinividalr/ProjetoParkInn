namespace ProjetoParkInn
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_DataCliente = new System.Windows.Forms.MaskedTextBox();
            this.msk_CPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_RGCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ConfirmaCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR NOVO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(222, 146);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(190, 20);
            this.txt_NomeCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento:";
            // 
            // msk_DataCliente
            // 
            this.msk_DataCliente.Location = new System.Drawing.Point(222, 196);
            this.msk_DataCliente.Mask = "00/00/0000";
            this.msk_DataCliente.Name = "msk_DataCliente";
            this.msk_DataCliente.Size = new System.Drawing.Size(190, 20);
            this.msk_DataCliente.TabIndex = 4;
            this.msk_DataCliente.ValidatingType = typeof(System.DateTime);
            // 
            // msk_CPFCliente
            // 
            this.msk_CPFCliente.Location = new System.Drawing.Point(222, 252);
            this.msk_CPFCliente.Mask = "000,000,000-00";
            this.msk_CPFCliente.Name = "msk_CPFCliente";
            this.msk_CPFCliente.Size = new System.Drawing.Size(190, 20);
            this.msk_CPFCliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF:";
            // 
            // msk_RGCliente
            // 
            this.msk_RGCliente.Location = new System.Drawing.Point(222, 309);
            this.msk_RGCliente.Mask = "00,000,000-0";
            this.msk_RGCliente.Name = "msk_RGCliente";
            this.msk_RGCliente.Size = new System.Drawing.Size(190, 20);
            this.msk_RGCliente.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "RG:";
            // 
            // btn_ConfirmaCliente
            // 
            this.btn_ConfirmaCliente.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaCliente.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaCliente.Location = new System.Drawing.Point(247, 354);
            this.btn_ConfirmaCliente.Name = "btn_ConfirmaCliente";
            this.btn_ConfirmaCliente.Size = new System.Drawing.Size(150, 40);
            this.btn_ConfirmaCliente.TabIndex = 9;
            this.btn_ConfirmaCliente.Text = "CONFIRMAR";
            this.btn_ConfirmaCliente.UseVisualStyleBackColor = false;
            this.btn_ConfirmaCliente.Click += new System.EventHandler(this.btn_ConfirmaCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ConfirmaCliente);
            this.Controls.Add(this.msk_RGCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msk_CPFCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msk_DataCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_DataCliente;
        private System.Windows.Forms.MaskedTextBox msk_CPFCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msk_RGCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ConfirmaCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}