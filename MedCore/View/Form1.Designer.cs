namespace MedCore
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.BackgroundLogin = new System.Windows.Forms.PictureBox();
            this.BotãoLogin001 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLogin0001 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin001 = new System.Windows.Forms.TextBox();
            this.txtLogin002 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundLogin
            // 
            this.BackgroundLogin.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundLogin.Image")));
            this.BackgroundLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("BackgroundLogin.InitialImage")));
            this.BackgroundLogin.Location = new System.Drawing.Point(-8, -32);
            this.BackgroundLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundLogin.MaximumSize = new System.Drawing.Size(1118, 728);
            this.BackgroundLogin.MinimumSize = new System.Drawing.Size(1118, 728);
            this.BackgroundLogin.Name = "BackgroundLogin";
            this.BackgroundLogin.Size = new System.Drawing.Size(1118, 728);
            this.BackgroundLogin.TabIndex = 0;
            this.BackgroundLogin.TabStop = false;
            // 
            // BotãoLogin001
            // 
            this.BotãoLogin001.BackColor = System.Drawing.Color.Turquoise;
            this.BotãoLogin001.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotãoLogin001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoLogin001.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotãoLogin001.Location = new System.Drawing.Point(45, 562);
            this.BotãoLogin001.Name = "BotãoLogin001";
            this.BotãoLogin001.Size = new System.Drawing.Size(415, 41);
            this.BotãoLogin001.TabIndex = 1;
            this.BotãoLogin001.Text = "Entrar";
            this.BotãoLogin001.UseVisualStyleBackColor = false;
            this.BotãoLogin001.Click += new System.EventHandler(this.BotãoLogin001_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seja Bem-Vindo!";
            // 
            // comboBoxLogin0001
            // 
            this.comboBoxLogin0001.AllowDrop = true;
            this.comboBoxLogin0001.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxLogin0001.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxLogin0001.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogin0001.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLogin0001.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLogin0001.ForeColor = System.Drawing.Color.Black;
            this.comboBoxLogin0001.Items.AddRange(new object[] {
            "Médico",
            "Secretaria"});
            this.comboBoxLogin0001.Location = new System.Drawing.Point(45, 334);
            this.comboBoxLogin0001.Name = "comboBoxLogin0001";
            this.comboBoxLogin0001.Size = new System.Drawing.Size(415, 31);
            this.comboBoxLogin0001.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário:";
            // 
            // txtLogin001
            // 
            this.txtLogin001.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin001.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin001.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin001.ForeColor = System.Drawing.Color.Black;
            this.txtLogin001.Location = new System.Drawing.Point(45, 418);
            this.txtLogin001.MaxLength = 20;
            this.txtLogin001.Name = "txtLogin001";
            this.txtLogin001.Size = new System.Drawing.Size(415, 27);
            this.txtLogin001.TabIndex = 5;
            this.txtLogin001.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLogin002
            // 
            this.txtLogin002.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin002.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin002.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin002.ForeColor = System.Drawing.Color.Black;
            this.txtLogin002.Location = new System.Drawing.Point(45, 499);
            this.txtLogin002.MaxLength = 8;
            this.txtLogin002.Name = "txtLogin002";
            this.txtLogin002.Size = new System.Drawing.Size(415, 27);
            this.txtLogin002.TabIndex = 7;
            this.txtLogin002.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin002.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione sua área:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1102, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin002);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogin001);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLogin0001);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotãoLogin001);
            this.Controls.Add(this.BackgroundLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDCORE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundLogin;
        private System.Windows.Forms.Button BotãoLogin001;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLogin0001;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin001;
        private System.Windows.Forms.TextBox txtLogin002;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

