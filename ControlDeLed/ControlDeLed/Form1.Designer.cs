namespace ControlDeLed
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
            this.components = new System.ComponentModel.Container();
            this.label_Led = new System.Windows.Forms.Label();
            this.button_ON = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Led
            // 
            this.label_Led.AutoSize = true;
            this.label_Led.BackColor = System.Drawing.Color.OrangeRed;
            this.label_Led.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Led.Location = new System.Drawing.Point(107, 31);
            this.label_Led.Name = "label_Led";
            this.label_Led.Size = new System.Drawing.Size(57, 25);
            this.label_Led.TabIndex = 0;
            this.label_Led.Text = "OFF";
            this.label_Led.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_ON
            // 
            this.button_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ON.Location = new System.Drawing.Point(18, 79);
            this.button_ON.Name = "button_ON";
            this.button_ON.Size = new System.Drawing.Size(110, 44);
            this.button_ON.TabIndex = 1;
            this.button_ON.Text = "ENCENDER";
            this.button_ON.UseVisualStyleBackColor = true;
            this.button_ON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OFF);
            this.groupBox1.Controls.Add(this.label_Led);
            this.groupBox1.Controls.Add(this.button_ON);
            this.groupBox1.Location = new System.Drawing.Point(25, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Led 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_OFF
            // 
            this.button_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OFF.Location = new System.Drawing.Point(146, 79);
            this.button_OFF.Name = "button_OFF";
            this.button_OFF.Size = new System.Drawing.Size(108, 44);
            this.button_OFF.TabIndex = 2;
            this.button_OFF.Text = "APAGAR";
            this.button_OFF.UseVisualStyleBackColor = true;
            this.button_OFF.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 246);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CONTROL LED APP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Led;
        private System.Windows.Forms.Button button_ON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OFF;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

