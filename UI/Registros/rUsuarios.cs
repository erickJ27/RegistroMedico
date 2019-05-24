using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Entidades;
using ProyectoFinal.BLL;


namespace ProyectoFinal.UI.Registros
{
    public partial class rUsuarios : Form
    {
       
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            NivelUsuarioComboBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Email = EmailTextBox.Text;

            if (NivelUsuarioComboBox.Text == "Administrador")
                usuario.NivelUsuario = 1;
            else
                usuario.NivelUsuario = 2;

            usuario.Usuario = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.FechaIngreso = FechaIngresoDateTimePicker.Value;


            return usuario;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)IdNumericUpDown.Value);

            return (usuario != null);
        }

        private void LlenarCampo(Usuarios usuario)
        {
            IdNumericUpDown.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombre;
            EmailTextBox.Text = usuario.Email;

            string adm = "Administrador";
            string sur = "Supervisor";

            if (usuario.NivelUsuario == 1)
                NivelUsuarioComboBox.Text = adm;
            else
                NivelUsuarioComboBox.Text = sur;

            //NivelUsuarioComboBox.Text = Convert.ToString(usuario.NivelUsuario);

            UsuarioTextBox.Text = usuario.Usuario;

            ClaveTextBox.Text = usuario.Clave;

            FechaIngresoDateTimePicker.Value = usuario.FechaIngreso;

            


           
        }

    private bool validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NivelUsuarioComboBox.Text))
            {
                MyErrorProvider.SetError(NivelUsuarioComboBox, "El campo NivelUsuario no puede estar vacio");
                NivelUsuarioComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo Usuario no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox, " El campo Clave no puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            return paso;


        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            if (!validar())
                return;

            usuario = LlenarClase();
            Limpiar();

            if(IdNumericUpDown.Value==0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Encontrado");
                LlenarCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un usuario que no existe");

        }
    }
}
