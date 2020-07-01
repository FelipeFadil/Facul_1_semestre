namespace MedCore.View
{
    partial class TelaInicialMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialMedico));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInicialMedPesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 728);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtInicialMedPesquisa
            // 
            this.txtInicialMedPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicialMedPesquisa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicialMedPesquisa.Location = new System.Drawing.Point(172, 320);
            this.txtInicialMedPesquisa.MaxLength = 40;
            this.txtInicialMedPesquisa.Name = "txtInicialMedPesquisa";
            this.txtInicialMedPesquisa.Size = new System.Drawing.Size(414, 24);
            this.txtInicialMedPesquisa.TabIndex = 2;
            this.txtInicialMedPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInicialMedPesquisa_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(299, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMedico.Location = new System.Drawing.Point(12, 29);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(66, 20);
            this.lblNomeMedico.TabIndex = 12;
            this.lblNomeMedico.Text = "Médico";
            // 
            // TelaInicialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.lblNomeMedico);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtInicialMedPesquisa);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicialMedico";
            this.Text = "MEDCORE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaInicialMedico_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtInicialMedPesquisa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomeMedico;
    }
}