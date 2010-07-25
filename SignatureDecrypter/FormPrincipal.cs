using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using RSAEncryptionLib;

namespace SignatureDecrypter
{
    public partial class FormPrincipal : Form
    {
        // definimos la clave privada para desencriptar el mensaje
        RSAEncryption myRsa = new RSAEncryption();

        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void cargaClavePrivada()
        {
            // Cargamos la clave privada de un fichero
            try
            {
                myRsa.LoadPrivateFromXml(Path.Combine(Application.StartupPath, "PrivateKey.xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cargaClavePublica()
        {
            // Cargamos la clave pública de un fichero
            try
            {
                myRsa.LoadPublicFromXml(Path.Combine(Application.StartupPath, "PublicKey.xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEncriptacionPrivada_Click(object sender, EventArgs e)
        {
            cargaClavePrivada();
            try
            {
                byte[] message = Encoding.UTF8.GetBytes(txtTextoAEncriptar.Text);
                byte[] encMessage = null;
                encMessage = myRsa.PrivateEncryption(message);
                txtMensaje.Text = Convert.ToBase64String(encMessage);
                Clipboard.SetText(Convert.ToBase64String(encMessage));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurred while trying to encrypt the data,\nMessage: " + ex.Message);
            }
        }

        private void btnDesencriptarPrivada_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = DesencriptacionPrivada(Clipboard.GetText());
        }

        private String DesencriptacionPrivada(String mensaje)
        {
            String salida = "";
            cargaClavePrivada();
            try
            {
                byte[] decMessage = Convert.FromBase64String(mensaje);
                byte[] message = null;
                message = myRsa.PrivateDecryption(decMessage);

                string sMsg = Encoding.UTF8.GetString(message);
                salida = sMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error mientras se desencriptaban los datos,\nMessage: " + ex.Message);
            }
            return salida;
        }

        private void btnDesencriptarPublica_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = DesencriptacionPublica(Clipboard.GetText());
        }

        private String DesencriptacionPublica(String mensaje)
        {
            String salida = "";
            cargaClavePublica();
            try
            {
                byte[] decMessage = Convert.FromBase64String(mensaje);
                byte[] message = null;
                message = myRsa.PublicDecryption(decMessage);

                string sMsg = Encoding.UTF8.GetString(message);
                salida = sMsg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error mientras se desencriptaban los datos,\nMessage: " + ex.Message);
            }
            return salida;
        }

    }
}
