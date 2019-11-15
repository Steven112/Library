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
using LibraryServices.BLL;
using LibraryServices.DAL;

namespace LibraryServices.UI.Registros
{
    public partial class rUsuarios : Form
    {
        
        public rUsuarios()
        {
            InitializeComponent();
            
        }
        public Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Convert.ToInt32(IdNumericUpDown.Value);
            usuario.Nombres = NombresTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.Contraseña = ContraseñaTextBox.Text;
            return usuario;
        }
        public bool Validar()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(NombresTextBox.Text))
            {
                MyerrorProvider.SetError(NombresTextBox, "Escribir nombre completo");
                paso = true;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                MyerrorProvider.SetError(EmailTextBox,  "Campo debe ser llenado correctamente");
                paso = true;
            }
            if (String.IsNullOrEmpty(CelularMaskedTextBox.Text))
            {
                MyerrorProvider.SetError(CelularMaskedTextBox, "Campo debe ser llenado correctamente");
                paso = true;
            }
            if (String.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñaTextBox, "DCampo debe ser llenado correctamente");
                paso = true;
            }

            return paso;
        }
        public void LlenaCampo(Usuarios ur)
        {
            IdNumericUpDown.Value = ur.UsuarioId;
            NombresTextBox.Text=ur.Nombres;
            EmailTextBox.Text= ur.Email;
            CelularMaskedTextBox.Text=ur.Celular;
            ContraseñaTextBox.Text=ur.Contraseña;
            FechadateTimePicker.Value = ur.FechaInsercion;
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            EmailTextBox.Clear();
            CelularMaskedTextBox.Clear();
            ContraseñaTextBox.Clear();
            MyerrorProvider.Clear();
            FechadateTimePicker.Value = DateTime.Now;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            
            Usuarios usu = UsuariosBLL.Buscar((int)IdNumericUpDown.Value);
            return (usu != null);
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios user= new Usuarios();
            bool paso = false;

            if (Validar())
                return;
       
            user = LlenaClase();

            if (IdNumericUpDown.Value == 0)
            {
                 paso = UsuariosBLL.Guardar(user);
                 MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
              {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = UsuariosBLL.Modificar(user);
            }

                if (paso)
                {
                    Limpiar();
                }
                else
                    MessageBox.Show("No Guardado", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(IdNumericUpDown.Value);
            Usuarios user = new Usuarios();
            

            Limpiar();

            user = UsuariosBLL.Buscar(id);

            if (user != null)
            {
                LlenaCampo(user);
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(IdNumericUpDown.Value);
            Contexto db = new Contexto();

            Usuarios usuario = new Usuarios();

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MyerrorProvider.SetError(IdNumericUpDown, "No se puede eliminar la asignatura");
            }
        }
    }
}
