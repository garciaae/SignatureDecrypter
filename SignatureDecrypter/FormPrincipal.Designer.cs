namespace SignatureDecrypter
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnDesencriptarPrivada = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEncriptacionPrivada = new System.Windows.Forms.Button();
            this.txtTextoAEncriptar = new System.Windows.Forms.TextBox();
            this.lblTextoAEncriptar = new System.Windows.Forms.Label();
            this.btnDesencriptarPublica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(3, 22);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(274, 94);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnDesencriptarPrivada
            // 
            this.btnDesencriptarPrivada.Location = new System.Drawing.Point(283, 20);
            this.btnDesencriptarPrivada.Name = "btnDesencriptarPrivada";
            this.btnDesencriptarPrivada.Size = new System.Drawing.Size(205, 23);
            this.btnDesencriptarPrivada.TabIndex = 5;
            this.btnDesencriptarPrivada.Text = "Desencriptar el portapapeles cl. privada";
            this.btnDesencriptarPrivada.UseVisualStyleBackColor = true;
            this.btnDesencriptarPrivada.Click += new System.EventHandler(this.btnDesencriptarPrivada_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(55, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Resultado";
            // 
            // btnEncriptacionPrivada
            // 
            this.btnEncriptacionPrivada.AccessibleDescription = "Encripta un mensaje para darle autenticidad";
            this.btnEncriptacionPrivada.Location = new System.Drawing.Point(283, 191);
            this.btnEncriptacionPrivada.Name = "btnEncriptacionPrivada";
            this.btnEncriptacionPrivada.Size = new System.Drawing.Size(156, 23);
            this.btnEncriptacionPrivada.TabIndex = 7;
            this.btnEncriptacionPrivada.Text = "Encriptacion privada";
            this.btnEncriptacionPrivada.UseVisualStyleBackColor = true;
            this.btnEncriptacionPrivada.Click += new System.EventHandler(this.btnEncriptacionPrivada_Click);
            // 
            // txtTextoAEncriptar
            // 
            this.txtTextoAEncriptar.Location = new System.Drawing.Point(9, 193);
            this.txtTextoAEncriptar.Multiline = true;
            this.txtTextoAEncriptar.Name = "txtTextoAEncriptar";
            this.txtTextoAEncriptar.Size = new System.Drawing.Size(268, 77);
            this.txtTextoAEncriptar.TabIndex = 8;
            // 
            // lblTextoAEncriptar
            // 
            this.lblTextoAEncriptar.AutoSize = true;
            this.lblTextoAEncriptar.Location = new System.Drawing.Point(9, 177);
            this.lblTextoAEncriptar.Name = "lblTextoAEncriptar";
            this.lblTextoAEncriptar.Size = new System.Drawing.Size(83, 13);
            this.lblTextoAEncriptar.TabIndex = 9;
            this.lblTextoAEncriptar.Text = "Introduzca texto";
            // 
            // btnDesencriptarPublica
            // 
            this.btnDesencriptarPublica.Location = new System.Drawing.Point(283, 49);
            this.btnDesencriptarPublica.Name = "btnDesencriptarPublica";
            this.btnDesencriptarPublica.Size = new System.Drawing.Size(205, 23);
            this.btnDesencriptarPublica.TabIndex = 10;
            this.btnDesencriptarPublica.Text = "Desencriptar el portapapeles cl. pública";
            this.btnDesencriptarPublica.UseVisualStyleBackColor = true;
            this.btnDesencriptarPublica.Click += new System.EventHandler(this.btnDesencriptarPublica_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 334);
            this.Controls.Add(this.btnDesencriptarPublica);
            this.Controls.Add(this.lblTextoAEncriptar);
            this.Controls.Add(this.txtTextoAEncriptar);
            this.Controls.Add(this.btnEncriptacionPrivada);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDesencriptarPrivada);
            this.Controls.Add(this.txtMensaje);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "SOLTEL: Signature decryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnDesencriptarPrivada;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEncriptacionPrivada;
        private System.Windows.Forms.TextBox txtTextoAEncriptar;
        private System.Windows.Forms.Label lblTextoAEncriptar;
        private System.Windows.Forms.Button btnDesencriptarPublica;
    }
}

