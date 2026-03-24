namespace APPTREINOPOO
{
    partial class frmTelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSetor = new Label();
            lblSenha = new Label();
            txtSetorUsuario = new TextBox();
            txtSenhaUsuario = new TextBox();
            txtNomeUsuario = new TextBox();
            lblTitulo = new Label();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(125, 127);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetor.Location = new Point(125, 204);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(55, 21);
            lblSetor.TabIndex = 1;
            lblSetor.Text = "Setor:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(125, 282);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(58, 21);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtSetorUsuario
            // 
            txtSetorUsuario.Location = new Point(125, 228);
            txtSetorUsuario.Name = "txtSetorUsuario";
            txtSetorUsuario.Size = new Size(155, 23);
            txtSetorUsuario.TabIndex = 3;
            // 
            // txtSenhaUsuario
            // 
            txtSenhaUsuario.Location = new Point(125, 306);
            txtSenhaUsuario.Name = "txtSenhaUsuario";
            txtSenhaUsuario.Size = new Size(155, 23);
            txtSenhaUsuario.TabIndex = 4;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(125, 151);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(155, 23);
            txtNomeUsuario.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 32);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "ESTOQUE DE TELEFONES";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 192, 0);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(125, 366);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 32);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgTelaLogin;
            pictureBox1.Location = new Point(384, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = SystemColors.HotTrack;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(157, 83);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(76, 25);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "LOGIN:";
            // 
            // frmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Controls.Add(lblTitulo);
            Controls.Add(txtNomeUsuario);
            Controls.Add(txtSenhaUsuario);
            Controls.Add(txtSetorUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblSetor);
            Controls.Add(lblUsuario);
            Cursor = Cursors.Hand;
            Name = "frmTelaLogin";
            Text = "Aplicativo de Estoque de Telefones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSetor;
        private Label lblSenha;
        private TextBox txtSetorUsuario;
        private TextBox txtSenhaUsuario;
        private TextBox txtNomeUsuario;
        private Label lblTitulo;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label lblLogin;
    }
}
