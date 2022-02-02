
namespace MisControles
{
    partial class UC_Rating
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl1);
            this.flowLayoutPanel1.Controls.Add(this.lbl2);
            this.flowLayoutPanel1.Controls.Add(this.lbl3);
            this.flowLayoutPanel1.Controls.Add(this.lbl4);
            this.flowLayoutPanel1.Controls.Add(this.lbl5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 37);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "☆";
            this.lbl1.Click += new System.EventHandler(this.Star_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(48, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 37);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "☆";
            this.lbl2.Click += new System.EventHandler(this.Star_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(93, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 37);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "☆";
            this.lbl3.Click += new System.EventHandler(this.Star_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(138, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 37);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "☆";
            this.lbl4.Click += new System.EventHandler(this.Star_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(183, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(39, 37);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "☆";
            this.lbl5.Click += new System.EventHandler(this.Star_Click);
            // 
            // UC_Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Rating";
            this.Size = new System.Drawing.Size(255, 53);
            this.Load += new System.EventHandler(this.UC_Rating_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
    }
}
