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

namespace Sistema_Consulta.UI.Consultas
{
    public partial class cCargos : Form
    {
        public cCargos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0:
                        listado = CargosBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = CargosBLL.GetList(p => p.CargoId == id);
                        break;
                    case 2:
                        listado = CargosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                }

                listado = listado.ToList();
            }
            else
            {
                listado = CargosBLL.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void CCargos_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
