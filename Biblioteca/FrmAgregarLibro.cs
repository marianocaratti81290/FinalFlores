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
    public partial class FrmAgregarLibro : Form
    {
        public FrmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text == "")
            {
                MessageBox.Show("El campo titulo es obligatorio");
            }
            else
                if (txtautor.Text == "")
                {
                    MessageBox.Show("El campo autor es obligatorio");
                }
                else
                    if (txteditorial.Text == "")
                    {
                        MessageBox.Show("El campo editorial es obligatorio");
                    }
                    else
                        if (txtanio.Text == "")
                        {
                            MessageBox.Show("El campo año es obligatorio");
                        }
                        else
                            if (txtgenero.Text == "")
                            {
                                MessageBox.Show("El campo genero es obligatorio");
                            }
                            else
                                if (txtpaginas.Text == "")
                                {
                                    MessageBox.Show("El campo paginas es obligatorio");
                                }
                                else
                                    if (txtestado.Text == "")
                                    {
                                        MessageBox.Show("El campo estado es obligatorio");
                                    }
                                    else
                                    {                                        
                                        brl.agregarLibros(txttitulo.Text, txtautor.Text, txteditorial.Text, txtanio.Text, txtgenero.Text, txtpaginas.Text,
                                            Convert.ToInt32(txtestado.Text), txtobservacion.Text);

                                        MessageBox.Show("Libro insertado correctamente");
                                        txttitulo.Clear();
                                        txtautor.Clear();
                                        txteditorial.Clear();
                                        txtanio.Clear();
                                        txtgenero.Clear();
                                        txtpaginas.Clear();
                                        txtestado.Clear();
                                        txtobservacion.Clear();

                                    }

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmPrincipal().ShowDialog();
        }
    }
}
