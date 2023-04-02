namespace Triangulo1w2
{
    partial class frnTriangulo
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
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(117, 201);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(132, 46);
            this.btnPerimetro.TabIndex = 0;
            this.btnPerimetro.Text = "Calcular";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(29, 55);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(38, 13);
            this.lblLadoA.TabIndex = 1;
            this.lblLadoA.Text = "LadoA";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(92, 52);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(83, 20);
            this.txtLadoA.TabIndex = 2;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(92, 100);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(83, 20);
            this.txtLadoB.TabIndex = 4;
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(29, 103);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(38, 13);
            this.lblLadoB.TabIndex = 3;
            this.lblLadoB.Text = "LadoB";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(92, 147);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(83, 20);
            this.txtLadoC.TabIndex = 6;
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(29, 150);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(38, 13);
            this.lblLadoC.TabIndex = 5;
            this.lblLadoC.Text = "LadoC";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(133, 267);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(83, 20);
            this.txtPromedio.TabIndex = 8;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(29, 270);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(51, 13);
            this.lblPerimetro.TabIndex = 7;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(133, 314);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(83, 20);
            this.txtTipo.TabIndex = 10;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(29, 317);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo Triangulo";
            // 
            // frnTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.btnPerimetro);
            this.Name = "frnTriangulo";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}

