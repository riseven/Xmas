namespace Xmas
{
    partial class VisorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.botonResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(3, 455);
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.ReadOnly = true;
            this.textBoxPregunta.Size = new System.Drawing.Size(439, 113);
            this.textBoxPregunta.TabIndex = 0;
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(3, 574);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(349, 20);
            this.textBoxRespuesta.TabIndex = 1;
            // 
            // botonResponder
            // 
            this.botonResponder.Location = new System.Drawing.Point(358, 572);
            this.botonResponder.Name = "botonResponder";
            this.botonResponder.Size = new System.Drawing.Size(84, 23);
            this.botonResponder.TabIndex = 2;
            this.botonResponder.Text = "Responder";
            this.botonResponder.UseVisualStyleBackColor = true;
            // 
            // VisorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.botonResponder);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.textBoxPregunta);
            this.Name = "VisorControl";
            this.Size = new System.Drawing.Size(445, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.TextBox textBoxRespuesta;
        private System.Windows.Forms.Button botonResponder;
    }
}
