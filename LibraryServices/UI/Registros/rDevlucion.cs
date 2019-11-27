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
        public List<DevolucionDetalles> Detalles { get; set; }
        public RepositorioBase<Estudiante> Estudent;
        public RepositorioBase<Libro> Book;
        public rDevlucion()
        {
            InitializeComponent();
            this.Detalles = new List<DevolucionDetalles>();
            Book = new RepositorioBase<Libro>(new Contexto());
            LlenaCombox();
           
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IdnumericUpDown1.Value = 0;
            DisponiblecheckBox.Checked = false;
            EstudiantecomboBox.SelectedIndex= -1;
            LibrocomboBox.SelectedIndex = -1;
            FechaEntregadateTimePicker.Value = DateTime.Now;
            DevoluciondateTimePicker.Value = DateTime.Now;
            this.Detalles = new List<DevolucionDetalles>();
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

            LibrocomboBox.DataSource = Lb.GetList(c => c.Disponibilidad ==false);
            LibrocomboBox.ValueMember = "LibroId";
            LibrocomboBox.DisplayMember = "NombreLibro";

        }
        private bool validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(IdnumericUpDown1.Text))
            {
                MyerrorProvider.SetError(IdnumericUpDown1, "El campo no debe estar vacio");
                IdnumericUpDown1.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PrestamoIdnumericUpDown1.Text))
            {
                MyerrorProvider.SetError(PrestamoIdnumericUpDown1, "Tiene que buscar el id del prestamo donde se encuentra el libro");
                PrestamoIdnumericUpDown1.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Seleccione un estudiante que devolvera el libro");
                EstudiantecomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(LibrocomboBox.Text))
            {
                MyerrorProvider.SetError(LibrocomboBox, "Seleccione el libro a devolver");
                LibrocomboBox.Focus();
                paso = false;
            }
            if (!DisponiblecheckBox.Checked)
            {
                MyerrorProvider.SetError(DisponiblecheckBox, "Marque el libro como disponible");
                DisponiblecheckBox.Focus();
                paso = false;
            }
            if (this.Detalles.Count == 0)
            {
                MyerrorProvider.SetError(MydataGridView, "Debe Agregar alguna devolucion");
                EstudiantecomboBox.Focus();
                EstudiantecomboBox.Focus();
                paso = false;
            }



            return paso;
        }
        private void CargarGrid()
        {
            MydataGridView.DataSource = null;
            MydataGridView.DataSource = this.Detalles;

        }
        private bool ExisteEnLaBaseDeDatos()
        {
           Devoluciones devoluciones = DevolucionesBLL.Buscar((int)IdnumericUpDown1.Value);
            return (devoluciones != null);
        }
        private void LlenaCampo(Devoluciones devoluciones)
        {
            Prestamo prestamo = new Prestamo();
            IdnumericUpDown1.Value = devoluciones.DevolucionId;
            DisponiblecheckBox.Checked = devoluciones.Disponible;
            FechaEntregadateTimePicker.Value = devoluciones.FechaDevueltaLibro;
            PrestamoIdnumericUpDown1.Value = prestamo.PrestamoId;
            DevoluciondateTimePicker.Value = devoluciones.FechaDevolucion;
            EstudiantecomboBox.SelectedValue = prestamo.EstudianteId;
            LibrocomboBox.SelectedValue = prestamo.LibroId;
            DevoluciondateTimePicker.Value = devoluciones.FechaDevolucion;
            this.Detalles = devoluciones.DetalleDev;
            CargarGrid();
            LlenaCombox();
        }
    
        private void LlenaCampoPretsamo(Prestamo prestamo)
        {
            PrestamoIdnumericUpDown1.Value = prestamo.PrestamoId;
            DevoluciondateTimePicker.Value = prestamo.FechaDevolucion;
            EstudiantecomboBox.SelectedValue = prestamo.EstudianteId;
            LibrocomboBox.SelectedValue = prestamo.LibroId;

            CargarGrid();
            LlenaCombox();
        }


        private Devoluciones LlenaClase()
        {
            Contexto db = new Contexto();
            Libro libro = new Libro();
            Devoluciones devoluciones = new Devoluciones();
            devoluciones.DevolucionId = Convert.ToInt32(IdnumericUpDown1.Value);
            devoluciones.Disponible = DisponiblecheckBox.Checked;
            devoluciones.PrestamoId = Convert.ToInt32(PrestamoIdnumericUpDown1.Value);
            devoluciones.EstudianteId =Convert.ToInt32(EstudiantecomboBox.SelectedValue);
            devoluciones.LibroId = Convert.ToInt32(LibrocomboBox.SelectedValue);
            devoluciones.FechaDevolucion =   DevoluciondateTimePicker.Value;
            devoluciones.FechaDevueltaLibro = FechaEntregadateTimePicker.Value;
            devoluciones.DetalleDev = this.Detalles;

            LlenaCombox();
            CargarGrid();
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
                Detalles.RemoveAt(MydataGridView.CurrentRow.Index);
                CargarGrid();

            }
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (MydataGridView.DataSource != null)
                this.Detalles = (List<DevolucionDetalles>)MydataGridView.DataSource;

                string nombres = Book.Buscar(id: (int)LibrocomboBox.SelectedValue).NombreLibro;
                this.Detalles.Add(
                    new DevolucionDetalles(
                        prestamoId:(int)PrestamoIdnumericUpDown1.Value,
                        libroId: (int)LibrocomboBox.SelectedValue,
                        nombreLibro: nombres,
                        fechaDevueltaLibro: FechaEntregadateTimePicker.Value

                        )
                );
            


            CargarGrid();
            EstudiantecomboBox.SelectAll();
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

            if (DevolucionesBLL.Eliminar(id))
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

        private void EstudiantecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LibrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void BuscarPrestamobutton_Click(object sender, EventArgs e)
        {
            int id;
            Prestamo prestamo = new Prestamo();

            id = Convert.ToInt32(PrestamoIdnumericUpDown1.Value);

            

            if (id > 0)
            {
                prestamo = PrestamoBLL.Buscar(id);
            }

            if (prestamo != null)
            {
                LlenaCampoPretsamo(prestamo);
            }
        }
    }
}
