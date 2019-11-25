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
using System.Text.RegularExpressions;
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
            LlenaCombox();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            MatriculatextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            EmailtextBox.Text = string.Empty;
            UsuariocomboBox.SelectedItem = -1;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            Estudiante estudiante = Estudent.Buscar((int)IDnumericUpDown.Value);
            return (estudiante != null);
        }
        private bool ValidarMatricula()
        {
            bool realizado = true;
            RepositorioBase<Estudiante> generica = new RepositorioBase<Estudiante>(new Contexto());
            List<Estudiante> estudiantes = generica.GetList(d => d.Matricula.Contains(MatriculatextBox.Text));

            if (estudiantes != null)
            {
                realizado = false;
            }
            return realizado;
        }
        private Boolean EmailValido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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
            if (string.IsNullOrWhiteSpace(MatriculatextBox.Text))
            {
                MyerrorProvider.SetError(MatriculatextBox, "El campo no debe estar vacio");
                MatriculatextBox.Focus();
                paso = false;
            }
           
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "El campo no debe estar vacio");
               EmailtextBox.Focus();
                paso = false;
            }
            if (ValidaEmail())
            {
                MyerrorProvider.SetError(EmailtextBox, "Ya existe un estudiante con este Email");
                EmailtextBox.Focus();
                paso = false;
            }
            if (!EmailValido(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "Email no valido");
                EmailtextBox.Focus();
                paso = false;
            }
            if (ValidarMatricula())
            {
                MyerrorProvider.SetError(MatriculatextBox, "Ya existe un estudiante con esta matricula");
                MatriculatextBox.Focus();
                paso = false;
            }
            if (ValidarCelular())
            {
                MyerrorProvider.SetError(CelularMaskedTextBox, "Ya existe un estudiante con este celular");
                CelularMaskedTextBox.Focus();
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
            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyerrorProvider.SetError(CelularMaskedTextBox, "El Campo no debe estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(UsuariocomboBox.Text))
            {
                MyerrorProvider.SetError(UsuariocomboBox, "El Campo no debe estar vacio");
                UsuariocomboBox.Focus();
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
        private bool ValidaEmail()
        {
            bool realizado = true;
            RepositorioBase<Estudiante> generica = new RepositorioBase<Estudiante>(new Contexto());
            List<Estudiante> estudiantes = generica.GetList(d => d.Email.Contains(EmailtextBox.Text));

            if (estudiantes != null)
            {
                realizado = false;
            }
            return realizado;
        }
        private Estudiante LlenaClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteId = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Nombres = NombretextBox.Text;
            estudiante.Apellidos = ApellidotextBox.Text;
            estudiante.Matricula = MatriculatextBox.Text;
            estudiante.Celular = CelularMaskedTextBox.Text;
            estudiante.Direccion = DirecciontextBox.Text;
            estudiante.FechaInsercion = FechadateTimePicker.Value;
            estudiante.Email = EmailtextBox.Text;
            estudiante.UsuarioId = Convert.ToInt32(UsuariocomboBox.SelectedValue);



            return estudiante;

        }
        private void LlenaCampo(Estudiante estudiante)
        {

            IDnumericUpDown.Value = estudiante.EstudianteId;
            NombretextBox.Text = estudiante.Nombres;
            ApellidotextBox.Text = estudiante.Apellidos;
            MatriculatextBox.Text = estudiante.Matricula;
            DirecciontextBox.Text = estudiante.Direccion;
            CelularMaskedTextBox.Text = estudiante.Celular;
            FechadateTimePicker.Value = estudiante.FechaInsercion;
            EmailtextBox.Text = estudiante.Email;
            LlenaCombox();
        }

        private void REstudiante_Load(object sender, EventArgs e)
        {

        }

        private void MatriculatextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void LlenaCombox()
        {
            RepositorioBase<Usuarios> Ed = new RepositorioBase<Usuarios>(new Contexto());
            
            UsuariocomboBox.DataSource = Ed.GetList(c => true);
            UsuariocomboBox.ValueMember = "UsuarioId";
            UsuariocomboBox.DisplayMember = "Nombres";

        }
        private bool ValidarCelular()
        {
            bool realizado = true;
           RepositorioBase<Estudiante> generic = new RepositorioBase<Estudiante>(new Contexto());
            List<Estudiante> Estudent = generic.GetList(d => d.Celular.Contains(CelularMaskedTextBox.Text));

            if (Estudent != null)
            {
                realizado = false;
            }
            return realizado;
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

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
