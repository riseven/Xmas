namespace Xmas
{
    partial class XmasForm
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.botonTeclado = new System.Windows.Forms.Button();
            this.visorControl2 = new Xmas.VisorControl();
            this.visorControl1 = new Xmas.VisorControl();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 600;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // botonTeclado
            // 
            this.botonTeclado.Location = new System.Drawing.Point(420, 618);
            this.botonTeclado.Name = "botonTeclado";
            this.botonTeclado.Size = new System.Drawing.Size(79, 27);
            this.botonTeclado.TabIndex = 2;
            this.botonTeclado.Text = "button1";
            this.botonTeclado.UseVisualStyleBackColor = true;
            this.botonTeclado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.botonTeclado_KeyUp);
            this.botonTeclado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.botonTeclado_KeyDown);
            // 
            // visorControl2
            // 
            this.visorControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visorControl2.Location = new System.Drawing.Point(463, 12);
            this.visorControl2.MiJugador = null;
            this.visorControl2.MiMundo = null;
            this.visorControl2.Name = "visorControl2";
            this.visorControl2.OtroJugador = null;
            this.visorControl2.Size = new System.Drawing.Size(445, 600);
            this.visorControl2.TabIndex = 1;
            // 
            // visorControl1
            // 
            this.visorControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visorControl1.Location = new System.Drawing.Point(12, 12);
            this.visorControl1.MiJugador = null;
            this.visorControl1.MiMundo = null;
            this.visorControl1.Name = "visorControl1";
            this.visorControl1.OtroJugador = null;
            this.visorControl1.Size = new System.Drawing.Size(445, 600);
            this.visorControl1.TabIndex = 0;
            // 
            // XmasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 648);
            this.Controls.Add(this.botonTeclado);
            this.Controls.Add(this.visorControl2);
            this.Controls.Add(this.visorControl1);
            this.Name = "XmasForm";
            this.Text = "Xmas";
            this.ResumeLayout(false);

        }

        #endregion

        private VisorControl visorControl1;
        private VisorControl visorControl2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button botonTeclado;
    }
}

