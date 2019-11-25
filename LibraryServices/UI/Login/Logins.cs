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

namespace LibraryServices.UI.Registros
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
            LlenaCombo();
        }
        private void LlenaCombo()
        {
            UsercomboBox.DataSource = null;
            RepositorioBase<Usuarios> genericaBLL = new RepositorioBase<Usuarios>(new Contexto());
            List<Usuarios> lista = genericaBLL.GetList(p => true);
            UsercomboBox.DataSource = lista;
            UsercomboBox.DisplayMember = "Nombres";
            UsercomboBox.ValueMember = "UsuarioId";
        }
        private int ToInt(string valor)
        {
            int resultado = 0;
            int.TryParse(valor, out resultado);

            return resultado;
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> generic = new RepositorioBase<Usuarios>(new Contexto());
            int id = ToInt(UsercomboBox.SelectedValue.ToString());
            EncryptKey encrypt = new EncryptKey();

            Usuarios usuario = generic.Buscar(id);

            if (string.IsNullOrWhiteSpace(ContrasenatextBox.Text))
                return;

            string c = encrypt.descifrarTexto(usuario.Contraseña);

            if (c == ContrasenatextBox.Text)
            {
                MainForm Principal = new MainForm(usuario.UsuarioId);
                this.Hide();
                Principal.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerContraseñabutton_Click(object sender, EventArgs e)
        {
            string contraseña = ContrasenatextBox.Text;
            if (ContrasenacheckBox.Checked)
            {
                ContrasenatextBox.UseSystemPasswordChar = true;
                ContrasenatextBox.Text = contraseña;
            }
            else
            {
                ContrasenatextBox.UseSystemPasswordChar = false;
                ContrasenatextBox.Text = contraseña;

            }
        }
    }

}
