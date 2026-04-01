namespace ProjectIntegrated2.View
{
    public partial class frmProblemaAplicacion : Form
    {
        public frmProblemaAplicacion()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(FrmProblemaAplicacion_FormClosing);
        }
        private void btnformulariosolucionaplicacion_Click(object sender, EventArgs e)
        {
            FrmSolucionAplicacion frmSolucionAplicacion = new FrmSolucionAplicacion();
            frmSolucionAplicacion.Show();
            this.Hide();
        }

        private void btnAtrasFormularioSolucionProblema_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void FrmProblemaAplicacion_FormClosing(object sender, EventArgs e)
        {
            frmMenuPrincipal formMenuPrincipal = new frmMenuPrincipal();
            formMenuPrincipal.Show();
        }
    }
}
