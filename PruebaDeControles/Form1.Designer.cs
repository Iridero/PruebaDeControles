
namespace PruebaDeControles
{
    partial class Form1
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
            this.uC_EstadoCivil1 = new MisControles.UC_EstadoCivil();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_EstadoCivil1
            // 
            this.uC_EstadoCivil1.Location = new System.Drawing.Point(36, 62);
            this.uC_EstadoCivil1.Name = "uC_EstadoCivil1";
            this.uC_EstadoCivil1.Orientacion = MisControles.OrientacionesEstado.Vertical;
            this.uC_EstadoCivil1.Size = new System.Drawing.Size(600, 209);
            this.uC_EstadoCivil1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_EstadoCivil1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MisControles.UC_EstadoCivil uC_EstadoCivil1;
        private System.Windows.Forms.Button button1;
    }
}

