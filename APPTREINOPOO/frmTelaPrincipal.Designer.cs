namespace APPTREINOPOO
{
    partial class frmTelaPrincipal
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
            lblMarca = new Label();
            lblModelo = new Label();
            lblCor = new Label();
            lblTelefonesDisponiveis = new Label();
            lblArmazenamento = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(46, 141);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(71, 25);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(225, 141);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(83, 25);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo:";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCor.Location = new Point(402, 141);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(48, 25);
            lblCor.TabIndex = 2;
            lblCor.Text = "Cor:";
            // 
            // lblTelefonesDisponiveis
            // 
            lblTelefonesDisponiveis.AutoSize = true;
            lblTelefonesDisponiveis.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefonesDisponiveis.Location = new Point(245, 31);
            lblTelefonesDisponiveis.Name = "lblTelefonesDisponiveis";
            lblTelefonesDisponiveis.Size = new Size(284, 32);
            lblTelefonesDisponiveis.TabIndex = 3;
            lblTelefonesDisponiveis.Text = "TELEFONES DISPONÍVEIS";
            // 
            // lblArmazenamento
            // 
            lblArmazenamento.AutoSize = true;
            lblArmazenamento.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArmazenamento.Location = new Point(581, 141);
            lblArmazenamento.Name = "lblArmazenamento";
            lblArmazenamento.Size = new Size(160, 25);
            lblArmazenamento.TabIndex = 4;
            lblArmazenamento.Text = "Armazenamento:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(46, 169);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(715, 234);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.imgTelaPrincipal1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblArmazenamento);
            Controls.Add(lblTelefonesDisponiveis);
            Controls.Add(lblCor);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(pictureBox1);
            Name = "frmTelaPrincipal";
            Text = "TELEFONES DISPONÍVEIS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblModelo;
        private Label lblCor;
        private Label lblTelefonesDisponiveis;
        private Label lblArmazenamento;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}