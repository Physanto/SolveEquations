namespace ProjectIntegrated2.View
{
    partial class frmEcuacionCuadratica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcuacionCuadratica));
            lblTituloEC = new Label();
            lblTextoOpcionEC = new Label();
            pnMethodsEC = new Panel();
            btnCompletarCuadrados = new Button();
            btnFormulaCuadratica = new Button();
            btnAtrasEC = new Button();
            btnGraficaEC = new Button();
            pnSolucionprincipalEC = new Panel();
            lblProcedimientoEC = new Label();
            btnCalculateEC = new Button();
            txbEcuacionCuadratica = new TextBox();
            pnMethodsEC.SuspendLayout();
            pnSolucionprincipalEC.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloEC
            // 
            lblTituloEC.AutoSize = true;
            lblTituloEC.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloEC.Location = new Point(777, 105);
            lblTituloEC.Name = "lblTituloEC";
            lblTituloEC.Size = new Size(489, 44);
            lblTituloEC.TabIndex = 0;
            lblTituloEC.Text = "ECUACIÓN CUADRÁTICA";
            // 
            // lblTextoOpcionEC
            // 
            lblTextoOpcionEC.AutoSize = true;
            lblTextoOpcionEC.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextoOpcionEC.Location = new Point(221, 292);
            lblTextoOpcionEC.Name = "lblTextoOpcionEC";
            lblTextoOpcionEC.Size = new Size(336, 36);
            lblTextoOpcionEC.TabIndex = 2;
            lblTextoOpcionEC.Text = "Seleccione el método :\r\n";
            // 
            // pnMethodsEC
            // 
            pnMethodsEC.BackColor = SystemColors.ActiveCaptionText;
            pnMethodsEC.Controls.Add(btnCompletarCuadrados);
            pnMethodsEC.Controls.Add(btnFormulaCuadratica);
            pnMethodsEC.ForeColor = SystemColors.ControlLightLight;
            pnMethodsEC.Location = new Point(221, 373);
            pnMethodsEC.Margin = new Padding(3, 2, 3, 2);
            pnMethodsEC.Name = "pnMethodsEC";
            pnMethodsEC.Size = new Size(267, 153);
            pnMethodsEC.TabIndex = 3;
            // 
            // btnCompletarCuadrados
            // 
            btnCompletarCuadrados.BackColor = SystemColors.ActiveCaptionText;
            btnCompletarCuadrados.Cursor = Cursors.Hand;
            btnCompletarCuadrados.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompletarCuadrados.ForeColor = SystemColors.ControlLightLight;
            btnCompletarCuadrados.Location = new Point(4, 84);
            btnCompletarCuadrados.Margin = new Padding(3, 2, 3, 2);
            btnCompletarCuadrados.Name = "btnCompletarCuadrados";
            btnCompletarCuadrados.Size = new Size(259, 45);
            btnCompletarCuadrados.TabIndex = 1;
            btnCompletarCuadrados.Text = "Completación de Cuadrados";
            btnCompletarCuadrados.UseVisualStyleBackColor = false;
            btnCompletarCuadrados.Click += btnCompletarCuadrados_Click;
            // 
            // btnFormulaCuadratica
            // 
            btnFormulaCuadratica.BackColor = SystemColors.ActiveCaptionText;
            btnFormulaCuadratica.Cursor = Cursors.Hand;
            btnFormulaCuadratica.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormulaCuadratica.ForeColor = SystemColors.ControlLightLight;
            btnFormulaCuadratica.Location = new Point(4, 19);
            btnFormulaCuadratica.Margin = new Padding(3, 2, 3, 2);
            btnFormulaCuadratica.Name = "btnFormulaCuadratica";
            btnFormulaCuadratica.Size = new Size(259, 45);
            btnFormulaCuadratica.TabIndex = 0;
            btnFormulaCuadratica.Text = "Fórmula Cuadrática";
            btnFormulaCuadratica.UseVisualStyleBackColor = false;
            btnFormulaCuadratica.Click += btnFormulaCuadratica_Click;
            // 
            // btnAtrasEC
            // 
            btnAtrasEC.BackColor = SystemColors.ActiveCaptionText;
            btnAtrasEC.Cursor = Cursors.Hand;
            btnAtrasEC.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasEC.ForeColor = SystemColors.ControlLightLight;
            btnAtrasEC.Location = new Point(225, 686);
            btnAtrasEC.Margin = new Padding(3, 2, 3, 2);
            btnAtrasEC.Name = "btnAtrasEC";
            btnAtrasEC.Size = new Size(133, 46);
            btnAtrasEC.TabIndex = 5;
            btnAtrasEC.Text = "ATRÁS";
            btnAtrasEC.UseVisualStyleBackColor = false;
            btnAtrasEC.Click += btnAtrasEC_Click;
            // 
            // btnGraficaEC
            // 
            btnGraficaEC.BackColor = SystemColors.ActiveCaptionText;
            btnGraficaEC.Cursor = Cursors.Hand;
            btnGraficaEC.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGraficaEC.ForeColor = SystemColors.ControlLightLight;
            btnGraficaEC.Location = new Point(534, 686);
            btnGraficaEC.Margin = new Padding(3, 2, 3, 2);
            btnGraficaEC.Name = "btnGraficaEC";
            btnGraficaEC.Size = new Size(133, 46);
            btnGraficaEC.TabIndex = 6;
            btnGraficaEC.Text = "GRÁFICA";
            btnGraficaEC.UseVisualStyleBackColor = false;
            btnGraficaEC.Click += btnGraficaEC_Click;
            // 
            // pnSolucionprincipalEC
            // 
            pnSolucionprincipalEC.AutoSize = true;
            pnSolucionprincipalEC.BackColor = SystemColors.ControlLightLight;
            pnSolucionprincipalEC.Controls.Add(lblProcedimientoEC);
            pnSolucionprincipalEC.Controls.Add(btnCalculateEC);
            pnSolucionprincipalEC.Controls.Add(txbEcuacionCuadratica);
            pnSolucionprincipalEC.ForeColor = SystemColors.ControlLightLight;
            pnSolucionprincipalEC.Location = new Point(718, 230);
            pnSolucionprincipalEC.Margin = new Padding(3, 2, 3, 2);
            pnSolucionprincipalEC.Name = "pnSolucionprincipalEC";
            pnSolucionprincipalEC.Size = new Size(906, 502);
            pnSolucionprincipalEC.TabIndex = 7;
            pnSolucionprincipalEC.Visible = false;
            // 
            // lblProcedimientoEC
            // 
            lblProcedimientoEC.AutoSize = true;
            lblProcedimientoEC.BackColor = SystemColors.ControlLightLight;
            lblProcedimientoEC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcedimientoEC.ForeColor = SystemColors.ActiveCaptionText;
            lblProcedimientoEC.Location = new Point(48, 132);
            lblProcedimientoEC.Name = "lblProcedimientoEC";
            lblProcedimientoEC.Size = new Size(19, 21);
            lblProcedimientoEC.TabIndex = 3;
            lblProcedimientoEC.Text = "q";
            lblProcedimientoEC.Visible = false;
            // 
            // btnCalculateEC
            // 
            btnCalculateEC.BackColor = SystemColors.ControlLightLight;
            btnCalculateEC.Cursor = Cursors.Hand;
            btnCalculateEC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateEC.ForeColor = SystemColors.MenuText;
            btnCalculateEC.Location = new Point(429, 26);
            btnCalculateEC.Margin = new Padding(3, 2, 3, 2);
            btnCalculateEC.Name = "btnCalculateEC";
            btnCalculateEC.Size = new Size(128, 26);
            btnCalculateEC.TabIndex = 2;
            btnCalculateEC.Text = "Calcular";
            btnCalculateEC.UseVisualStyleBackColor = false;
            btnCalculateEC.Click += btnCalculateEC_Click;
            // 
            // txbEcuacionCuadratica
            // 
            txbEcuacionCuadratica.ForeColor = SystemColors.MenuText;
            txbEcuacionCuadratica.Location = new Point(48, 29);
            txbEcuacionCuadratica.Margin = new Padding(3, 2, 3, 2);
            txbEcuacionCuadratica.Name = "txbEcuacionCuadratica";
            txbEcuacionCuadratica.PlaceholderText = "Ingrese la ecuación cuadrática";
            txbEcuacionCuadratica.Size = new Size(285, 23);
            txbEcuacionCuadratica.TabIndex = 0;
            // 
            // frmEcuacionCuadratica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnSolucionprincipalEC);
            Controls.Add(btnGraficaEC);
            Controls.Add(btnAtrasEC);
            Controls.Add(pnMethodsEC);
            Controls.Add(lblTextoOpcionEC);
            Controls.Add(lblTituloEC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEcuacionCuadratica";
            Text = "SOLUCIONADOR DE ECUACIONES";
            WindowState = FormWindowState.Maximized;
            pnMethodsEC.ResumeLayout(false);
            pnSolucionprincipalEC.ResumeLayout(false);
            pnSolucionprincipalEC.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloEC;
        private Label lblTextoOpcionEC;
        private Panel pnMethodsEC;
        private Button btnCompletarCuadrados;
        private Button btnFormulaCuadratica;
        private Button btnAtrasEC;
        private Button btnGraficaEC;
        private Panel pnSolucionprincipalEC;
        private Label lblProcedimientoEC;
        private Button btnCalculateEC;
        private TextBox txbEcuacionCuadratica;
    }
}