namespace Hi
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonNo = new System.Windows.Forms.Button();
            this.BotonSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonNo
            // 
            this.BotonNo.BackColor = System.Drawing.Color.White;
            this.BotonNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BotonNo.FlatAppearance.BorderSize = 0;
            this.BotonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNo.Location = new System.Drawing.Point(23, 23);
            this.BotonNo.Name = "BotonNo";
            this.BotonNo.Size = new System.Drawing.Size(93, 33);
            this.BotonNo.TabIndex = 1;
            this.BotonNo.TabStop = false;
            this.BotonNo.Text = "No";
            this.BotonNo.UseVisualStyleBackColor = false;
            this.BotonNo.Click += new System.EventHandler(this.BotonNo_Click);
            this.BotonNo.MouseEnter += new System.EventHandler(this.BotonNo_MouseEnter);
            // 
            // BotonSi
            // 
            this.BotonSi.BackColor = System.Drawing.Color.White;
            this.BotonSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSi.Location = new System.Drawing.Point(363, 143);
            this.BotonSi.Name = "BotonSi";
            this.BotonSi.Size = new System.Drawing.Size(93, 33);
            this.BotonSi.TabIndex = 0;
            this.BotonSi.TabStop = false;
            this.BotonSi.Text = "Si";
            this.BotonSi.UseVisualStyleBackColor = false;
            this.BotonSi.Click += new System.EventHandler(this.BotonSi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Quieres ser mi novi@?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BotonNo);
            this.panel1.Location = new System.Drawing.Point(113, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 74);
            this.panel1.TabIndex = 3;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.BotonNo_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 266);
            this.Controls.Add(this.BotonSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola!";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonNo;
        private System.Windows.Forms.Button BotonSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

