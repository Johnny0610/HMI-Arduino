namespace ControlDeLed2
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
            this.groupBoxPort = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxLed = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLedOn = new System.Windows.Forms.Button();
            this.buttonLedOff = new System.Windows.Forms.Button();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.groupBoxPort.SuspendLayout();
            this.groupBoxLed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxPort.Controls.Add(this.progressBarConnection);
            this.groupBoxPort.Controls.Add(this.buttonClose);
            this.groupBoxPort.Controls.Add(this.buttonOpen);
            this.groupBoxPort.Controls.Add(this.comboBoxBaud);
            this.groupBoxPort.Controls.Add(this.comboBoxPort);
            this.groupBoxPort.Controls.Add(this.labelBaud);
            this.groupBoxPort.Controls.Add(this.labelPort);
            this.groupBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxPort.Location = new System.Drawing.Point(24, 39);
            this.groupBoxPort.Name = "groupBoxPort";
            this.groupBoxPort.Size = new System.Drawing.Size(281, 239);
            this.groupBoxPort.TabIndex = 0;
            this.groupBoxPort.TabStop = false;
            this.groupBoxPort.Text = "Puerto COM";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(162, 150);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 32);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(27, 150);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(92, 32);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(133, 93);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(133, 52);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPort.TabIndex = 2;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(35, 103);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(77, 18);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud Rate";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(35, 56);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(92, 18);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Puerto COM";
            // 
            // groupBoxLed
            // 
            this.groupBoxLed.Controls.Add(this.buttonLedOff);
            this.groupBoxLed.Controls.Add(this.buttonLedOn);
            this.groupBoxLed.Controls.Add(this.pictureBox1);
            this.groupBoxLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLed.Location = new System.Drawing.Point(346, 39);
            this.groupBoxLed.Name = "groupBoxLed";
            this.groupBoxLed.Size = new System.Drawing.Size(324, 239);
            this.groupBoxLed.TabIndex = 1;
            this.groupBoxLed.TabStop = false;
            this.groupBoxLed.Text = "Led";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ControlDeLed2.Properties.Resources.led_off;
            this.pictureBox1.Location = new System.Drawing.Point(100, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLedOn
            // 
            this.buttonLedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn.Location = new System.Drawing.Point(23, 172);
            this.buttonLedOn.Name = "buttonLedOn";
            this.buttonLedOn.Size = new System.Drawing.Size(92, 32);
            this.buttonLedOn.TabIndex = 6;
            this.buttonLedOn.Text = "Prender";
            this.buttonLedOn.UseVisualStyleBackColor = true;
            // 
            // buttonLedOff
            // 
            this.buttonLedOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff.Location = new System.Drawing.Point(207, 172);
            this.buttonLedOff.Name = "buttonLedOff";
            this.buttonLedOff.Size = new System.Drawing.Size(92, 32);
            this.buttonLedOff.TabIndex = 7;
            this.buttonLedOff.Text = "Apagar";
            this.buttonLedOff.UseVisualStyleBackColor = true;
            this.buttonLedOff.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(17, 198);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(254, 23);
            this.progressBarConnection.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 316);
            this.Controls.Add(this.groupBoxLed);
            this.Controls.Add(this.groupBoxPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Control de Led";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPort.ResumeLayout(false);
            this.groupBoxPort.PerformLayout();
            this.groupBoxLed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxLed;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLedOff;
        private System.Windows.Forms.Button buttonLedOn;
        private System.Windows.Forms.ProgressBar progressBarConnection;
    }
}

