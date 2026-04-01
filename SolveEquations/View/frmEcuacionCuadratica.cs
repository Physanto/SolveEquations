using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectIntegrated2.Model;

namespace ProjectIntegrated2.View
{
    public partial class frmEcuacionCuadratica : Form
    {
        public char selectOption { get; private set; }
        public string equation { get; private set ; }

        private Frm frm;

        public frmEcuacionCuadratica()
        {
            InitializeComponent();

            equation = "";
            frm = new Frm();

            AdjustCenter();

            this.FormClosing += new FormClosingEventHandler(frmEcuacionCuadratica_FormClosing);

            btnGraficaEC.Enabled = false;
            btnCalculateEC.Enabled = false;
            txbEcuacionCuadratica.TextChanged += new EventHandler(txbEcuacionCuadratica_TextChanged);
            lblProcedimientoEC.TextChanged += new EventHandler(lblProcedimientoEC_TextChanged);
        }

        private void btnFormulaCuadratica_Click(object sender, EventArgs e)
        {
            if (selectOption == '2') lblProcedimientoEC.Text = "";
            pnSolucionprincipalEC.Visible = true;

            selectOption = '1';
        }

        private void btnCompletarCuadrados_Click(object sender, EventArgs e)
        {

            if (selectOption == '1') lblProcedimientoEC.Text = "";
            pnSolucionprincipalEC.Visible = true;

            selectOption = '2';
        }

        private void btnCalculateEC_Click(object sender, EventArgs e)
        {
            lblProcedimientoEC.Visible = true;

            equation = txbEcuacionCuadratica.Text;

            EquationsQuadratic equationsQuadratic = new EquationsQuadratic();
            List<string> list = equationsQuadratic.FunctionMainSolverQuadratic(equation, selectOption);

            string listSteps = string.Join("\n", list);
            lblProcedimientoEC.Text = listSteps;

            txbEcuacionCuadratica.Text = "";
            txbEcuacionCuadratica.Focus();
        }

        private void txbEcuacionCuadratica_TextChanged(object sender, EventArgs e)
        {
            btnCalculateEC.Enabled = !string.IsNullOrWhiteSpace(txbEcuacionCuadratica.Text);
        }

        private void lblProcedimientoEC_TextChanged(object sender, EventArgs e)
        {
            btnGraficaEC.Enabled = !string.IsNullOrWhiteSpace(lblProcedimientoEC.Text);
        }

        private void btnAtrasEC_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblProcedimientoEC.Text) && pnSolucionprincipalEC.Visible == false)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                txbEcuacionCuadratica.Text = "";
                lblProcedimientoEC.Text = null;
                pnSolucionprincipalEC.Hide();
            }
        }

        private void btnGraficaEC_Click(object sender, EventArgs e)
        {
            frm.Show();

            EquationsQuadratic equationsQuadratic = new EquationsQuadratic();

            Tuple<double, double, double> coeficients = equationsQuadratic.ExtractCoefficients(equation);

            double a = coeficients.Item1;
            double b = coeficients.Item2;
            double c = coeficients.Item3;

            List<double> xs = equationsQuadratic.SolveQuadraticEquationByFormula(a, b, c, equation).xs;
            double x1 = xs[0];
            double x2 = xs[1];

            frm.QuadraticSeries(a, b, c, x1, x2);

        }

        private void frmEcuacionCuadratica_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Dispose();
            frmMenuPrincipal formMenuPrincipal = new frmMenuPrincipal();
            formMenuPrincipal.Show();
        }

        private void AdjustCenter()
        {
            int x = (this.Width - lblTituloEC.Width) / 2;
            lblTituloEC.Location = new Point(x, lblTituloEC.Location.Y);
        }
    }
}
