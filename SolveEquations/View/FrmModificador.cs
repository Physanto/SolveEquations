using ProjectIntegrated2.Model;
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
    public partial class FrmModificador : Form
    {
        private FrmSolucionAplicacionTwo frm;
        private ProblemAplication problemAplication;
        public FrmModificador()
        {
            InitializeComponent();

            frm = new FrmSolucionAplicacionTwo();
            problemAplication = new ProblemAplication();

            this.FormClosing += new FormClosingEventHandler(FrmModificador_FormClosing);
        }

        private void lbl2subtituloformularioaplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAtrasformularioModificador_Click(object sender, EventArgs e)
        {
           
            Form btnformularioAtrasModificador = new FrmSolucionAplicacion();
            btnformularioAtrasModificador.Show();
        }

        private void btnSolucionModificador_Click(object sender, EventArgs e)
        {
            if(textBox2UnidadesNecesitadas.Text == "" && textBox3costosPrimerElemento.Text == "" && textBox4CostoSegundoElemento.Text == "" 
                && textBox1CostoTotalElementos.Text == "")
            {
                
            }
            string tbxOne = textBox1ElementosFiesta.Text;
            string tbxTwo = textBox2ElementosFiesta.Text;
            double tbxThree = Convert.ToDouble(textBox2UnidadesNecesitadas.Text);
            double tbxFourth = Convert.ToDouble(textBox3costosPrimerElemento.Text);
            double tbxFive = Convert.ToDouble(textBox4CostoSegundoElemento.Text);
            double tbxSix = Convert.ToDouble(textBox1CostoTotalElementos.Text);

            List<string> listSteps = problemAplication.SolveProblemAplication(tbxThree, tbxFourth, tbxFive, tbxSix);

            string steps = string.Join("\n", listSteps);

            frm.lblsolucionProblemaModificadoMetodoEliminacion.Text = steps;

            frm.Show();
            this.Hide();
        }

        private void FrmModificador_FormClosing(object sender, EventArgs e)
        {
            FrmSolucionAplicacion frmSolucionAplicacion = new FrmSolucionAplicacion();
            frmSolucionAplicacion.Show();
        }

        private void AdjustCenter()
        {
            int x = (this.Width - lbl2TituloFormularioDeAplicacion.Width) / 2;
            lbl2TituloFormularioDeAplicacion.Location = new Point(x, lbl2TituloFormularioDeAplicacion.Location.Y);

            int x1 = (this.Width - lbl2subtituloformularioaplicacion.Width) / 2;
            lbl2subtituloformularioaplicacion.Location = new Point(x1, lbl2subtituloformularioaplicacion.Location.Y);
        }
    }
}
