namespace IrisContabilidad.modulo_nomina
{
    partial class ventana_nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_nomina));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaInicialText = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalText = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoNominaText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tipoNominaIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 358);
            this.panel1.Size = new System.Drawing.Size(742, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(554, 6);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(763, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(278, 6);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 146;
            this.label2.Text = "Initial date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "Final date";
            // 
            // fechaInicialText
            // 
            this.fechaInicialText.Location = new System.Drawing.Point(182, 166);
            this.fechaInicialText.Name = "fechaInicialText";
            this.fechaInicialText.Size = new System.Drawing.Size(200, 22);
            this.fechaInicialText.TabIndex = 148;
            // 
            // fechaFinalText
            // 
            this.fechaFinalText.Location = new System.Drawing.Point(182, 230);
            this.fechaFinalText.Name = "fechaFinalText";
            this.fechaFinalText.Size = new System.Drawing.Size(200, 22);
            this.fechaFinalText.TabIndex = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoNominaText);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.tipoNominaIdText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaFinalText);
            this.groupBox1.Controls.Add(this.fechaInicialText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 319);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TipoNominaText
            // 
            this.TipoNominaText.BackColor = System.Drawing.Color.SkyBlue;
            this.TipoNominaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoNominaText.Location = new System.Drawing.Point(182, 100);
            this.TipoNominaText.Margin = new System.Windows.Forms.Padding(4);
            this.TipoNominaText.Name = "TipoNominaText";
            this.TipoNominaText.ReadOnly = true;
            this.TipoNominaText.Size = new System.Drawing.Size(243, 30);
            this.TipoNominaText.TabIndex = 153;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(362, 51);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 152;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tipoNominaIdText
            // 
            this.tipoNominaIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.tipoNominaIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoNominaIdText.Location = new System.Drawing.Point(182, 58);
            this.tipoNominaIdText.Margin = new System.Windows.Forms.Padding(4);
            this.tipoNominaIdText.Name = "tipoNominaIdText";
            this.tipoNominaIdText.ReadOnly = true;
            this.tipoNominaIdText.Size = new System.Drawing.Size(172, 30);
            this.tipoNominaIdText.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 150;
            this.label3.Text = "Type of payroll";
            // 
            // ventana_nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 437);
            this.Controls.Add(this.groupBox1);
            this.Name = "ventana_nomina";
            this.Text = "ventana_nomina";
            this.Load += new System.EventHandler(this.ventana_nomina_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaInicialText;
        private System.Windows.Forms.DateTimePicker fechaFinalText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipoNominaIdText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TipoNominaText;
    }
}