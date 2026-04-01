namespace ProjectIntegrated2.View
{
    partial class frmProblemaAplicacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProblemaAplicacion));
            lblTituloFormularioDeAplicacion = new Label();
            lblsubtituloformularioaplicacion = new Label();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            btnformulariosolucionaplicacion = new Button();
            btnAtrasFormularioSolucionProblema = new Button();
            SuspendLayout();
            // 
            // lblTituloFormularioDeAplicacion
            // 
            lblTituloFormularioDeAplicacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloFormularioDeAplicacion.AutoSize = true;
            lblTituloFormularioDeAplicacion.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFormularioDeAplicacion.Location = new Point(685, 80);
            lblTituloFormularioDeAplicacion.Name = "lblTituloFormularioDeAplicacion";
            lblTituloFormularioDeAplicacion.Size = new Size(562, 42);
            lblTituloFormularioDeAplicacion.TabIndex = 0;
            lblTituloFormularioDeAplicacion.Text = "FORMULARIO DE APLICACIÓN";
            // 
            // lblsubtituloformularioaplicacion
            // 
            lblsubtituloformularioaplicacion.AutoSize = true;
            lblsubtituloformularioaplicacion.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblsubtituloformularioaplicacion.Location = new Point(276, 202);
            lblsubtituloformularioaplicacion.Name = "lblsubtituloformularioaplicacion";
            lblsubtituloformularioaplicacion.Size = new Size(823, 33);
            lblsubtituloformularioaplicacion.TabIndex = 1;
            lblsubtituloformularioaplicacion.Text = "Querido usuario considere el siguiente problema de aplicación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(276, 286);
            label1.Name = "label1";
            label1.Size = new Size(585, 276);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnformulariosolucionaplicacion
            // 
            btnformulariosolucionaplicacion.BackColor = SystemColors.ActiveCaptionText;
            btnformulariosolucionaplicacion.Cursor = Cursors.Hand;
            btnformulariosolucionaplicacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnformulariosolucionaplicacion.ForeColor = SystemColors.ControlLightLight;
            btnformulariosolucionaplicacion.Location = new Point(712, 576);
            btnformulariosolucionaplicacion.Name = "btnformulariosolucionaplicacion";
            btnformulariosolucionaplicacion.Size = new Size(87, 33);
            btnformulariosolucionaplicacion.TabIndex = 3;
            btnformulariosolucionaplicacion.Text = "SOLUCIÓN";
            btnformulariosolucionaplicacion.UseVisualStyleBackColor = false;
            btnformulariosolucionaplicacion.Click += btnformulariosolucionaplicacion_Click;
            // 
            // btnAtrasFormularioSolucionProblema
            // 
            btnAtrasFormularioSolucionProblema.BackColor = SystemColors.ActiveCaptionText;
            btnAtrasFormularioSolucionProblema.Cursor = Cursors.Hand;
            btnAtrasFormularioSolucionProblema.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtrasFormularioSolucionProblema.ForeColor = SystemColors.ButtonHighlight;
            btnAtrasFormularioSolucionProblema.Location = new Point(276, 576);
            btnAtrasFormularioSolucionProblema.Name = "btnAtrasFormularioSolucionProblema";
            btnAtrasFormularioSolucionProblema.Size = new Size(79, 33);
            btnAtrasFormularioSolucionProblema.TabIndex = 4;
            btnAtrasFormularioSolucionProblema.Text = "ATRÁS";
            btnAtrasFormularioSolucionProblema.UseVisualStyleBackColor = false;
            btnAtrasFormularioSolucionProblema.Click += btnAtrasFormularioSolucionProblema_Click;
            // 
            // frmProblemaAplicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnAtrasFormularioSolucionProblema);
            Controls.Add(btnformulariosolucionaplicacion);
            Controls.Add(label1);
            Controls.Add(lblsubtituloformularioaplicacion);
            Controls.Add(lblTituloFormularioDeAplicacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProblemaAplicacion";
            Text = "PROBLEMAS DE APLICACIÓN";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloFormularioDeAplicacion;
        private Label lblsubtituloformularioaplicacion;
        private Label label1;
        private ColorDialog colorDialog1;
        private Button btnformulariosolucionaplicacion;
        private Button btnAtrasFormularioSolucionProblema;
    }
}
