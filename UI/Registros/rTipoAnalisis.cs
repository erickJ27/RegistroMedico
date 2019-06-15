using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Consulta.Entidades;
using Sistema_Consulta.BLL;

namespace Sistema_Consulta.UI.Registros
{
    public partial class rTipoAnalisis : Form
    {
        public rTipoAnalisis()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }
        private TipoAnalisis LlenarClase()
        {
            TipoAnalisis tipoAnalisis = new TipoAnalisis();
            tipoAnalisis.TipoId = Convert.ToInt32(IdNumericUpDown.Value);
            tipoAnalisis.Descripcion = DescripcionTextBox.Text;

            return tipoAnalisis;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            TipoAnalisis tipoAnalisis = TipoAnalisisBLL.Buscar((int)IdNumericUpDown.Value);
            return (tipoAnalisis != null);
        }
        private void LlenarCampo(TipoAnalisis tipoAnalisis)
        {

            IdNumericUpDown.Value = tipoAnalisis.TipoId;
            DescripcionTextBox.Text = tipoAnalisis.Descripcion;

        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Coloque un id valido");
            }
            else { 
                int id;
                TipoAnalisis tipoAnalisis = new TipoAnalisis();
                int.TryParse(IdNumericUpDown.Text, out id);

                tipoAnalisis = TipoAnalisisBLL.Buscar(id);

                if (tipoAnalisis != null)
                {
                    LlenarCampo(tipoAnalisis);
                }
                else
                {
                    MessageBox.Show("TipoAnalis no encontrado");
                }
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            TipoAnalisis tipoAnalisis;
            bool paso = false;

            if (!Validar())
                return;

            tipoAnalisis = LlenarClase();
            Limpiar();

            if (IdNumericUpDown.Value == 0)
                paso = TipoAnalisisBLL.Guardar(tipoAnalisis);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Tipo Analisis que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso =TipoAnalisisBLL.Modificar(tipoAnalisis);

            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (TipoAnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un Tipo Analisis que no existe");
        }
    }
}
