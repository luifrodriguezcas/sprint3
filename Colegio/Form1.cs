using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDgrdEstudiante();
        }

        private void cargarDgrdEstudiante()
        {
            colegioTICEntities contexto = new colegioTICEntities();
            dgrEstudiantes.DataSource = contexto.estudiante.ToList();
        }

        private void limpiarCajas()
        {
            txtDireccion.Text = "";
            txtNomApellidos.Text = "";
            txtNumIdentificacion.Text = "";
            txtTelefono.Text = "";
        }

        private void lblNomApellido_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sIdentificacion = txtNumIdentificacion.Text;
            string sNombreApellido = txtNomApellidos.Text;
            DateTime dFechaNacimiento = dtpNacimiento.Value;
            string sDireccion = txtDireccion.Text;
            string sTelefono = txtTelefono.Text;

            // Validamos que no esten vacias las cajas de texto
            if (String.IsNullOrEmpty(sIdentificacion) && String.IsNullOrEmpty(sNombreApellido) && String.IsNullOrEmpty(sDireccion) && String.IsNullOrEmpty(sTelefono))
            {
                MessageBox.Show("Uno o Varios campos vacios", "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (colegioTICEntities contexto = new colegioTICEntities())
                {
                    estudiante Estudiante = new estudiante
                    {
                        numeroIdentificacion = sIdentificacion,
                        nombreApellido = sNombreApellido,
                        fechaNacimiento = dFechaNacimiento,
                        direcion = sDireccion,
                        telefono = sTelefono
                    };

                    try
                    {
                        contexto.estudiante.Add(Estudiante);
                        contexto.SaveChanges();
                        cargarDgrdEstudiante();

                        MessageBox.Show("Se ha agregado el estudiante exitosamente!!!", "Colegio - MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        string mensaje = "Error message: " + ex.Message;

                        MessageBox.Show("No se ha podido almacenar datos:" + mensaje, "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}