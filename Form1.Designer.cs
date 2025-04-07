namespace Repaso8Propiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPropietarios = new System.Windows.Forms.Button();
            this.buttonPropiedades = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 32);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(0, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(835, 32);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Control de Pagos de Propiedades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Menu principal";
            // 
            // buttonPropietarios
            // 
            this.buttonPropietarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPropietarios.Image = ((System.Drawing.Image)(resources.GetObject("buttonPropietarios.Image")));
            this.buttonPropietarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPropietarios.Location = new System.Drawing.Point(144, 189);
            this.buttonPropietarios.Name = "buttonPropietarios";
            this.buttonPropietarios.Size = new System.Drawing.Size(265, 79);
            this.buttonPropietarios.TabIndex = 4;
            this.buttonPropietarios.Text = "Propietarios";
            this.buttonPropietarios.UseVisualStyleBackColor = true;
            this.buttonPropietarios.Click += new System.EventHandler(this.buttonPropietarios_Click);
            // 
            // buttonPropiedades
            // 
            this.buttonPropiedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPropiedades.Image = ((System.Drawing.Image)(resources.GetObject("buttonPropiedades.Image")));
            this.buttonPropiedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPropiedades.Location = new System.Drawing.Point(430, 189);
            this.buttonPropiedades.Name = "buttonPropiedades";
            this.buttonPropiedades.Size = new System.Drawing.Size(266, 79);
            this.buttonPropiedades.TabIndex = 5;
            this.buttonPropiedades.Text = "Propiedades";
            this.buttonPropiedades.UseVisualStyleBackColor = true;
            this.buttonPropiedades.Click += new System.EventHandler(this.buttonPropiedades_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(430, 282);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(266, 79);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporte.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporte.Image")));
            this.buttonReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporte.Location = new System.Drawing.Point(144, 282);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(265, 79);
            this.buttonReporte.TabIndex = 6;
            this.buttonReporte.Text = "Reporte de propiedades";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 465);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonPropiedades);
            this.Controls.Add(this.buttonPropietarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPropietarios;
        private System.Windows.Forms.Button buttonPropiedades;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonReporte;
    }
}

