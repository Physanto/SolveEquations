namespace ProjectIntegrated2.View
{
    partial class frmFactorizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactorizacion));
            lblTituloFactorizacion = new Label();
            lblTextoOpcionFactorizacion = new Label();
            pnMethodsFactorizacion = new Panel();
            btnTrinomioX = new Button();
            btnMetodoTrinomioA = new Button();
            btnMetodoDiferenciaSquares = new Button();
            btnMetodoFactorComun = new Button();
            btnAtrasFactorizacion = new Button();
            btnGraficaFactorizacion = new Button();
            pnSolucionFactorizacion = new Panel();
            lblProcedimientoFactorizacion = new Label();
            btnCalculateFactorizacion = new Button();
            txbEcuaciónFactorizacion = new TextBox();
            pnMethodsFactorizacion.SuspendLayout();
            pnSolucionFactorizacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloFactorizacion
            // 
            lblTituloFactorizacion.AutoSize = true;
            lblTituloFactorizacion.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFactorizacion.Location = new Point(704, 121);
            lblTituloFactorizacion.Name = "lblTituloFactorizacion";
            lblTituloFactorizacion.Size = new Size(326, 44);
            lblTituloFactorizacion.TabIndex = 4;
            lblTituloFactorizacion.Text = "FACTORIZACIÓN";
            // 
            // lblTextoOpcionFactorizacion
            // 
            lblTextoOpcionFactorizacion.AutoSize = true;
            lblTextoOpcionFactorizacion.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextoOpcionFactorizacion.Location = new Point(233, 248);
            lblTextoOpcionFactorizacion.Name = "lblTextoOpcionFactorizacion";
            lblTextoOpcionFactorizacion.Size = new Size(336, 36);
            lblTextoOpcionFactorizacion.TabIndex = 5;
            lblTextoOpcionFactorizacion.Text = "Seleccione el método :\r\n";
            // 
            // pnMethodsFactorizacion
            // 
            pnMethodsFactorizacion.BackColor = SystemColors.ActiveCaptionText;
            pnMethodsFactorizacion.Controls.Add(btnTrinomioX);
            pnMethodsFactorizacion.Controls.Add(btnMetodoTrinomioA);
            pnMethodsFactorizacion.Controls.Add(btnMetodoDiferenciaSquares);
            pnMethodsFactorizacion.Controls.Add(btnMetodoFactorComun);
            pnMethodsFactorizacion.ForeColor = SystemColors.ControlLightLight;
            pnMethodsFactorizacion.Location = new Point(233, 320);
            pnMethodsFactorizacion.Margin = new Padding(3, 2, 3, 2);
            pnMethodsFactorizacion.Name = "pnMethodsFactorizacion";
            pnMethodsFactorizacion.Size = new Size(267, 278);
            pnMethodsFactorizacion.TabIndex = 6;
            // 
            // btnTrinomioX
            // 
            btnTrinomioX.BackColor = SystemColors.ActiveCaptionText;
            btnTrinomioX.Cursor = Cursors.Hand;
            btnTrinomioX.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrinomioX.ForeColor = SystemColors.ControlLightLight;
            btnTrinomioX.Location = new Point(4, 143);
            btnTrinomioX.Margin = new Padding(3, 2, 3, 2);
            btnTrinomioX.Name = "btnTrinomioX";
            btnTrinomioX.Size = new Size(263, 48);
            btnTrinomioX.TabIndex = 3;
            btnTrinomioX.Text = "Trinomio de la forma:\r\nx^2 ± bx ± c";
            btnTrinomioX.UseVisualStyleBackColor = false;
            btnTrinomioX.Click += btnTrinomioX_Click;
            // 
            // btnMetodoTrinomioA
            // 
            btnMetodoTrinomioA.BackColor = SystemColors.ActiveCaptionText;
            btnMetodoTrinomioA.Cursor = Cursors.Hand;
            btnMetodoTrinomioA.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetodoTrinomioA.ForeColor = SystemColors.ControlLightLight;
            btnMetodoTrinomioA.Location = new Point(3, 210);
            btnMetodoTrinomioA.Margin = new Padding(3, 2, 3, 2);
            btnMetodoTrinomioA.Name = "btnMetodoTrinomioA";
            btnMetodoTrinomioA.Size = new Size(261, 48);
            btnMetodoTrinomioA.TabIndex = 2;
            btnMetodoTrinomioA.Text = "Trinomio de la forma: \r\nax^2 ± bx ± c";
            btnMetodoTrinomioA.UseVisualStyleBackColor = false;
            btnMetodoTrinomioA.Click += btnMetodoTrinomioA_Click;
            // 
            // btnMetodoDiferenciaSquares
            // 
            btnMetodoDiferenciaSquares.BackColor = SystemColors.ActiveCaptionText;
            btnMetodoDiferenciaSquares.Cursor = Cursors.Hand;
            btnMetodoDiferenciaSquares.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetodoDiferenciaSquares.ForeColor = SystemColors.ControlLightLight;
            btnMetodoDiferenciaSquares.Location = new Point(3, 80);
            btnMetodoDiferenciaSquares.Margin = new Padding(3, 2, 3, 2);
            btnMetodoDiferenciaSquares.Name = "btnMetodoDiferenciaSquares";
            btnMetodoDiferenciaSquares.Size = new Size(260, 49);
            btnMetodoDiferenciaSquares.TabIndex = 1;
            btnMetodoDiferenciaSquares.Text = "Método de Diferencia de Cuadrados";
            btnMetodoDiferenciaSquares.UseVisualStyleBackColor = false;
            btnMetodoDiferenciaSquares.Click += btnMetodoDiferenciaSquares_Click;
            // 
            // btnMetodoFactorComun
            // 
            btnMetodoFactorComun.BackColor = SystemColors.ActiveCaptionText;
            btnMetodoFactorComun.Cursor = Cursors.Hand;
            btnMetodoFactorComun.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetodoFactorComun.ForeColor = SystemColors.ControlLightLight;
            btnMetodoFactorComun.Location = new Point(4, 19);
            btnMetodoFactorComun.Margin = new Padding(3, 2, 3, 2);
            btnMetodoFactorComun.Name = "btnMetodoFactorComun";
            btnMetodoFactorComun.Size = new Size(260, 46);
            btnMetodoFactorComun.TabIndex = 0;
            btnMetodoFactorComun.Text = "Método de Factor Común";
            btnMetodoFactorComun.UseVisualStyleBackColor = false;
            btnMetodoFactorComun.Click += btnMetodoFactorComun_Click;
            // 
            // btnAtrasFactorizacion
            // 
            btnAtrasFactorizacion.BackColor = SystemColors.ActiveCaptionText;
            btnAtrasFactorizacion.Cursor = Cursors.Hand;
            btnAtrasFactorizacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasFactorizacion.ForeColor = SystemColors.ControlLightLight;
            btnAtrasFactorizacion.Location = new Point(233, 659);
            btnAtrasFactorizacion.Margin = new Padding(3, 2, 3, 2);
            btnAtrasFactorizacion.Name = "btnAtrasFactorizacion";
            btnAtrasFactorizacion.Size = new Size(133, 46);
            btnAtrasFactorizacion.TabIndex = 7;
            btnAtrasFactorizacion.Text = "ATRÁS";
            btnAtrasFactorizacion.UseVisualStyleBackColor = false;
            btnAtrasFactorizacion.Click += btnAtrasFactorizacion_Click;
            // 
            // btnGraficaFactorizacion
            // 
            btnGraficaFactorizacion.BackColor = SystemColors.ActiveCaptionText;
            btnGraficaFactorizacion.Cursor = Cursors.Hand;
            btnGraficaFactorizacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGraficaFactorizacion.ForeColor = SystemColors.ControlLightLight;
            btnGraficaFactorizacion.Location = new Point(519, 659);
            btnGraficaFactorizacion.Margin = new Padding(3, 2, 3, 2);
            btnGraficaFactorizacion.Name = "btnGraficaFactorizacion";
            btnGraficaFactorizacion.Size = new Size(133, 46);
            btnGraficaFactorizacion.TabIndex = 8;
            btnGraficaFactorizacion.Text = "GRÁFICA";
            btnGraficaFactorizacion.UseVisualStyleBackColor = false;
            // 
            // pnSolucionFactorizacion
            // 
            pnSolucionFactorizacion.BackColor = SystemColors.ControlLightLight;
            pnSolucionFactorizacion.Controls.Add(lblProcedimientoFactorizacion);
            pnSolucionFactorizacion.Controls.Add(btnCalculateFactorizacion);
            pnSolucionFactorizacion.Controls.Add(txbEcuaciónFactorizacion);
            pnSolucionFactorizacion.ForeColor = SystemColors.ControlLightLight;
            pnSolucionFactorizacion.Location = new Point(704, 203);
            pnSolucionFactorizacion.Margin = new Padding(3, 2, 3, 2);
            pnSolucionFactorizacion.Name = "pnSolucionFactorizacion";
            pnSolucionFactorizacion.Size = new Size(906, 502);
            pnSolucionFactorizacion.TabIndex = 9;
            pnSolucionFactorizacion.Visible = false;
            // 
            // lblProcedimientoFactorizacion
            // 
            lblProcedimientoFactorizacion.AutoSize = true;
            lblProcedimientoFactorizacion.BackColor = SystemColors.ControlLightLight;
            lblProcedimientoFactorizacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcedimientoFactorizacion.ForeColor = SystemColors.ActiveCaptionText;
            lblProcedimientoFactorizacion.Location = new Point(48, 98);
            lblProcedimientoFactorizacion.Name = "lblProcedimientoFactorizacion";
            lblProcedimientoFactorizacion.Size = new Size(122, 168);
            lblProcedimientoFactorizacion.TabIndex = 3;
            lblProcedimientoFactorizacion.Text = "Procediemiento:\r\n\r\nSolucíon \r\n\r\n\r\n\r\n\r\n\r\n";
            lblProcedimientoFactorizacion.Visible = false;
            // 
            // btnCalculateFactorizacion
            // 
            btnCalculateFactorizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalculateFactorizacion.BackColor = SystemColors.ControlLightLight;
            btnCalculateFactorizacion.Cursor = Cursors.Hand;
            btnCalculateFactorizacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateFactorizacion.ForeColor = SystemColors.WindowText;
            btnCalculateFactorizacion.Location = new Point(429, 26);
            btnCalculateFactorizacion.Margin = new Padding(3, 2, 3, 2);
            btnCalculateFactorizacion.Name = "btnCalculateFactorizacion";
            btnCalculateFactorizacion.Size = new Size(128, 26);
            btnCalculateFactorizacion.TabIndex = 2;
            btnCalculateFactorizacion.Text = "Calcular";
            btnCalculateFactorizacion.UseVisualStyleBackColor = false;
            btnCalculateFactorizacion.Click += btnCalculateFactorizacion_Click;
            // 
            // txbEcuaciónFactorizacion
            // 
            txbEcuaciónFactorizacion.Location = new Point(48, 29);
            txbEcuaciónFactorizacion.Margin = new Padding(3, 2, 3, 2);
            txbEcuaciónFactorizacion.Name = "txbEcuaciónFactorizacion";
            txbEcuaciónFactorizacion.PlaceholderText = "Ingrese la ecuación: ";
            txbEcuaciónFactorizacion.Size = new Size(347, 23);
            txbEcuaciónFactorizacion.TabIndex = 0;
            // 
            // frmFactorizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnSolucionFactorizacion);
            Controls.Add(btnGraficaFactorizacion);
            Controls.Add(btnAtrasFactorizacion);
            Controls.Add(pnMethodsFactorizacion);
            Controls.Add(lblTextoOpcionFactorizacion);
            Controls.Add(lblTituloFactorizacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFactorizacion";
            Text = "SOLUCIONADOR DE ECUACIONES";
            WindowState = FormWindowState.Maximized;
            pnMethodsFactorizacion.ResumeLayout(false);
            pnSolucionFactorizacion.ResumeLayout(false);
            pnSolucionFactorizacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFactorizacion;
        private Label lblTextoOpcionFactorizacion;
        private Panel pnMethodsFactorizacion;
        private Button btnTrinomioX;
        private Button btnMetodoTrinomioA;
        private Button btnMetodoDiferenciaSquares;
        private Button btnMetodoFactorComun;
        private Button btnAtrasFactorizacion;
        private Button btnGraficaFactorizacion;
        private Panel pnSolucionFactorizacion;
        private Label lblProcedimientoFactorizacion;
        private Button btnCalculateFactorizacion;
        private TextBox txbEcuación2sistemas;
        private TextBox txbEcuaciónFactorizacion;
    }
}