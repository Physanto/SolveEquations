namespace ProjectIntegrated2.View
{
    partial class FrmModificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificador));
            lbl2TituloFormularioDeAplicacion = new Label();
            lbl2subtituloformularioaplicacion = new Label();
            lblModificador = new Label();
            btnAtrasformularioModificador = new Button();
            btnSolucionModificador = new Button();
            textBox1ElementosFiesta = new TextBox();
            textBox2UnidadesNecesitadas = new TextBox();
            textBox3costosPrimerElemento = new TextBox();
            textBox4CostoSegundoElemento = new TextBox();
            textBox1CostoTotalElementos = new TextBox();
            textBox2ElementosFiesta = new TextBox();
            SuspendLayout();
            // 
            // lbl2TituloFormularioDeAplicacion
            // 
            lbl2TituloFormularioDeAplicacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl2TituloFormularioDeAplicacion.AutoSize = true;
            lbl2TituloFormularioDeAplicacion.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2TituloFormularioDeAplicacion.Location = new Point(727, 46);
            lbl2TituloFormularioDeAplicacion.Name = "lbl2TituloFormularioDeAplicacion";
            lbl2TituloFormularioDeAplicacion.Size = new Size(562, 42);
            lbl2TituloFormularioDeAplicacion.TabIndex = 1;
            lbl2TituloFormularioDeAplicacion.Text = "FORMULARIO DE APLICACIÓN";
            // 
            // lbl2subtituloformularioaplicacion
            // 
            lbl2subtituloformularioaplicacion.AutoSize = true;
            lbl2subtituloformularioaplicacion.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2subtituloformularioaplicacion.Location = new Point(258, 149);
            lbl2subtituloformularioaplicacion.Name = "lbl2subtituloformularioaplicacion";
            lbl2subtituloformularioaplicacion.Size = new Size(1306, 33);
            lbl2subtituloformularioaplicacion.TabIndex = 2;
            lbl2subtituloformularioaplicacion.Text = "Querido usuario considere el siguiente problema de aplicación e ingrese los valores en los cuadros \r\n";
            lbl2subtituloformularioaplicacion.Click += lbl2subtituloformularioaplicacion_Click;
            // 
            // lblModificador
            // 
            lblModificador.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificador.Location = new Point(261, 229);
            lblModificador.Name = "lblModificador";
            lblModificador.Size = new Size(1117, 460);
            lblModificador.TabIndex = 3;
            lblModificador.Text = resources.GetString("lblModificador.Text");
            // 
            // btnAtrasformularioModificador
            // 
            btnAtrasformularioModificador.BackColor = SystemColors.ActiveCaptionText;
            btnAtrasformularioModificador.Cursor = Cursors.Hand;
            btnAtrasformularioModificador.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtrasformularioModificador.ForeColor = SystemColors.ButtonHighlight;
            btnAtrasformularioModificador.Location = new Point(261, 708);
            btnAtrasformularioModificador.Name = "btnAtrasformularioModificador";
            btnAtrasformularioModificador.Size = new Size(75, 32);
            btnAtrasformularioModificador.TabIndex = 5;
            btnAtrasformularioModificador.Text = "ATRÁS";
            btnAtrasformularioModificador.UseVisualStyleBackColor = false;
            btnAtrasformularioModificador.Click += btnAtrasformularioModificador_Click;
            // 
            // btnSolucionModificador
            // 
            btnSolucionModificador.BackColor = SystemColors.ActiveCaptionText;
            btnSolucionModificador.Cursor = Cursors.Hand;
            btnSolucionModificador.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolucionModificador.ForeColor = SystemColors.ButtonHighlight;
            btnSolucionModificador.Location = new Point(776, 709);
            btnSolucionModificador.Name = "btnSolucionModificador";
            btnSolucionModificador.Size = new Size(86, 31);
            btnSolucionModificador.TabIndex = 6;
            btnSolucionModificador.Text = "SOLUCIÓN";
            btnSolucionModificador.UseVisualStyleBackColor = false;
            btnSolucionModificador.Click += btnSolucionModificador_Click;
            // 
            // textBox1ElementosFiesta
            // 
            textBox1ElementosFiesta.Location = new Point(575, 486);
            textBox1ElementosFiesta.Name = "textBox1ElementosFiesta";
            textBox1ElementosFiesta.Size = new Size(182, 23);
            textBox1ElementosFiesta.TabIndex = 7;
            // 
            // textBox2UnidadesNecesitadas
            // 
            textBox2UnidadesNecesitadas.Location = new Point(575, 533);
            textBox2UnidadesNecesitadas.Name = "textBox2UnidadesNecesitadas";
            textBox2UnidadesNecesitadas.Size = new Size(163, 23);
            textBox2UnidadesNecesitadas.TabIndex = 8;
            // 
            // textBox3costosPrimerElemento
            // 
            textBox3costosPrimerElemento.Location = new Point(697, 579);
            textBox3costosPrimerElemento.Name = "textBox3costosPrimerElemento";
            textBox3costosPrimerElemento.Size = new Size(120, 23);
            textBox3costosPrimerElemento.TabIndex = 9;
            // 
            // textBox4CostoSegundoElemento
            // 
            textBox4CostoSegundoElemento.Location = new Point(837, 579);
            textBox4CostoSegundoElemento.Name = "textBox4CostoSegundoElemento";
            textBox4CostoSegundoElemento.Size = new Size(115, 23);
            textBox4CostoSegundoElemento.TabIndex = 10;
            // 
            // textBox1CostoTotalElementos
            // 
            textBox1CostoTotalElementos.Location = new Point(636, 622);
            textBox1CostoTotalElementos.Name = "textBox1CostoTotalElementos";
            textBox1CostoTotalElementos.Size = new Size(142, 23);
            textBox1CostoTotalElementos.TabIndex = 11;
            // 
            // textBox2ElementosFiesta
            // 
            textBox2ElementosFiesta.Location = new Point(776, 486);
            textBox2ElementosFiesta.Name = "textBox2ElementosFiesta";
            textBox2ElementosFiesta.Size = new Size(172, 23);
            textBox2ElementosFiesta.TabIndex = 12;
            // 
            // FrmModificador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(textBox2ElementosFiesta);
            Controls.Add(textBox1CostoTotalElementos);
            Controls.Add(textBox4CostoSegundoElemento);
            Controls.Add(textBox3costosPrimerElemento);
            Controls.Add(textBox2UnidadesNecesitadas);
            Controls.Add(textBox1ElementosFiesta);
            Controls.Add(btnSolucionModificador);
            Controls.Add(btnAtrasformularioModificador);
            Controls.Add(lblModificador);
            Controls.Add(lbl2subtituloformularioaplicacion);
            Controls.Add(lbl2TituloFormularioDeAplicacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmModificador";
            Text = "PROBLEMAS DE APLICACIÓN";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl2TituloFormularioDeAplicacion;
        private Label lbl2subtituloformularioaplicacion;
        private Label lblModificador;
        private Button btnAtrasformularioModificador;
        private Button btnSolucionModificador;
        private TextBox textBox1ElementosFiesta;
        private TextBox textBox2UnidadesNecesitadas;
        private TextBox textBox3costosPrimerElemento;
        private TextBox textBox4CostoSegundoElemento;
        private TextBox textBox1CostoTotalElementos;
        private TextBox textBox2ElementosFiesta;
    }
}