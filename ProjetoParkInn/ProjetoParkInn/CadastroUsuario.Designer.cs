namespace ProjetoParkInn
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.btn_ConfirmaUsuario = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SenhaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msk_RGUsuario = new System.Windows.Forms.MaskedTextBox();
            this.msk_CPFUsuario = new System.Windows.Forms.MaskedTextBox();
            this.cb_PermissaoUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConfirmaUsuario
            // 
            this.btn_ConfirmaUsuario.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaUsuario.Location = new System.Drawing.Point(292, 351);
            this.btn_ConfirmaUsuario.Name = "btn_ConfirmaUsuario";
            this.btn_ConfirmaUsuario.Size = new System.Drawing.Size(150, 40);
            this.btn_ConfirmaUsuario.TabIndex = 0;
            this.btn_ConfirmaUsuario.Text = "CONFIRMAR";
            this.btn_ConfirmaUsuario.UseVisualStyleBackColor = false;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(426, 131);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(31, 14);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permissão:";
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Location = new System.Drawing.Point(189, 147);
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(132, 20);
            this.txt_NomeUsuario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // txt_EmailUsuario
            // 
            this.txt_EmailUsuario.Location = new System.Drawing.Point(189, 205);
            this.txt_EmailUsuario.Name = "txt_EmailUsuario";
            this.txt_EmailUsuario.Size = new System.Drawing.Size(132, 20);
            this.txt_EmailUsuario.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail:";
            // 
            // txt_SenhaUsuario
            // 
            this.txt_SenhaUsuario.Location = new System.Drawing.Point(189, 265);
            this.txt_SenhaUsuario.Name = "txt_SenhaUsuario";
            this.txt_SenhaUsuario.PasswordChar = '*';
            this.txt_SenhaUsuario.Size = new System.Drawing.Size(132, 20);
            this.txt_SenhaUsuario.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "CADASTRAR NOVO USUÁRIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // msk_RGUsuario
            // 
            this.msk_RGUsuario.Location = new System.Drawing.Point(429, 206);
            this.msk_RGUsuario.Mask = "00,000,000-0";
            this.msk_RGUsuario.Name = "msk_RGUsuario";
            this.msk_RGUsuario.Size = new System.Drawing.Size(141, 20);
            this.msk_RGUsuario.TabIndex = 15;
            // 
            // msk_CPFUsuario
            // 
            this.msk_CPFUsuario.Location = new System.Drawing.Point(429, 148);
            this.msk_CPFUsuario.Mask = "000,000,000-00";
            this.msk_CPFUsuario.Name = "msk_CPFUsuario";
            this.msk_CPFUsuario.Size = new System.Drawing.Size(141, 20);
            this.msk_CPFUsuario.TabIndex = 16;
            // 
            // cb_PermissaoUsuario
            // 
            this.cb_PermissaoUsuario.FormattingEnabled = true;
            this.cb_PermissaoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cb_PermissaoUsuario.Location = new System.Drawing.Point(429, 265);
            this.cb_PermissaoUsuario.Name = "cb_PermissaoUsuario";
            this.cb_PermissaoUsuario.Size = new System.Drawing.Size(141, 21);
            this.cb_PermissaoUsuario.TabIndex = 17;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.cb_PermissaoUsuario);
            this.Controls.Add(this.msk_CPFUsuario);
            this.Controls.Add(this.msk_RGUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SenhaUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_EmailUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btn_ConfirmaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmaUsuario;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmailUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SenhaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox msk_RGUsuario;
        private System.Windows.Forms.MaskedTextBox msk_CPFUsuario;
        private System.Windows.Forms.ComboBox cb_PermissaoUsuario;
    }
}