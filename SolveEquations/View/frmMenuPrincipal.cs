namespace ProjectIntegrated2.View
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(frmMenuPrincipal_FormClosing);
            this.FormClosed += new FormClosedEventHandler(frmMenuPrincipal_FormClosed);

            AdjustCenter();
        }

        private void btnSistemas2x2_Click(object sender, EventArgs e)
        {
            frmSistemas2x2 formsistemas2x2 = new frmSistemas2x2();
            formsistemas2x2.Show();
            this.Hide();
        }

        private void btnEcuacioncuadratica_Click(object sender, EventArgs e)
        {
            frmEcuacionCuadratica formEcuacionCuadratica = new frmEcuacionCuadratica();
            formEcuacionCuadratica.Show();
            this.Hide();
        }

        private void btnFactorizacion_Click(object sender, EventArgs e)
        {
            frmFactorizacion formFactorizacion = new frmFactorizacion();
            formFactorizacion.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
        
            //DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void frmMenuPrincipal_FormClosed(object? sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
        }

        private void btnProblema_Click(object sender, EventArgs e)
        {
            frmProblemaAplicacion frmProblemaAplicacion = new frmProblemaAplicacion();
            frmProblemaAplicacion.Show();
            this.Hide();
        }

        private void AdjustCenter()
        {
            int x = (this.Width - lblTexto1Opciónform1.Width) / 2;
            lblTexto1Opciónform1.Location = new Point(x, lblTexto1Opciónform1.Location.Y);

            int x1 = (this.Width - pnPanelPrincipal.Width) / 2;
            pnPanelPrincipal.Location = new Point(x1, pnPanelPrincipal.Location.Y);

            int x2 = (this.Width - lblTexto2Opciónform1.Width) / 2;
            lblTexto2Opciónform1.Location = new Point(x2, lblTexto2Opciónform1.Location.Y);
        }
    }
}
