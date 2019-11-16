using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
using LibraryServices.UI.Registros;
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
    public partial class rLibro : Form
    {
        private RepositorioBase<Libro> repositorio;
        public rLibro()
        {
            InitializeComponent();
            LlenaCombox();
        }

        private void RLibro_Load(object sender, EventArgs e)
        {

        }
        private Libro LlenaClase()
        {
            rDevlucion rdev = new rDevlucion();
            Devoluciones devoluciones = new Devoluciones();
            Libro libro = new Libro();
            libro.LibroId = Convert.ToInt32(LibroIdnumericUpDown.Value);
            libro.NombreLibro = NombretextBox.Text;
            libro.ISBN = ISBNtextBox.Text;
            libro.CategoriaId = Convert.ToInt32(CategoriacomboBox.SelectedValue);
            libro.EditorialId = Convert.ToInt32(EditoracomboBox.SelectedValue);
            libro.FechaImpresion = FeechaLibrodateTimePicker.Value;
            
            if (DevolucionesBLL.Buscar((int)LibroIdnumericUpDown.Value) != null)
            {
                libro.Disponibilidad = true;
            }


            return libro;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Libro>(new DAL.Contexto());
            Libro LB = repositorio.Buscar((int)LibroIdnumericUpDown.Value);
            return (LB != null);
        }
        private void LlenaCampo(Libro LB)
        {

            LibroIdnumericUpDown.Value = LB.LibroId;
            NombretextBox.Text = LB.NombreLibro;
            ISBNtextBox.Text = LB.ISBN;
            CategoriacomboBox.SelectedItem = LB.CategoriaId;
            EditoracomboBox.SelectedItem = LB.EditorialId;
            FeechaLibrodateTimePicker.Value =LB.FechaImpresion;
            LlenaCombox();

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
            if (string.IsNullOrWhiteSpace(ISBNtextBox.Text))
            {
                MyerrorProvider.SetError(ISBNtextBox, "El Campo no debe estar vacio");
                ISBNtextBox.Focus();
                paso = false;
            }
            
            if (string.IsNullOrWhiteSpace(CategoriacomboBox.Text))
            {
                MyerrorProvider.SetError(CategoriacomboBox, "El Campo no debe estar vacio");
                CategoriacomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EditoracomboBox.Text))
            {
                MyerrorProvider.SetError(EditoracomboBox, "El Campo no debe estar vacio");
                EditoracomboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void EditoracomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Libro libro;
            bool paso = false;

            if (!validar())
            {
                MessageBox.Show("Debe Llenar los Campos Indicados", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                libro = LlenaClase();

                if (LibroIdnumericUpDown.Value == 0)
                {
                    paso = LibroBLL.Guardar(libro);
                    MyerrorProvider.Clear();
                }
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar un Libro no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    paso = repositorio.Modificar(libro);

                }
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("No se pudo guardar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LlenaCombox()
        {
            RepositorioBase<Editorial> Ed = new RepositorioBase<Editorial>(new Contexto());
            RepositorioBase<Categoria> Cat = new RepositorioBase<Categoria>(new Contexto());
            EditoracomboBox.DataSource = Ed.GetList(c => true);
            EditoracomboBox.ValueMember = "EditorialId";
            EditoracomboBox.DisplayMember = "Nombre";

            CategoriacomboBox.DataSource = Cat.GetList(c => true);
            CategoriacomboBox.ValueMember = "CategoriaId";
            CategoriacomboBox.DisplayMember = "Nombre";

        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            LibroIdnumericUpDown.Value = 0;
            ISBNtextBox.Text = string.Empty;
            CategoriacomboBox.Text = string.Empty;
            NombretextBox.Text = string.Empty;
            EditoracomboBox.Text = string.Empty;
            FeechaLibrodateTimePicker.Value = DateTime.Now;
            
        }

        private void Nuvobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarEditorialbutton_Click(object sender, EventArgs e)
        {
            rEditorial Editorial = new rEditorial();
            Editorial.ShowDialog();
            LlenaCombox();
        }

        private void AgregarCategoriabutton_Click(object sender, EventArgs e)
        {
            rCategoria RC = new rCategoria();
            RC.ShowDialog();
            LlenaCombox();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);

            Libro libro = LibroBLL.Buscar(id);
            if (libro != null)
            {
                if (repositorio.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);
            Libro libros = LibroBLL.Buscar(id);
            int.TryParse(LibroIdnumericUpDown.Text, out id);

            if (libros != null)
            {
                LlenaCampo(libros);
            }
            else
            {
                MessageBox.Show("Libro no Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
