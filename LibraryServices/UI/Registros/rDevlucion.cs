using LibraryServices.BLL;
using LibraryServices.DAL;
using LibraryServices.Entdades;
using LibraryServices.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryServices.UI.Registros
{
    public partial class rDevlucion : Form
    {
        public List<DevolucionDetalle> Detalle { get; set; }
        public RepositorioBase<Estudiante> Estudent;
        public RepositorioBase<Libro> Book;
        public rDevlucion()
        {
            InitializeComponent();
            this.Detalle = new List<DevolucionDetalle>();
            Book = new RepositorioBase<Libro>(new Contexto());
            LlenaCombox();
           
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IdnumericUpDown1.Value = 0;
            LibrocomboBox.Text = string.Empty;
            EstudiantecomboBox.Text = string.Empty;
            DisponiblecheckBox.Checked = false;
            FechaDevoluciondateTimePicker.Value = DateTime.Now;
            this.Detalle = new List<DevolucionDetalle>();
            CargarGrid();



        }
        private void LlenaCombox()
        {
            Estudiante Ed = new Estudiante();
            RepositorioBase<Estudiante> Cat = new RepositorioBase<Estudiante>(new Contexto());
            RepositorioBase<Libro> Lb = new RepositorioBase<Libro>(new Contexto());
            EstudiantecomboBox.DataSource = Cat.GetList(x => true);
            EstudiantecomboBox.ValueMember = "EstudianteId";
            EstudiantecomboBox.DisplayMember = "Nombres";

            LibrocomboBox.DataSource = Lb.GetList(c => c.Disponibilidad == false);
            LibrocomboBox.ValueMember = "LibroId";
            LibrocomboBox.DisplayMember = "NombreLibro";

        }
        private bool validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(LibrocomboBox.Text))
            {
                MyerrorProvider.SetError(LibrocomboBox, "El campo no debe estar vacio");
                LibrocomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "El Campo no debe estar vacio");
                EstudiantecomboBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void CargarGrid()
        {
            MydataGridView.DataSource = null;
            MydataGridView.DataSource = this.Detalle;

        }
        private bool ExisteEnLaBaseDeDatos()
        {
           Devoluciones devoluciones = DevolucionesBLL.Buscar((int)IdnumericUpDown1.Value);
            return (devoluciones != null);
        }
        private void LlenaCampo(Devoluciones devoluciones)
        {
            IdnumericUpDown1.Value = devoluciones.DevolucionId;
            LibrocomboBox.SelectedItem = devoluciones.LibroId;
            EstudiantecomboBox.SelectedItem = devoluciones.EstudianteId;
            DisponiblecheckBox.Checked = devoluciones.Disponible;
            FechaDevoluciondateTimePicker.Value = devoluciones.FechaDevolucion;
            this.Detalle = devoluciones.DetalleDev;
            CargarGrid();
            LlenaCombox();
        }
        private Devoluciones LlenaClase()
        {
            Libro libro = new Libro();
            Devoluciones devoluciones = new Devoluciones();
            devoluciones.DevolucionId = Convert.ToInt32(IdnumericUpDown1.Value);
            devoluciones.LibroId = Convert.ToInt32(LibrocomboBox.SelectedValue);
            devoluciones.Disponible = DisponiblecheckBox.Checked;
            devoluciones.FechaDevolucion = FechaDevoluciondateTimePicker.Value;
            devoluciones.DetalleDev = this.Detalle;

            LlenaCombox();
            return devoluciones;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Devoluciones devoluciones = new Devoluciones();
            bool paso = false;

            if (!validar())
                return;

            devoluciones = LlenaClase();

            if (IdnumericUpDown1.Value == 0)
            {
                LlenaCombox();
                paso = DevolucionesBLL.Guardar(devoluciones);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = DevolucionesBLL.Modificar(devoluciones);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void DisponiblecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RDevlucion_Load(object sender, EventArgs e)
        {

        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (MydataGridView.Rows.Count > 0 && MydataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(MydataGridView.CurrentRow.Index);
                CargarGrid();

            }
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (MydataGridView.DataSource != null)
                this.Detalle = (List<DevolucionDetalle>)MydataGridView.DataSource;

            

            if (validar())
            {
                string nombres = Book.Buscar(id: (int)LibrocomboBox.SelectedValue).NombreLibro;
                this.Detalle.Add(
                    new DevolucionDetalle(
                        libroId: (int)LibrocomboBox.SelectedValue,
                        tituloLibro: nombres,
                        estudianteId: (int)LibrocomboBox.SelectedValue,
                        disponibilidad: DisponiblecheckBox.Checked,
                        fechaDevolucion: FechaDevoluciondateTimePicker.Value

                        )
                );
            }


            CargarGrid();
            LibrocomboBox.SelectAll();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            id = Convert.ToInt32(IdnumericUpDown1.Value);

            if (PrestamoBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCombox();
                Limpiar();
            }
            else
            {
                MyerrorProvider.SetError(IdnumericUpDown1, "No se puede eliminar registro que no existe");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Devoluciones devoluciones = new Devoluciones();

            id = Convert.ToInt32(IdnumericUpDown1.Value);

            Limpiar();

            if (id > 0)
            {
                devoluciones = DevolucionesBLL.Buscar(id);
            }

            if (devoluciones != null)
            {
                LlenaCampo(devoluciones);
            }
        }
    }
}
