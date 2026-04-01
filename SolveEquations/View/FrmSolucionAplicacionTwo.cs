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
    public partial class FrmSolucionAplicacionTwo : Form
    {
        public FrmSolucionAplicacionTwo()
        {
            InitializeComponent();
            AdjustCenter();

            this.FormClosing += new FormClosingEventHandler(frmSolucionAplicacionTwo_FormClosing);
        }

        private void btnAtrasformularioModificador_Click(object sender, EventArgs e)
        {
            FrmModificador botosatrasformulariomodificador = new FrmModificador();
            botosatrasformulariomodificador.Show();
            this.Hide();
        }

        private void frmSolucionAplicacionTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmModificador frmModificador = new FrmModificador();
            frmModificador.Show();
        }
        private void AdjustCenter()
        {
            int x = (this.Width - lblTitulosolucionmodificador.Width) / 2;
            lblTitulosolucionmodificador.Location = new Point(x, lblTitulosolucionmodificador.Location.Y);

            int x1 = (this.Width - lblSubtitulo.Width) / 2;
            lblSubtitulo.Location = new Point(x1, lblSubtitulo.Location.Y);
        }
    }
}
