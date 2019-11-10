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

namespace LibraryServices.UI
{
    public partial class rPrestamoLibro : Form
    {
        public List<PrestamoDetalle> Detalles { get; set; }
        public rPrestamoLibro()
        {
            InitializeComponent();
            this.Detalles = new List<PrestamoDetalle>();
            
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();

            PrestamoidnumericUpDown.Value = 0;
            FechaDevoluciondateTimePicker.Value = DateTime.Now;
            FechaPrestamodateTimePicker.Value = DateTime.Now;
            EstudiantecomboBox.SelectedIndex = -1;
            LibrocomboBox.SelectedIndex = -1;
            MatriculatextBox.Text = string.Empty;
           
           // this.DetalleEstudiante = new List<EstudiantesDetalle>();
          

        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(MatriculatextBox.Text))
            {
                MyerrorProvider.SetError(MatriculatextBox, "El campo no debe estar vacio");
                MatriculatextBox.Focus();
                paso = false;
            }
           

           /* if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "El Campo no debe estar vacio");
                EstudiantecomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(LibrocomboBox.Text))
            {
                MyerrorProvider.SetError(LibrocomboBox, "El Campo no debe estar vacio");
                LibrocomboBox.Focus();
                paso = false;
            }*/
            if(FechaDevoluciondateTimePicker.Value<= FechaPrestamodateTimePicker.Value)
            {
                MyerrorProvider.SetError(FechaDevoluciondateTimePicker, "La fecha de devolucion no puede ser menor o igual a la Fecha de prestamo");
                FechaDevoluciondateTimePicker.Focus();
                paso = false;
            }

            return paso;

        }
        private Prestamo LlenaClase()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.PrestamoId = Convert.ToInt32(PrestamoidnumericUpDown.Value);
            prestamo.EstudianteId = EstudiantecomboBox.SelectedIndex;
            prestamo.LibroId = LibrocomboBox.SelectedIndex;
            prestamo.Matricula = MatriculatextBox.Text;
            prestamo.FechaPrestamo = FechaPrestamodateTimePicker.Value;
            prestamo.FechaDevolucion = FechaDevoluciondateTimePicker.Value;
            
            return prestamo;
        }

        private void LlenaCampos(Prestamo prestamo)
        {
            PrestamoidnumericUpDown.Value = prestamo.PrestamoId;
            EstudiantecomboBox.SelectedIndex = prestamo.EstudianteId;
            MatriculatextBox.Text = prestamo.Matricula;
            LibrocomboBox.SelectedIndex = prestamo.LibroId;
            FechaPrestamodateTimePicker.Value = prestamo.FechaPrestamo;
            FechaDevoluciondateTimePicker.Value = prestamo.FechaDevolucion;

           

        }
        private bool ExisteEnLaBaseDeDatos()
        {
             Prestamo prestamo = PrestamoBLL.Buscar((int)PrestamoidnumericUpDown.Value);
            return (prestamo != null);
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

            int id;
            id = Convert.ToInt32(PrestamoidnumericUpDown.Value);

            if (PrestamoBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MyerrorProvider.SetError(PrestamoidnumericUpDown, "No se puede eliminar registro que no existe");
            }
        }
    }
}
