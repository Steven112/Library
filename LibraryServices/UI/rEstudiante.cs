using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryServices.UI
{
    public partial class rEstudiante : Form
    {
        private RepositorioBase<Estudiante> Estudent;
        public rEstudiante()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            MatriculatextBox.Text = string.Empty;
            NoTelefonoMaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            Estudiante estudiante = Estudent.Buscar((int)IDnumericUpDown.Value);
            return (estudiante != null);
        }

        private bool validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "El campo no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ApellidotextBox.Text))
            {
                MyerrorProvider.SetError(ApellidotextBox, "El campo no debe estar vacio");
                ApellidotextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyerrorProvider.SetError(DirecciontextBox, "El Campo no debe estar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NoTelefonoMaskedTextBox.Text))
            {
                MyerrorProvider.SetError(NoTelefonoMaskedTextBox, "El Campo no debe estar vacio");
                NoTelefonoMaskedTextBox.Focus();
                paso = false;
            }
           
            if (FechadateTimePicker.Value > DateTime.Now)
            {
                MyerrorProvider.SetError(FechadateTimePicker, "La fecha no es correcta");
                FechadateTimePicker.Focus();
                paso = false;
            }
            return paso;
        }
        private Estudiante LlenaClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteId = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Nombre = NombretextBox.Text;
            estudiante.Apellido = ApellidotextBox.Text;
            estudiante.Matricula = MatriculatextBox.Text;
            estudiante.Telefono = NoTelefonoMaskedTextBox.Text;
            estudiante.Direccion = DirecciontextBox.Text;
            estudiante.FechaInsercion = FechadateTimePicker.Value;

            
            return estudiante;

        }
        private void LlenaCampo(Estudiante estudiante)
        {

            IDnumericUpDown.Value = estudiante.EstudianteId;
            NombretextBox.Text = estudiante.Nombre;
            ApellidotextBox.Text = estudiante.Apellido;
            MatriculatextBox.Text = estudiante.Matricula;
            DirecciontextBox.Text = estudiante.Direccion;
            NoTelefonoMaskedTextBox.Text = estudiante.Telefono;
            FechadateTimePicker.Value = estudiante.FechaInsercion;
        }

        private void REstudiante_Load(object sender, EventArgs e)
        {

        }

        private void MatriculatextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            Estudiante estudiante;
            bool paso = false;

            if (!validar())
            {
                MessageBox.Show("Debe Llenar los Campos Indicados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estudiante = LlenaClase();

                if (IDnumericUpDown.Value == 0)
                {
                    paso = Estudent.Guardar(estudiante);
                    MyerrorProvider.Clear();
                }
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar un estudiante no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    paso = Estudent.Modificar(estudiante);

                }
                if (paso)
                {
                    MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {

                    MessageBox.Show("Error al guardar", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            int.TryParse(IDnumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MyerrorProvider.SetError(IDnumericUpDown, "No Existe");
                IDnumericUpDown.Focus();
                return;
            }
            if (Estudent.Eliminar(id))
            {
                MessageBox.Show("Eliminado Correctamente", "Exito", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            int.TryParse(IDnumericUpDown.Text, out int id);
            Estudiante estudiante = new Estudiante();
            estudiante = Estudent.Buscar(id);

            if (estudiante != null)
            {
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("No Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
