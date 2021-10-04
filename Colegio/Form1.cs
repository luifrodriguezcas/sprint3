using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Colegio
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDgrdEstudiante();
        }

        private void cargarDgrdEstudiante()
        {
            try
            {
                colegioTICEntities contexto = new colegioTICEntities();
                dgrEstudiantes.DataSource = contexto.estudiante.ToList();
            }
            catch (Exception ex)
            {
                string mensaje = "Error message: " + ex.Message;

                MessageBox.Show("No se puede conectar a la Base de datos:" + mensaje, "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCajas()
        {
            txtDireccion.Text = "";
            txtNomApellidos.Text = "";
            txtNumIdentificacion.Text = "";
            txtTelefono.Text = "";
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            dtpNacimiento.Value = Convert.ToDateTime(date);
        }

        private void LlenarCajas()
        {
            this.lblCodigo.Text = dgrEstudiantes.SelectedRows[0].Cells[0].Value.ToString();
            this.txtNumIdentificacion.Text = dgrEstudiantes.SelectedRows[0].Cells[1].Value.ToString();
            this.txtNomApellidos.Text = dgrEstudiantes.SelectedRows[0].Cells[2].Value.ToString();
            this.txtDireccion.Text = dgrEstudiantes.SelectedRows[0].Cells[4].Value.ToString();
            this.txtTelefono.Text = dgrEstudiantes.SelectedRows[0].Cells[5].Value.ToString();

            string fn = dgrEstudiantes.SelectedRows[0].Cells[3].Value.ToString();
            dtpNacimiento.Value = Convert.ToDateTime(fn);
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
                MessageBox.Show("No se puede Almacernar el Estudiante, Uno o Varios campos vacios", "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (colegioTICEntities contexto = new colegioTICEntities())
                {
                   // estudiante c = contexto.estudiante.FirstOrDefault(x => x.numeroIdentificacion == sIdentificacion);                    
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
                        MessageBox.Show("No se puede Almacernar el Estudiante:" + mensaje, "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                      
                }
            }
        }

        private void dgrEstudiantes_Click(object sender, EventArgs e)
        {
            LlenarCajas();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sIdentificacion = txtNumIdentificacion.Text;
            string sNombreApellido = txtNomApellidos.Text;
            DateTime dFechaNacimiento = dtpNacimiento.Value;
            string sDireccion = txtDireccion.Text;
            string sTelefono = txtTelefono.Text;
            int iCodigo = Convert.ToInt16(this.lblCodigo.Text);

            // Validamos que no esten vacias las cajas de texto
            if (String.IsNullOrEmpty(sIdentificacion) && String.IsNullOrEmpty(sNombreApellido) && String.IsNullOrEmpty(sDireccion) && String.IsNullOrEmpty(sTelefono))
            {
                MessageBox.Show("No se puede Actualizar, Uno o Varios campos vacios", "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (colegioTICEntities contexto = new colegioTICEntities())
                {
                    try
                    {
                        estudiante c = contexto.estudiante.FirstOrDefault(x => x.id == iCodigo);

                        c.numeroIdentificacion = sIdentificacion;
                        c.nombreApellido = sNombreApellido;
                        c.fechaNacimiento = dFechaNacimiento;
                        c.direcion = sDireccion;
                        c.telefono = sTelefono;

                        contexto.SaveChanges();
                        cargarDgrdEstudiante();

                        MessageBox.Show("Se ha actualizado el estudiante exitosamente!!!", "Colegio - MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        string mensaje = "Error message: " + ex.Message;
                        MessageBox.Show("No se ha podido actualizar el estudiente:" + mensaje, "MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int iCodigo = Convert.ToInt16(this.lblCodigo.Text);
            using (colegioTICEntities contexto = new colegioTICEntities())
            {
                estudiante c = contexto.estudiante.FirstOrDefault(x => x.id == iCodigo);
                contexto.estudiante.Remove(c);
                contexto.SaveChanges();
                cargarDgrdEstudiante();

                MessageBox.Show("Se ha Eliminado el estudiante exitosamente!!!", "Colegio - MisionTIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}