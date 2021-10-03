
namespace Colegio
{
    partial class frmMatricula
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNomApellido = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNumIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNomApellidos = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.gdAcciones = new System.Windows.Forms.GroupBox();
            this.dgrEstudiantes = new System.Windows.Forms.DataGridView();
            this.gbListadoEstudiantes = new System.Windows.Forms.GroupBox();
            this.gbDatosPersonales.SuspendLayout();
            this.gdAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstudiantes)).BeginInit();
            this.gbListadoEstudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(485, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MATRICULA ESTUDIANTES...";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 37);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(113, 16);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "No. Identificación:";
            // 
            // lblNomApellido
            // 
            this.lblNomApellido.AutoSize = true;
            this.lblNomApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomApellido.Location = new System.Drawing.Point(12, 72);
            this.lblNomApellido.Name = "lblNomApellido";
            this.lblNomApellido.Size = new System.Drawing.Size(130, 16);
            this.lblNomApellido.TabIndex = 2;
            this.lblNomApellido.Text = "Nombre y Apellidos:";
            this.lblNomApellido.Click += new System.EventHandler(this.lblNomApellido_Click);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(12, 107);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(139, 16);
            this.lblNacimiento.TabIndex = 3;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 142);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(68, 16);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(12, 177);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNumIdentificacion
            // 
            this.txtNumIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIdentificacion.Location = new System.Drawing.Point(157, 31);
            this.txtNumIdentificacion.MaxLength = 13;
            this.txtNumIdentificacion.Name = "txtNumIdentificacion";
            this.txtNumIdentificacion.Size = new System.Drawing.Size(134, 22);
            this.txtNumIdentificacion.TabIndex = 6;
            // 
            // txtNomApellidos
            // 
            this.txtNomApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomApellidos.Location = new System.Drawing.Point(157, 67);
            this.txtNomApellidos.MaxLength = 50;
            this.txtNomApellidos.Name = "txtNomApellidos";
            this.txtNomApellidos.Size = new System.Drawing.Size(286, 22);
            this.txtNomApellidos.TabIndex = 7;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(157, 103);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(106, 22);
            this.dtpNacimiento.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(157, 137);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(286, 22);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(157, 173);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(286, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.dtpNacimiento);
            this.gbDatosPersonales.Controls.Add(this.txtNomApellidos);
            this.gbDatosPersonales.Controls.Add(this.txtNumIdentificacion);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblNomApellido);
            this.gbDatosPersonales.Controls.Add(this.lblIdentificacion);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(29, 97);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(457, 216);
            this.gbDatosPersonales.TabIndex = 11;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(26, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(26, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 39);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(26, 149);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(170, 39);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // gdAcciones
            // 
            this.gdAcciones.Controls.Add(this.btnDel);
            this.gdAcciones.Controls.Add(this.btnUpdate);
            this.gdAcciones.Controls.Add(this.btnAdd);
            this.gdAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdAcciones.Location = new System.Drawing.Point(564, 97);
            this.gdAcciones.Name = "gdAcciones";
            this.gdAcciones.Size = new System.Drawing.Size(221, 216);
            this.gdAcciones.TabIndex = 15;
            this.gdAcciones.TabStop = false;
            this.gdAcciones.Text = "Acciones";
            // 
            // dgrEstudiantes
            // 
            this.dgrEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrEstudiantes.Location = new System.Drawing.Point(6, 30);
            this.dgrEstudiantes.Name = "dgrEstudiantes";
            this.dgrEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrEstudiantes.Size = new System.Drawing.Size(742, 213);
            this.dgrEstudiantes.TabIndex = 16;
            // 
            // gbListadoEstudiantes
            // 
            this.gbListadoEstudiantes.Controls.Add(this.dgrEstudiantes);
            this.gbListadoEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoEstudiantes.Location = new System.Drawing.Point(30, 322);
            this.gbListadoEstudiantes.Name = "gbListadoEstudiantes";
            this.gbListadoEstudiantes.Size = new System.Drawing.Size(754, 252);
            this.gbListadoEstudiantes.TabIndex = 17;
            this.gbListadoEstudiantes.TabStop = false;
            this.gbListadoEstudiantes.Text = "Estudiantes Matriculados";
            // 
            // frmMatricula
            // 
            this.ClientSize = new System.Drawing.Size(807, 586);
            this.Controls.Add(this.gbListadoEstudiantes);
            this.Controls.Add(this.gdAcciones);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula Estudiante - Colegio MisiónTIC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gdAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstudiantes)).EndInit();
            this.gbListadoEstudiantes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgrdEstudiantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNomApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNumIdentificacion;
        private System.Windows.Forms.TextBox txtNomApellidos;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox gdAcciones;
        private System.Windows.Forms.DataGridView dgrEstudiantes;
        private System.Windows.Forms.GroupBox gbListadoEstudiantes;
    }
}