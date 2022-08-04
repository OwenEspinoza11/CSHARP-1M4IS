namespace PJpagoEmpleado
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
            this.FRMPagoEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMontoBruto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMontoNeto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FRMPagoEmpleado
            // 
            this.FRMPagoEmpleado.AutoSize = true;
            this.FRMPagoEmpleado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FRMPagoEmpleado.Location = new System.Drawing.Point(198, 25);
            this.FRMPagoEmpleado.Name = "FRMPagoEmpleado";
            this.FRMPagoEmpleado.Size = new System.Drawing.Size(448, 37);
            this.FRMPagoEmpleado.TabIndex = 0;
            this.FRMPagoEmpleado.Text = "CONTROL DE PAGO DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMPLEADO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "HORAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "COSTO HORAS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(498, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 23);
            this.textBox3.TabIndex = 6;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(60, 214);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(141, 214);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoNeto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMontoDescuento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMontoBruto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(61, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUADRO DE RESUMEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "MONTO BRUTO";
            // 
            // lblMontoBruto
            // 
            this.lblMontoBruto.AutoSize = true;
            this.lblMontoBruto.Location = new System.Drawing.Point(36, 62);
            this.lblMontoBruto.Name = "lblMontoBruto";
            this.lblMontoBruto.Size = new System.Drawing.Size(38, 15);
            this.lblMontoBruto.TabIndex = 1;
            this.lblMontoBruto.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "MONTO DESCUENTO";
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Location = new System.Drawing.Point(251, 62);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(38, 15);
            this.lblMontoDescuento.TabIndex = 3;
            this.lblMontoDescuento.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "MONTO NETO";
            // 
            // lblMontoNeto
            // 
            this.lblMontoNeto.AutoSize = true;
            this.lblMontoNeto.Location = new System.Drawing.Point(468, 62);
            this.lblMontoNeto.Name = "lblMontoNeto";
            this.lblMontoNeto.Size = new System.Drawing.Size(44, 15);
            this.lblMontoNeto.TabIndex = 5;
            this.lblMontoNeto.Text = "label10";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(60, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FRMPagoEmpleado);
            this.Name = "Form1";
            this.Text = "Control de pago de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FRMPagoEmpleado;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnProcesar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Label lblMontoNeto;
        private Label label9;
        private Label lblMontoDescuento;
        private Label label7;
        private Label lblMontoBruto;
        private Label label5;
        private Button btnSalir;
    }
}