using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIntegrated2.View
{
    public partial class FrmSolucionAplicacion : Form
    {
        public FrmSolucionAplicacion()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(frmSolucionAplicacion_FormClosing);
        }

        private void btnAtrasFormularioSolucionProblema_Click(object sender, EventArgs e)
        {
            frmProblemaAplicacion frmProblemaAplicacion = new frmProblemaAplicacion();
            frmProblemaAplicacion.Show();
            this.Hide();
        }

        private void btnModificarValoresProblema_Click(object sender, EventArgs e)
        {
            FrmModificador frmModificador = new FrmModificador();
            frmModificador.Show();
            this.Hide();
        }

        private void btnGraficaProblemaAplicacion_Click(object sender, EventArgs e)
        {

        }
        private void frmSolucionAplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmProblemaAplicacion frmProblemaAplicacion = new frmProblemaAplicacion();
            frmProblemaAplicacion.Show();
        }
    }
}
