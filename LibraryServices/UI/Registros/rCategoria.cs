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
    public partial class rCategoria : Form
    {
        private RepositorioBase<Categoria> repos;
        public rCategoria()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IdcategorianumericUpDown.Value = 0;
            IntroduccionTextBox.Text = string.Empty;
        }


        private Categoria LlenaClase()
        {
            Categoria categoria = new Categoria();
            categoria.CategoriaId = Convert.ToInt32(IdcategorianumericUpDown.Value);
            categoria.Descripcion = IntroduccionTextBox.Text;

            return categoria;
        }
        private void LlenaCampo(Categoria cat)
        {
            IdcategorianumericUpDown.Value = cat.CategoriaId;
            IntroduccionTextBox.Text = cat.Descripcion;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            Categoria cat = repos.Buscar((int)IdcategorianumericUpDown.Value);
            return (cat != null);
        }
        private bool validar()
        {
            bool paso = true;

            
            if (string.IsNullOrWhiteSpace(IntroduccionTextBox.Text))
            {
                MyerrorProvider.SetError(IntroduccionTextBox, "El Campo no debe estar vacio");
                IntroduccionTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            Categoria cat;
            bool paso = false;
            cat = LlenaClase();
            if (!validar())
            
               return;
            
            if (IdcategorianumericUpDown.Value == 0)
            {
                paso = repos.Guardar(cat);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Categoria no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = repos.Modificar(cat);
            }
            if (paso)
            {
                MessageBox.Show("Guardado ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            int.TryParse(IdcategorianumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MyerrorProvider.SetError(IdcategorianumericUpDown, "No Existe esa Categoria");
                IdcategorianumericUpDown.Focus();
                return;
            }
            if (repos.Eliminar(id))
            {
                MessageBox.Show("Eliminado Coorectamente", "Exito", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar ", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            repos = new RepositorioBase<Categoria>(new Contexto());
            int.TryParse(IdcategorianumericUpDown.Text, out int id);
            Categoria CT = new Categoria();
            CT = repos.Buscar(id);

            if (CT != null)
            {
               LlenaCampo(CT);
            }
            else
            {
                LlenaCampo(CT);
                MessageBox.Show("Categoria no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
