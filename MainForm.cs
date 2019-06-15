using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Consulta.UI.Registros;
using Sistema_Consulta.UI.Consultas;
namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios vent = new rUsuarios();
            vent.Show();
        }

        private void RCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargos vent = new rCargos();
            vent.Show();
        }

        private void CUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios vent = new cUsuarios();
            vent.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCargos vent = new cCargos();
            vent.Show();
        }

        private void RegistroDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnalisis vent = new rAnalisis();
            vent.Show();
        }

        private void RegistroDeTipoDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTipoAnalisis vent = new rTipoAnalisis();
            vent.Show();
        }
    }
}
