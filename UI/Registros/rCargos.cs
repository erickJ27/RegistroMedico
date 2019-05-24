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
    public partial class rCargos : Form
    {
        public rCargos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionRichTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Cargos LlenarClase()
        {
            Cargos cargo = new Cargos();
            cargo.CargosId = Convert.ToInt32(IdNumericUpDown.Value);
            cargo.Descripcion = DescripcionRichTextBox.Text;

            return cargo;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos cargo = CargosBLL.Buscar((int)IdNumericUpDown.Value);
            return (cargo != null);
        }
        private void LlenarCampo(Cargos cargo)
        {

            IdNumericUpDown.Value = cargo.CargosId;
            DescripcionRichTextBox.Text = cargo.Descripcion;

        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionRichTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionRichTextBox, "El Campo Descripcion no puede estar vacio");
                DescripcionRichTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargos cargo;
            bool paso = false;

            if (!Validar())
                return;

            cargo = LlenarClase();
            Limpiar();

            if (IdNumericUpDown.Value == 0)
                paso = CargosBLL.Guardar(cargo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cargo que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(cargo);

            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Cargos cargo = new Cargos();
            int.TryParse(IdNumericUpDown.Text, out id);

            cargo = CargosBLL.Buscar(id);

            if(cargo!= null)
            {
                MessageBox.Show("Usuario Encontrado");
                LlenarCampo(cargo);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            {
                MyErrorProvider.Clear();

                int id;
                int.TryParse(IdNumericUpDown.Text, out id);

                Limpiar();

                if (CargosBLL.Eliminar(id))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un usuario que no existe");

            }
        }
    }
}
