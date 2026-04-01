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
    public partial class frmFactorizacion : Form
    {
        public char selectOption { get; private set; }
        public frmFactorizacion()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(frmFactorizacion_FormClosing);

            btnCalculateFactorizacion.Enabled = false;
            txbEcuaciónFactorizacion.TextChanged += new EventHandler(txbEcuacionFactorizacion_TextChanged);
        }

        private void btnMetodoFactorComun_Click(object sender, EventArgs e)
        {
            if (selectOption == '2' || selectOption == '3' || selectOption == '4') lblProcedimientoFactorizacion.Text = "";
            pnSolucionFactorizacion.Visible = true;

            selectOption = '1';
        }

        private void btnMetodoDiferenciaSquares_Click(object sender, EventArgs e)
        {
            if (selectOption == '1' || selectOption == '3' || selectOption == '4') lblProcedimientoFactorizacion.Text = "";
            pnSolucionFactorizacion.Visible = true;

            selectOption = '2';
        }

        private void btnTrinomioX_Click(object sender, EventArgs e)
        {
            if (selectOption == '1' || selectOption == '2' || selectOption == '4') lblProcedimientoFactorizacion.Text = "";
            pnSolucionFactorizacion.Visible = true;

            selectOption = '3';
        }

        private void btnMetodoTrinomioA_Click(object sender, EventArgs e)
        {
            if (selectOption == '1' || selectOption == '2' || selectOption == '3') lblProcedimientoFactorizacion.Text = "";
            pnSolucionFactorizacion.Visible = true;

            selectOption = '4';
        }

        private void btnCalculateFactorizacion_Click(object sender, EventArgs e)
        {
            lblProcedimientoFactorizacion.Visible = true;
            string equation = txbEcuaciónFactorizacion.Text;

            Factorization factorization = new Factorization();
            List<string> list = factorization.FunctionMainFactorizer(equation, selectOption);

            string listSteps = string.Join("\n", list);

            lblProcedimientoFactorizacion.Text = listSteps;

            txbEcuaciónFactorizacion.Text = "";
            txbEcuaciónFactorizacion.Focus();
        }

        private void btnAtrasFactorizacion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblProcedimientoFactorizacion.Text) && pnSolucionFactorizacion.Visible == false)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                txbEcuaciónFactorizacion.Text = "";
                lblProcedimientoFactorizacion.Text = null;
                pnSolucionFactorizacion.Hide();
            }
        }

        private void frmFactorizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal FormMainMenu = new frmMenuPrincipal();
            FormMainMenu.Show();
        }

        private void txbEcuacionFactorizacion_TextChanged(object sender, EventArgs e)
        {
            btnCalculateFactorizacion.Enabled = !string.IsNullOrWhiteSpace(txbEcuaciónFactorizacion.Text);
        }
    }
    //public partial class frmFactorizacion : Form
    //{
    //    private System.Windows.Forms.Timer clickTimer; // Especificar el espacio de nombres correcto
    //    private const int DoubleClickTimeout = 300; // Milisegundos para detectar un doble clic

    //    public frmFactorizacion()
    //    {
    //        InitializeComponent();

    //        // Inicializar y configurar el temporizador
    //        clickTimer = new System.Windows.Forms.Timer();
    //        clickTimer.Interval = DoubleClickTimeout;
    //        clickTimer.Tick += ClickTimer_Tick;

    //        // Suscribir el evento Click al botón btnAtrasFactorizacion
    //        btnAtrasFactorizacion.Click += btnAtrasFactorizacion_Click;
    //    }

    //    // Método para resetear los controles dentro del panel de solución
    //    private void ResetPanel()
    //    {
    //        foreach (Control control in pnSolucionFactorizacion.Controls)
    //        {
    //            if (control is TextBox)
    //            {
    //                (control as TextBox).Clear();
    //            }

    //            // Añadir más condiciones si tienes otros tipos de controles, como ComboBox, CheckBox, etc.
    //        }
    //    }

    //    // Método para limpiar el contenido de la etiqueta de procedimiento
    //    private void ResetProcedureLabel()
    //    {
    //        lblProcedimientoFactorizacion.Text = string.Empty;
    //    }

    //    // Método para mostrar el panel de solución
    //    private void ShowSolutionPanel()
    //    {
    //        ResetPanel();
    //        ResetProcedureLabel(); // Limpiar el contenido de la etiqueta de procedimiento
    //        pnSolucionFactorizacion.Visible = true;
    //    }

    //    private void btnMetodoFactorComun_Click(object sender, EventArgs e)
    //    {
    //        ShowSolutionPanel();
    //        // Aquí añades el código específico para el método Factor Común
    //    }

    //    private void btnMetodoDiferenciaSquares_Click(object sender, EventArgs e)
    //    {
    //        ShowSolutionPanel();
    //        // Aquí añades el código específico para el método Diferencia de Cuadrados
    //    }

    //    private void btnTrinomioX_Click(object sender, EventArgs e)
    //    {
    //        ShowSolutionPanel();
    //        // Aquí añades el código específico para el método Trinomio Cuadrado Perfecto
    //    }

    //    private void btnMetodoTrinomioA_Click(object sender, EventArgs e)
    //    {
    //        ShowSolutionPanel();
    //        // Aquí añades el código específico para el método Trinomio de la forma ax^2 + bx + c
    //    }

    //    private void btnCalculateFactorizacion_Click(object sender, EventArgs e)
    //    {
    //        lblProcedimientoFactorizacion.Visible = true;
    //        // Aquí añades el código específico para calcular y mostrar la factorización
    //    }

    //    private void btnAtrasFactorizacion_Click(object sender, EventArgs e) 
    //    {
    //        // Iniciar el temporizador para detectar un posible doble clic
    //        if (clickTimer.Enabled)
    //        {
    //            // Si el temporizador ya está corriendo, es un doble clic
    //            clickTimer.Stop();
    //            GoBackToMainMenu();
    //        }
    //        else
    //        {
    //            // Si el temporizador no está corriendo, iniciar el temporizador
    //            clickTimer.Start();
    //        }
    //    }

    //    private void ClickTimer_Tick(object sender, EventArgs e)
    //    {
    //        // Detener el temporizador
    //        clickTimer.Stop();

    //        // Si el temporizador termina, se trata de un simple clic
    //        ResetPanel();
    //        pnSolucionFactorizacion.Visible = false;

    //        // Limpiar el contenido de la etiqueta de procedimiento
    //        ResetProcedureLabel();

    //        // Mostrar el panel de opciones si tienes uno (no mostrado en el código original)
    //        // panelOptions.Visible = true;
    //    }

    //    private void GoBackToMainMenu()
    //    {
    //        this.Hide();
    //        frmMenuPrincipal FormMainMenu = new frmMenuPrincipal();
    //        FormMainMenu.Show();
    //    }
    //}
}

