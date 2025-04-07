namespace Repaso8Propiedades
{
    partial class FormReportePropiedades
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelTitulo1 = new System.Windows.Forms.Label();
            this.labelTitu2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registro de Propiedades";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(-17, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(835, 32);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(-17, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 32);
            this.label1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 224);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(71, 119);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(144, 23);
            this.buttonReporte.TabIndex = 10;
            this.buttonReporte.Text = "Mostrar Registro";
            this.buttonReporte.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ordenar por cuota";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cuotas altas y bajas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Propietario con la cuota mas alta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelTitulo1
            // 
            this.labelTitulo1.AutoSize = true;
            this.labelTitulo1.Location = new System.Drawing.Point(183, 166);
            this.labelTitulo1.Name = "labelTitulo1";
            this.labelTitulo1.Size = new System.Drawing.Size(87, 13);
            this.labelTitulo1.TabIndex = 14;
            this.labelTitulo1.Text = "Cuotas mas altas";
            this.labelTitulo1.Visible = false;
            // 
            // labelTitu2
            // 
            this.labelTitu2.AutoSize = true;
            this.labelTitu2.Location = new System.Drawing.Point(477, 166);
            this.labelTitu2.Name = "labelTitu2";
            this.labelTitu2.Size = new System.Drawing.Size(90, 13);
            this.labelTitu2.TabIndex = 15;
            this.labelTitu2.Text = "Cuotas mas bajas";
            this.labelTitu2.Visible = false;
            // 
            // FormReportePropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitu2);
            this.Controls.Add(this.labelTitulo1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportePropiedades";
            this.Text = "FormReportePropiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelTitulo1;
        private System.Windows.Forms.Label labelTitu2;
    }
}