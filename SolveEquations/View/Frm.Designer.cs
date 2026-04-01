namespace ProjectIntegrated2.View
{
    partial class Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            pnlGrafico = new Panel();
            SuspendLayout();
            // 
            // pnlGrafico
            // 
            pnlGrafico.Location = new Point(334, 12);
            pnlGrafico.Name = "pnlGrafico";
            pnlGrafico.Size = new Size(1130, 1020);
            pnlGrafico.TabIndex = 0;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnlGrafico);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm";
            Text = "Grafico";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlGrafico;
    }
}