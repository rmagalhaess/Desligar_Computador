namespace Desligar
{
    partial class frm_Desligar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Desligar));
            this.ico_Aviso = new System.Windows.Forms.PictureBox();
            this.grp_Opcoes = new System.Windows.Forms.GroupBox();
            this.rdo_Desligar = new System.Windows.Forms.RadioButton();
            this.rdo_Reiniciar = new System.Windows.Forms.RadioButton();
            this.rdo_Hibernar = new System.Windows.Forms.RadioButton();
            this.bto_Confirmar = new System.Windows.Forms.Button();
            this.bto_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Aviso)).BeginInit();
            this.grp_Opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ico_Aviso
            // 
            this.ico_Aviso.Image = ((System.Drawing.Image)(resources.GetObject("ico_Aviso.Image")));
            this.ico_Aviso.Location = new System.Drawing.Point(32, 32);
            this.ico_Aviso.Name = "ico_Aviso";
            this.ico_Aviso.Size = new System.Drawing.Size(128, 128);
            this.ico_Aviso.TabIndex = 0;
            this.ico_Aviso.TabStop = false;
            // 
            // grp_Opcoes
            // 
            this.grp_Opcoes.Controls.Add(this.rdo_Desligar);
            this.grp_Opcoes.Controls.Add(this.rdo_Reiniciar);
            this.grp_Opcoes.Controls.Add(this.rdo_Hibernar);
            this.grp_Opcoes.Location = new System.Drawing.Point(192, 32);
            this.grp_Opcoes.Name = "grp_Opcoes";
            this.grp_Opcoes.Size = new System.Drawing.Size(336, 101);
            this.grp_Opcoes.TabIndex = 1;
            this.grp_Opcoes.TabStop = false;
            this.grp_Opcoes.Text = " Opções ";
            // 
            // rdo_Desligar
            // 
            this.rdo_Desligar.AutoSize = true;
            this.rdo_Desligar.Location = new System.Drawing.Point(22, 73);
            this.rdo_Desligar.Name = "rdo_Desligar";
            this.rdo_Desligar.Size = new System.Drawing.Size(63, 17);
            this.rdo_Desligar.TabIndex = 2;
            this.rdo_Desligar.TabStop = true;
            this.rdo_Desligar.Text = "Desligar";
            this.rdo_Desligar.UseVisualStyleBackColor = true;
            // 
            // rdo_Reiniciar
            // 
            this.rdo_Reiniciar.AutoSize = true;
            this.rdo_Reiniciar.Location = new System.Drawing.Point(22, 50);
            this.rdo_Reiniciar.Name = "rdo_Reiniciar";
            this.rdo_Reiniciar.Size = new System.Drawing.Size(66, 17);
            this.rdo_Reiniciar.TabIndex = 1;
            this.rdo_Reiniciar.TabStop = true;
            this.rdo_Reiniciar.Text = "Reiniciar";
            this.rdo_Reiniciar.UseVisualStyleBackColor = true;
            // 
            // rdo_Hibernar
            // 
            this.rdo_Hibernar.AutoSize = true;
            this.rdo_Hibernar.Location = new System.Drawing.Point(20, 27);
            this.rdo_Hibernar.Name = "rdo_Hibernar";
            this.rdo_Hibernar.Size = new System.Drawing.Size(65, 17);
            this.rdo_Hibernar.TabIndex = 0;
            this.rdo_Hibernar.TabStop = true;
            this.rdo_Hibernar.Text = "Hibernar";
            this.rdo_Hibernar.UseVisualStyleBackColor = true;
            // 
            // bto_Confirmar
            // 
            this.bto_Confirmar.Location = new System.Drawing.Point(372, 165);
            this.bto_Confirmar.Name = "bto_Confirmar";
            this.bto_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.bto_Confirmar.TabIndex = 2;
            this.bto_Confirmar.Text = "Confirmar";
            this.bto_Confirmar.UseVisualStyleBackColor = true;
            this.bto_Confirmar.Click += new System.EventHandler(this.bto_Confirmar_Click);
            // 
            // bto_Cancelar
            // 
            this.bto_Cancelar.Location = new System.Drawing.Point(453, 165);
            this.bto_Cancelar.Name = "bto_Cancelar";
            this.bto_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bto_Cancelar.TabIndex = 3;
            this.bto_Cancelar.Text = "Cancelar";
            this.bto_Cancelar.UseVisualStyleBackColor = true;
            this.bto_Cancelar.Click += new System.EventHandler(this.bto_Cancelar_Click);
            // 
            // frm_Desligar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 212);
            this.Controls.Add(this.bto_Cancelar);
            this.Controls.Add(this.bto_Confirmar);
            this.Controls.Add(this.grp_Opcoes);
            this.Controls.Add(this.ico_Aviso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Desligar";
            this.Text = "Desligar o Sistema";
            this.Load += new System.EventHandler(this.frm_Desligar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ico_Aviso)).EndInit();
            this.grp_Opcoes.ResumeLayout(false);
            this.grp_Opcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ico_Aviso;
        private System.Windows.Forms.GroupBox grp_Opcoes;
        private System.Windows.Forms.RadioButton rdo_Desligar;
        private System.Windows.Forms.RadioButton rdo_Reiniciar;
        private System.Windows.Forms.RadioButton rdo_Hibernar;
        private System.Windows.Forms.Button bto_Confirmar;
        private System.Windows.Forms.Button bto_Cancelar;
    }
}

