namespace AgendaWinFormsSQLite
{
    partial class Form1
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
            lbId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            lbNome = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtTel = new TextBox();
            lbTel = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btExcluir = new Button();
            btLocalizar = new Button();
            dgvDados = new DataGridView();
            lbDados = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(14, 23);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(59, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(338, 23);
            txtNome.TabIndex = 3;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(14, 52);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(42, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "NOME";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 23);
            txtEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(14, 81);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 15);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "E-MAIL";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(215, 20);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(185, 23);
            txtTel.TabIndex = 7;
            // 
            // lbTel
            // 
            lbTel.AutoSize = true;
            lbTel.Location = new Point(147, 23);
            lbTel.Name = "lbTel";
            lbTel.Size = new Size(62, 15);
            lbTel.TabIndex = 6;
            lbTel.Text = "TELEFONE";
            // 
            // btInserir
            // 
            btInserir.Location = new Point(433, 20);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(83, 36);
            btInserir.TabIndex = 8;
            btInserir.Text = "INSERIR";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(522, 20);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(83, 36);
            btAlterar.TabIndex = 9;
            btAlterar.Text = "ALTERAR";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(433, 65);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(83, 36);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "EXCLUIR";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(522, 65);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(83, 36);
            btLocalizar.TabIndex = 10;
            btLocalizar.Text = "LOCALIZAR";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(14, 124);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(591, 216);
            dgvDados.TabIndex = 12;
            // 
            // lbDados
            // 
            lbDados.AutoSize = true;
            lbDados.Location = new Point(14, 352);
            lbDados.Name = "lbDados";
            lbDados.Size = new Size(219, 15);
            lbDados.TabIndex = 13;
            lbDados.Text = "Local onde os dados estão armazenados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 384);
            Controls.Add(lbDados);
            Controls.Add(dgvDados);
            Controls.Add(btExcluir);
            Controls.Add(btLocalizar);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(txtTel);
            Controls.Add(lbTel);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Name = "Form1";
            Text = "Agenda de Contatos - Thyago Santorini";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lbNome;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtTel;
        private Label lbTel;
        private Button btInserir;
        private Button btAlterar;
        private Button btExcluir;
        private Button btLocalizar;
        private DataGridView dgvDados;
        private Label lbDados;
    }
}
