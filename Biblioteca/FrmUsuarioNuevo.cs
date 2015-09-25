using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmUsuarioNuevo : Form
    {
        public FrmUsuarioNuevo()
        {
            InitializeComponent();
        }

        private void FrmUsuarioNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text == "") || (txtpassword.Text == "") && (txtpass2.Text == "") || (txtnombre.Text == "") ||
                (txtapellido.Text == "") && (txtdni.Text == "") || (cbsexo.Text == "") || (txtdomicilio.Text == "") || 
                (txtprovincia.Text == "") || (txtlocalidad.Text == "") ||
                (txtcp.Text == "") || (txtobservacion.Text == ""))
            {
                MessageBox.Show("Los campos marcados con * son obligatorios");
            }
            else
            {
                string permiso = "Administrador";

                if (rbtnlimitado.Checked == true)
                {
                    permiso = "Limitado";
                }
                else
                {
                    permiso = "Administrador";
                }
                if (txtpassword.Text == txtpass2.Text)
                {
                    int estado = 1;
                    brl.agregarUsuarioBdLogin(txtusuario.Text,
                        txtpassword.Text,
                        permiso.ToString(),
                        txtnombre.Text,
                        txtapellido.Text,
                        txtdni.Text,
                        dtpfecha_nac.ToString(),
                        cbsexo.Text,
                        txtcel.Text,
                        txttel_fijo.Text,
                        txtdomicilio.Text,
                        txtprovincia.Text,
                        txtlocalidad.Text,
                        txtcp.Text,
                        estado,
                        txtobservacion.Text);
                    MessageBox.Show("Usuario agregado en la base de datos");
                    txtusuario.Clear();
                    txtpassword.Clear();
                    txtpass2.Clear();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    txtdni.Clear();
                    txtcel.Clear();
                    txttel_fijo.Clear();
                    txtdomicilio.Clear();
                    txtprovincia.Clear();
                    txtlocalidad.Clear();
                    txtcp.Clear();
                    txtobservacion.Clear();
                }
                else
                {
                    MessageBox.Show("El password no coincide");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().ShowDialog();
        }
    }
}
