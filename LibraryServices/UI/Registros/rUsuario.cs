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

namespace LibraryServices.UI.Registros
{
    public partial class rUsuario : Form
    {
        private RepositorioBase<Usuarios> repositorio;
        EncryptKey encryptKey = new EncryptKey();
        public rUsuario()
        {
            InitializeComponent();
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            UsuariocomboBox.SelectedItem = 0;
        }
        private Usuarios LlenaClase()

        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(IdNumericUpDown.Value);
            usuarios.Nombres = NombresTextBox.Text;
            usuarios.Email = EmailTextBox.Text;
            usuarios.Celular = CelularMaskedTextBox.Text;
            string c = encryptKey.cifrarTexto(ContraseñaTextBox.Text);
            usuarios.Contraseña = c;
            usuarios.FechaInsercion = FechadateTimePicker.Value;
            usuarios.Nivel = Convert.ToString(UsuariocomboBox.SelectedItem);            
            return usuarios;
        }
        private void LlenaCampo(Usuarios usuarios)
        {
            IdNumericUpDown.Value = usuarios.UsuarioId;
            NombresTextBox.Text = usuarios.Nombres;
            EmailTextBox.Text = usuarios.Email;
            CelularMaskedTextBox.Text = usuarios.Celular;
            ContraseñaTextBox.Text = usuarios.Contraseña;
            FechadateTimePicker.Value = usuarios.FechaInsercion;
            UsuariocomboBox.SelectedItem= usuarios.Nivel;
            
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            Usuarios user = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (user != null);
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
        private bool ValidaEmail()
        {
            bool realizado = true;
            RepositorioBase<Usuarios> generica = new RepositorioBase<Usuarios>(new Contexto());
            List<Usuarios> estudiantes = generica.GetList(d => d.Email.Contains(EmailTextBox.Text));

            if (estudiantes != null)
            {
                realizado = false;
            }
            return realizado;
        }
        private bool ValidarNombre()
        {
            bool realizado = true;

            List<Usuarios> productores = UsuariosBLL.GetList(d => (d.Nombres ).Contains(NombresTextBox.Text ));

            if (productores != null)
            {
                realizado = false;
            }
            return realizado;
        }
        private bool ValidarCelular()
        {
            bool realizado = true;
            RepositorioBase<Usuarios> generic = new RepositorioBase<Usuarios>(new Contexto());
            List<Usuarios> user = generic.GetList(d => d.Celular.Contains(CelularMaskedTextBox.Text));

            if (user != null)
            {
                realizado = false;
            }
            return realizado;
        }
        private bool validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (ValidarCelular())
            {
                MyerrorProvider.SetError(CelularMaskedTextBox, "Ya existe un usuario con este celular");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (ValidaEmail())
            {
                MyerrorProvider.SetError(EmailTextBox, "Ya existe un usuario con este Email");
                EmailTextBox.Focus();
                paso = false;
            }
            if (!EmailValido(EmailTextBox.Text))
            {
                MyerrorProvider.SetError(EmailTextBox, "Email no valido");
                EmailTextBox.Focus();
                paso = false;
            }
            if (ContraseñaTextBox.Text == NombresTextBox.Text)
            {
                MyerrorProvider.SetError(ContraseñaTextBox, "La contraseña no debe ser igual al nombre");
                ContraseñaTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyerrorProvider.SetError(NombresTextBox, "El campo no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyerrorProvider.SetError(EmailTextBox, "El campo no puedes estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            if (ValidarNombre())
            {
                MyerrorProvider.SetError(NombresTextBox, "Ya existe un usuario con esa y ese nombre contraseña");
                NombresTextBox.Focus();
              

                paso = false;
            }
            if (string.IsNullOrWhiteSpace(UsuariocomboBox.Text))
            {
                MyerrorProvider.SetError(UsuariocomboBox, "El campo no puedes estar vacio");
                UsuariocomboBox.Focus();
                paso = false;
            }
            


            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyerrorProvider.SetError(CelularMaskedTextBox, "El campo no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñaTextBox, "El campo no puede estar vacio");
                ContraseñaTextBox.Focus();
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            Usuarios usuarios;
            bool paso = false;
            usuarios = LlenaClase();
            if (!validar())

                return;

            if (IdNumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(usuarios);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = repositorio.Modificar(usuarios);
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            int.TryParse(IdNumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MyerrorProvider.SetError(IdNumericUpDown, "No existe ese usuario");
                IdNumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
            int.TryParse(IdNumericUpDown.Text, out int id);
            Usuarios usuarios= new Usuarios();
            usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
            {
                LlenaCampo(usuarios);
            }
            else
            {
                LlenaCampo(usuarios);
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
