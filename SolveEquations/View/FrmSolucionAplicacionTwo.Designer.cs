namespace ProjectIntegrated2.View
{   partial class FrmSolucionAplicacionTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolucionAplicacionTwo));
            lblTitulosolucionmodificador = new Label();
            lblSubtitulo = new Label();
            btnAtrasformularioModificador = new Button();
            lblsolucionProblemaModificadoMetodoEliminacion = new Label();
            SuspendLayout();
            // 
            // lblTitulosolucionmodificador
            // 
            lblTitulosolucionmodificador.AutoSize = true;
            lblTitulosolucionmodificador.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulosolucionmodificador.Location = new Point(621, 51);
            lblTitulosolucionmodificador.Name = "lblTitulosolucionmodificador";
            lblTitulosolucionmodificador.Size = new Size(513, 42);
            lblTitulosolucionmodificador.TabIndex = 0;
            lblTitulosolucionmodificador.Text = "SOLUCIÓN DEL PROBLEMA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.Location = new Point(243, 151);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(820, 33);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Solucion del problema por sistema 2x2 metodo de eliminación";
            // 
            // btnAtrasformularioModificador
            // 
            btnAtrasformularioModificador.BackColor = SystemColors.ActiveCaptionText;
            btnAtrasformularioModificador.Cursor = Cursors.Hand;
            btnAtrasformularioModificador.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtrasformularioModificador.ForeColor = SystemColors.ButtonHighlight;
            btnAtrasformularioModificador.Location = new Point(233, 960);
            btnAtrasformularioModificador.Name = "btnAtrasformularioModificador";
            btnAtrasformularioModificador.Size = new Size(82, 37);
            btnAtrasformularioModificador.TabIndex = 6;
            btnAtrasformularioModificador.Text = "ATRÁS";
            btnAtrasformularioModificador.UseVisualStyleBackColor = false;
            btnAtrasformularioModificador.Click += btnAtrasformularioModificador_Click;
            // 
            // lblsolucionProblemaModificadoMetodoEliminacion
            // 
            lblsolucionProblemaModificadoMetodoEliminacion.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblsolucionProblemaModificadoMetodoEliminacion.Location = new Point(233, 223);
            lblsolucionProblemaModificadoMetodoEliminacion.Name = "lblsolucionProblemaModificadoMetodoEliminacion";
            lblsolucionProblemaModificadoMetodoEliminacion.Size = new Size(1217, 734);
            lblsolucionProblemaModificadoMetodoEliminacion.TabIndex = 7;
            lblsolucionProblemaModificadoMetodoEliminacion.Text = "solución por el metodo de eliminación";
            // 
            // FrmSolucionAplicacionTwo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblsolucionProblemaModificadoMetodoEliminacion);
            Controls.Add(btnAtrasformularioModificador);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulosolucionmodificador);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSolucionAplicacionTwo";
            Text = "PROBLEMAS DE APLICACIÓN";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulosolucionmodificador;
        private Label lblSubtitulo;
        private Button btnAtrasformularioModificador;
        public Label lblsolucionProblemaModificadoMetodoEliminacion;
    }
}