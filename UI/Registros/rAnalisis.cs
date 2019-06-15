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
using Sistema_Consulta.DAL;

namespace Sistema_Consulta.UI.Registros
{
    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> Detalle { get; set; }
        
        public rAnalisis()
        {
            InitializeComponent();
            ListadoUsuarios();
            ListadoTipoAnalisis();
            this.Detalle = new List<AnalisisDetalle>();


        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            UsuarioComboBox.Text = string.Empty;
            TipoAnalisisComboBox.Text = string.Empty;
            ResultadoTextBox.Text = string.Empty;

            this.Detalle = new List<AnalisisDetalle>();
            CargarGrid();
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (UsuarioComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuarioComboBox, "El campo Usuario no puede estar vacio");
                UsuarioComboBox.Focus();
                paso = false;
            }
            if (TipoAnalisisComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TipoAnalisisComboBox, "El campo Tipo Analisis no puede estar vacio");
                UsuarioComboBox.Focus();
                paso = false;
            }
            
            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe Agregar algun resultado");
                ResultadoTextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void ListadoUsuarios()
        {
            var listado = new List<Usuarios>();

            listado = UsuariosBLL.GetList(p => true);
            UsuarioComboBox.DataSource = listado;
            UsuarioComboBox.DisplayMember = "Usuarios";
            UsuarioComboBox.ValueMember = "UsuarioId";

            

        }
        private void ListadoTipoAnalisis()
        {
            var listado = new List<TipoAnalisis>();

            listado = TipoAnalisisBLL.GetList(p => true);
            TipoAnalisisComboBox.DataSource = listado;
            TipoAnalisisComboBox.DisplayMember = "TipoAnalisis";
            TipoAnalisisComboBox.ValueMember = "TipoId";

            UsuarioComboBox.Text = string.Empty;

        }
        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis();
            analisis.AnalisisId = (int)IdNumericUpDown.Value;
            analisis.Fecha = FechaDateTimePicker.Value;
            analisis.UsuarioId = Convert.ToInt32(UsuarioComboBox.Text);
            analisis.Resultado = this.Detalle;

            return analisis;


        }
        private void LLenaCampos(Analisis analisis)
        {
            IdNumericUpDown.Value = analisis.AnalisisId;
            FechaDateTimePicker.Value = analisis.Fecha;
            UsuarioComboBox.Text = Convert.ToString(analisis.UsuarioId);

            this.Detalle = analisis.Resultado;
            CargarGrid();
        }
        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Analisis usuario = AnalisisBLL.Buscar((int)IdNumericUpDown.Value);

            return (usuario != null);
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenarClase();
            Limpiar();

            if (IdNumericUpDown.Value == 0)
                paso = AnalisisBLL.Guardar(analisis);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AnalisisBLL.Modificar(analisis);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<AnalisisDetalle>)DetalleDataGridView.DataSource;


            this.Detalle.Add(
                new AnalisisDetalle(
                    Id: 0,
                    AnalisisId: (int)IdNumericUpDown.Value,
                    TipoId:Convert.ToInt32(TipoAnalisisComboBox.Text), 
                    Resultado: ResultadoTextBox.Text
                    )
                ); 
            CargarGrid();
            TipoAnalisisComboBox.Focus();
            TipoAnalisisComboBox.Text = Convert.ToString(1);
            ResultadoTextBox.Clear();

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.Rows.Count>0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);

                CargarGrid();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (AnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar un analisis que no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Coloque un id valido");
            }
            else
            {
                int id;
                Analisis analisis = new Analisis();
                int.TryParse(IdNumericUpDown.Text, out id);

                Limpiar();

                analisis = AnalisisBLL.Buscar(id);

                if (analisis != null)
                {
                    MessageBox.Show("Usuario Encontrado");
                    LLenaCampos(analisis);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            
        }
    }
}
