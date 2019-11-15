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
    
    public partial class rEditorial : Form
    {
        private RepositorioBase<Editorial> Base;
        public rEditorial()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IdEditorialnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
           
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Base = new RepositorioBase<Editorial>(new DAL.Contexto());
            Editorial Ed = Base.Buscar((int)IdEditorialnumericUpDown.Value);
            return (Ed != null);
        }
        private void LlenaCampo(Editorial Ed)
        {
            IdEditorialnumericUpDown.Value = Ed.EditorialId;
            NombretextBox.Text = Ed.Nombre;
            DireccionTextBox.Text = Ed.Dirrecion;
        }
        private Editorial LlenaClase()
        {
            Editorial Ed = new Editorial();
            Ed.EditorialId = Convert.ToInt32(IdEditorialnumericUpDown.Value);
            Ed.Nombre = NombretextBox.Text;
            Ed.Dirrecion = DireccionTextBox.Text;
          
            return Ed;
        }

        private void REditorial_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Base = new RepositorioBase<Editorial>(new Contexto());
            Editorial tipo;
            bool paso = false;
            tipo = LlenaClase();
            if (!validar())
               return;
            
            if (IdEditorialnumericUpDown.Value == 0)
            {
                paso = Base.Guardar(tipo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificr un editorial no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = Base.Modificar(tipo);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool validar()
        {
            bool paso = true;
           
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "El campo no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyerrorProvider.SetError(DireccionTextBox, "El Campo no debe estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Base = new RepositorioBase<Editorial>(new Contexto());
            int.TryParse(IdEditorialnumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MyerrorProvider.SetError(IdEditorialnumericUpDown, "No Existe");
                IdEditorialnumericUpDown.Focus();
                return;
            }
            if (Base.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Base = new RepositorioBase<Editorial>(new Contexto());
            int.TryParse(IdEditorialnumericUpDown.Text, out int id);
            Editorial tipos = new Editorial();
            tipos = Base.Buscar(id);

            if (tipos != null)
            {
               
                LlenaCampo(tipos);
            }
            else
            {
                MessageBox.Show("No encontrado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
