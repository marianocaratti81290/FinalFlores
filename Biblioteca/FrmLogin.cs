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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario");
            }
            if (txtpass.Text == "")
            { 
                MessageBox.Show ("Ingrese la contraseña");
            }
            if (txtusuario.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Ingrese usuario y password");
            }
            else
            {
                int existe = brl.logearUsuario(txtusuario.Text, txtpass.Text);

                if (existe == 1)
                {
                    new FrmPrincipal().ShowDialog();
                }
                else
                {
                    MessageBox.Show ("No esta registrado");
                }
            }
        }

        private void btnUsuarioNuevo_Click(object sender, EventArgs e)
        {          
            new FrmUsuarioNuevo().ShowDialog();
            this.Close();
        }
    }
}
