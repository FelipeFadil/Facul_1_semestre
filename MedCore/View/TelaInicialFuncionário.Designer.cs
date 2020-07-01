namespace MedCore
{
    partial class TelaInicialFuncionário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialFuncionário));
            this.txtInicialFuncPesquisa = new System.Windows.Forms.TextBox();
            this.btTelaCadastroPaciente = new System.Windows.Forms.Button();
            this.btTelaCadastroMedico = new System.Windows.Forms.Button();
            this.btTelaCadastroFuncionario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInicialFuncPesquisa
            // 
            this.txtInicialFuncPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicialFuncPesquisa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicialFuncPesquisa.Location = new System.Drawing.Point(875, 27);
            this.txtInicialFuncPesquisa.MaxLength = 40;
            this.txtInicialFuncPesquisa.Name = "txtInicialFuncPesquisa";
            this.txtInicialFuncPesquisa.Size = new System.Drawing.Size(414, 24);
            this.txtInicialFuncPesquisa.TabIndex = 1;
            this.txtInicialFuncPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInicialFuncPesquisa_KeyDown);
            // 
            // btTelaCadastroPaciente
            // 
            this.btTelaCadastroPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btTelaCadastroPaciente.FlatAppearance.BorderSize = 0;
            this.btTelaCadastroPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaCadastroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaCadastroPaciente.Location = new System.Drawing.Point(-10, 188);
            this.btTelaCadastroPaciente.Name = "btTelaCadastroPaciente";
            this.btTelaCadastroPaciente.Size = new System.Drawing.Size(418, 99);
            this.btTelaCadastroPaciente.TabIndex = 2;
            this.btTelaCadastroPaciente.Text = "CADASTRO PACIENTE";
            this.btTelaCadastroPaciente.UseVisualStyleBackColor = false;
            this.btTelaCadastroPaciente.Click += new System.EventHandler(this.btTelaCadastroPaciente_Click);
            // 
            // btTelaCadastroMedico
            // 
            this.btTelaCadastroMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btTelaCadastroMedico.FlatAppearance.BorderSize = 0;
            this.btTelaCadastroMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaCadastroMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaCadastroMedico.Location = new System.Drawing.Point(-10, 288);
            this.btTelaCadastroMedico.Name = "btTelaCadastroMedico";
            this.btTelaCadastroMedico.Size = new System.Drawing.Size(418, 99);
            this.btTelaCadastroMedico.TabIndex = 3;
            this.btTelaCadastroMedico.Text = "CADASTRO MÉDICO";
            this.btTelaCadastroMedico.UseVisualStyleBackColor = false;
            this.btTelaCadastroMedico.Click += new System.EventHandler(this.btTelaCadastroMedico_Click);
            // 
            // btTelaCadastroFuncionario
            // 
            this.btTelaCadastroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btTelaCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btTelaCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaCadastroFuncionario.Location = new System.Drawing.Point(-10, 388);
            this.btTelaCadastroFuncionario.Name = "btTelaCadastroFuncionario";
            this.btTelaCadastroFuncionario.Size = new System.Drawing.Size(418, 99);
            this.btTelaCadastroFuncionario.TabIndex = 4;
            this.btTelaCadastroFuncionario.Text = "CADASTRO FUNCIONÁRIO\r\n";
            this.btTelaCadastroFuncionario.UseVisualStyleBackColor = false;
            this.btTelaCadastroFuncionario.Click += new System.EventHandler(this.btTelaCadastroFuncionario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 728);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // TelaInicialFuncionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btTelaCadastroFuncionario);
            this.Controls.Add(this.btTelaCadastroMedico);
            this.Controls.Add(this.btTelaCadastroPaciente);
            this.Controls.Add(this.txtInicialFuncPesquisa);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicialFuncionário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDCORE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaInicialFuncionário_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInicialFuncPesquisa;
        private System.Windows.Forms.Button btTelaCadastroPaciente;
        private System.Windows.Forms.Button btTelaCadastroMedico;
        private System.Windows.Forms.Button btTelaCadastroFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}