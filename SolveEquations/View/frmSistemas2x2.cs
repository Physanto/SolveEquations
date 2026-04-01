using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectIntegrated2.Model;

namespace ProjectIntegrated2.View
{
    public partial class frmSistemas2x2 : Form
    {
        public char selectOption { get; set; }
        public string equationOne { get; set; }
        public string equationTwo { get; set; }

        private Systems2x2 systems2X2;
        private Frm frm;
        public frmSistemas2x2()
        {
            InitializeComponent();

            frm = new Frm();
            systems2X2 = new Systems2x2();
            selectOption = '0';
            equationOne = "";
            equationTwo = "";
            AdjustCenter();

            this.FormClosing += new FormClosingEventHandler(frmSistemas2x2_FormClosing);

            btnCalculateSusSistemas.Enabled = false;
            txbEcuación1sistemas.TextChanged += new EventHandler(txbEcuacionSistemas_TextChanged);
            txbEcuación2sistemas.TextChanged += new EventHandler(txbEcuacionSistemas_TextChanged);
        }

        private void btnMetodosustitucion_Click(object sender, EventArgs e)
        {
            if (selectOption == '2' || selectOption == '3') lblSolucionSusSistemas.Text = "";
            pnSolucionSistemas2x2.Visible = true;

            selectOption = '1';
        }

        private void btnMetodoeleiminacion_Click(object sender, EventArgs e)
        {
            if (selectOption == '1' || selectOption == '3') lblSolucionSusSistemas.Text = "";
            pnSolucionSistemas2x2.Visible = true;

            selectOption = '2';
        }

        private void btnMetodoigualacion_Click(object sender, EventArgs e)
        {
            if (selectOption == '1' || selectOption == '2') lblSolucionSusSistemas.Text = "";
            pnSolucionSistemas2x2.Visible = true;

            selectOption = '3';
        }

        private void btnCalculateSusSistemas_Click(object sender, EventArgs e)
        {
            lblSolucionSusSistemas.Visible = true;

            equationOne = txbEcuación1sistemas.Text;
            equationTwo = txbEcuación2sistemas.Text;

            List<string> steps = systems2X2.FunctionMainSystems2x2(equationOne, equationTwo, selectOption);

            string listSteps = string.Join("\n", steps);
            lblSolucionSusSistemas.Text = listSteps;

            txbEcuación1sistemas.Text = "";
            txbEcuación2sistemas.Text = "";
            txbEcuación1sistemas.Focus();
        }

        private void btnAtrasSistemas2x2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblSolucionSusSistemas.Text) && pnSolucionSistemas2x2.Visible == false)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                txbEcuación1sistemas.Text = "";
                txbEcuación2sistemas.Text = "";
                lblSolucionSusSistemas.Text = null;
                pnSolucionSistemas2x2.Hide();
            }
        }

        private void txbEcuacionSistemas_TextChanged(object sender, EventArgs e)
        {
            btnCalculateSusSistemas.Enabled = !string.IsNullOrWhiteSpace(txbEcuación1sistemas.Text);
            btnCalculateSusSistemas.Enabled = !string.IsNullOrWhiteSpace(txbEcuación2sistemas.Text);
        }

        private void frmSistemas2x2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal formMenuPrincipal = new frmMenuPrincipal();
            formMenuPrincipal.Show();
        }

        private void AdjustCenter()
        {
            int x = (this.Width - lblTitulosistemas2x2.Width) / 2;
            lblTitulosistemas2x2.Location = new Point(x, lblTitulosistemas2x2.Location.Y);
        }

        private void btnGraficaSistemas2x2_Click(object sender, EventArgs e)
        {
            frm.Show();
            List<double> xs = new List<double>();

            double a = systems2X2.ExtraerCoeficientes(equationOne).Item1;
            double b = systems2X2.ExtraerCoeficientes(equationOne).Item2;
            double c = systems2X2.ExtraerCoeficientes(equationOne).Item3;

            List<double> coeficients = systems2X2.Extraction(equationOne);
            List<double> coeficientsTwo = systems2X2.Extraction(equationTwo);

            xs = systems2X2.ResolverPorSustitucion(a, b, c, 1, 2, 3).xs;
            frm.LinearSeries2(coeficients[0], coeficients[2], coeficients[1], coeficientsTwo[0], coeficientsTwo[2], coeficientsTwo[1]);
        }
    }
}
