using LibraryServices.BLL;
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
using LibraryServices.UI;
using LibraryServices.DAL;
using LibraryServices.UI.Reportes;

namespace LibraryServices.UI
{
    public partial class rPrestamoLibro : Form
    {
        
        public List<PrestamosDetalle> Detalles { get; set; }
        public List<PrestamosDetalle> Reporte { get; set; }
        public RepositorioBase<Estudiante> Estudent;
        public RepositorioBase<Libro> Book;

        public rPrestamoLibro()
        {

            InitializeComponent();
            this.Detalles = new List<PrestamosDetalle>();
            Estudent = new RepositorioBase<Estudiante>(new Contexto());
            Book = new RepositorioBase<Libro>(new Contexto());
            LlenaCombox();
        }


        private void Limpiar()
        {
            MyerrorProvider.Clear();

            PrestamoidnumericUpDown.Value = 0;
            FechaDevoluciondateTimePicker.Value = DateTime.Now;
            FechaPrestamodateTimePicker.Value = DateTime.Now;
            EstudiantecomboBox.SelectedIndex = -1;
            LibrocomboBox.SelectedIndex = -1;
            this.Detalles = new List<PrestamosDetalle>();
            CargarGrid();


            // this.DetalleEstudiante = new List<EstudiantesDetalle>();


        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
             {
                 MyerrorProvider.SetError(EstudiantecomboBox, "El Campo no debe estar vacio");
                 EstudiantecomboBox.Focus();
                 paso = false;
             }
             
            
            if (FechaDevoluciondateTimePicker.Value <= FechaPrestamodateTimePicker.Value)
            {
                MyerrorProvider.SetError(FechaDevoluciondateTimePicker, "La fecha de devolucion no puede ser menor o igual a la Fecha de prestamo");
                FechaDevoluciondateTimePicker.Focus();
                paso = false;
            }
            if (this.Detalles.Count == 0)
            {
                MyerrorProvider.SetError(MydataGridView, "Debe Agregar algun prestamo");
                LibrocomboBox.Focus();
                
                paso = false;
            }

            return paso;

        }
        private Prestamo LlenaClase()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.PrestamoId = Convert.ToInt32(PrestamoidnumericUpDown.Value);
            prestamo.EstudianteId = Convert.ToInt32(EstudiantecomboBox.SelectedValue);
            prestamo.LibroId = Convert.ToInt32(LibrocomboBox.SelectedValue);
            prestamo.FechaPrestamo = FechaPrestamodateTimePicker.Value;
            prestamo.FechaDevolucion = FechaDevoluciondateTimePicker.Value;
            prestamo.Detalle = this.Detalles;
            LlenaCombox();


            return prestamo;
        }

        private void LlenaCampos(Prestamo prestamo)
        {
            PrestamoidnumericUpDown.Value = prestamo.PrestamoId;
            EstudiantecomboBox.SelectedValue = prestamo.EstudianteId;
            LibrocomboBox.SelectedValue = prestamo.LibroId;
            FechaPrestamodateTimePicker.Value = prestamo.FechaPrestamo;
            FechaDevoluciondateTimePicker.Value = prestamo.FechaDevolucion;
            this.Detalles = prestamo.Detalle;
            LlenaCombox();
            CargarGrid();



        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Prestamo prestamo = PrestamoBLL.Buscar((int)PrestamoidnumericUpDown.Value);
            return (prestamo != null);
        }
        private void LlenaCombox()
        {
            Estudiante Ed = new Estudiante();
            RepositorioBase<Estudiante> Cat = new RepositorioBase<Estudiante>(new Contexto());
            RepositorioBase<Libro> Lb = new RepositorioBase<Libro>(new Contexto());
            EstudiantecomboBox.DataSource = Cat.GetList(x => true);
            EstudiantecomboBox.ValueMember = "EstudianteId";
            EstudiantecomboBox.DisplayMember = "Nombres";

            LibrocomboBox.DataSource = Lb.GetList(c => c.Disponibilidad == true);
            LibrocomboBox.ValueMember = "LibroId";
            LibrocomboBox.DisplayMember = "NombreLibro";

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            bool paso = false;

            if (!Validar())
                return;

            prestamo = LlenaClase();

            if (PrestamoidnumericUpDown.Value == 0)
            {
                LlenaCombox();
                paso = PrestamoBLL.Guardar(prestamo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PrestamoBLL.Modificar(prestamo);
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Prestamo prestamo = new Prestamo();

            id = Convert.ToInt32(PrestamoidnumericUpDown.Value);

            Limpiar();

            if (id > 0)
            {
                prestamo = PrestamoBLL.Buscar(id);
            }

            if (prestamo != null)
            {
                LlenaCampos(prestamo);
            }
        }
        private void CargarGrid()
        {
            MydataGridView.DataSource = null;
            MydataGridView.DataSource = this.Detalles;

        }
        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (MydataGridView.Rows.Count > 0 && MydataGridView.CurrentRow != null)
            {
                Detalles.RemoveAt(MydataGridView.CurrentRow.Index);
                CargarGrid();

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int id = Convert.ToInt32(PrestamoidnumericUpDown.Value);
            Prestamo prestamo = PrestamoBLL.Buscar(id);
            
            id = Convert.ToInt32(PrestamoidnumericUpDown.Value);
            if (prestamo != null)
            {
                if (PrestamoBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenaCombox();
                }
                else
                {
                    MyerrorProvider.SetError(PrestamoidnumericUpDown, "No se puede eliminar registro que no existe");
                }
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }


        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (MydataGridView.DataSource != null)
                this.Detalles = (List<PrestamosDetalle>)MydataGridView.DataSource;
            
                string nombres = Book.Buscar(id: (int)LibrocomboBox.SelectedValue).NombreLibro;
                this.Detalles.Add(
                    new PrestamosDetalle(
                        detalleId: 0,
                        libroId: Convert.ToInt32(LibrocomboBox.SelectedValue),
                        nombreLibro: nombres,
                        fechaDevolucion: FechaDevoluciondateTimePicker.Value

                        )
                );
            this.Reporte = ((List<PrestamosDetalle>)MydataGridView.DataSource);
            CargarGrid();
            LibrocomboBox.SelectAll();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            
            if (MydataGridView.RowCount == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            RPPrestamos Report = new RPPrestamos(Detalles);
            Report.ShowDialog();
        }
    }
}
