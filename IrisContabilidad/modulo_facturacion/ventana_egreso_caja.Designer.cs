using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_egreso_caja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_egreso_caja));
            this.montoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.conceptoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.egresoIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.conceptoIdText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.detalleText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 550);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(912, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(724, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(944, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(363, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // montoText
            // 
            this.montoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoText.Location = new System.Drawing.Point(205, 258);
            this.montoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoText.MaxLength = 5;
            this.montoText.Name = "montoText";
            this.montoText.Size = new System.Drawing.Size(336, 30);
            this.montoText.TabIndex = 78;
            this.montoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoText_KeyDown);
            this.montoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.porcientoText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Amount";
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(205, 487);
            this.activoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(79, 24);
            this.activoCheck.TabIndex = 76;
            this.activoCheck.Text = "Active";
            this.activoCheck.UseVisualStyleBackColor = true;
            this.activoCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activoCheck_KeyDown);
            // 
            // conceptoText
            // 
            this.conceptoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoText.Location = new System.Drawing.Point(205, 196);
            this.conceptoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conceptoText.MaxLength = 30;
            this.conceptoText.Name = "conceptoText";
            this.conceptoText.ReadOnly = true;
            this.conceptoText.Size = new System.Drawing.Size(336, 30);
            this.conceptoText.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Concept";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.egresoIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(903, 81);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // egresoIdText
            // 
            this.egresoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.egresoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egresoIdText.Location = new System.Drawing.Point(213, 27);
            this.egresoIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.egresoIdText.Name = "egresoIdText";
            this.egresoIdText.Size = new System.Drawing.Size(205, 30);
            this.egresoIdText.TabIndex = 18;
            this.egresoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.egresoIdText_KeyDown);
            this.egresoIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.egresoIdText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cash out";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(428, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // conceptoIdText
            // 
            this.conceptoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.conceptoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoIdText.Location = new System.Drawing.Point(205, 156);
            this.conceptoIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conceptoIdText.Name = "conceptoIdText";
            this.conceptoIdText.Size = new System.Drawing.Size(265, 30);
            this.conceptoIdText.TabIndex = 24;
            this.conceptoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conceptoIdText_KeyDown);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(480, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // detalleText
            // 
            this.detalleText.Location = new System.Drawing.Point(205, 329);
            this.detalleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detalleText.Multiline = true;
            this.detalleText.Name = "detalleText";
            this.detalleText.Size = new System.Drawing.Size(624, 120);
            this.detalleText.TabIndex = 79;
            this.detalleText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detalleText_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Detail";
            // 
            // ventana_egreso_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detalleText);
            this.Controls.Add(this.conceptoIdText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.montoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activoCheck);
            this.Controls.Add(this.conceptoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_egreso_caja";
            this.Text = "ventata_egreso_caja";
            this.Load += new System.EventHandler(this.ventata_egreso_caja_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.conceptoText, 0);
            this.Controls.SetChildIndex(this.activoCheck, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.montoText, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.conceptoIdText, 0);
            this.Controls.SetChildIndex(this.detalleText, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox montoText;
        private Label label1;
        private CheckBox activoCheck;
        public TextBox conceptoText;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox egresoIdText;
        private Label label2;
        private Button button4;
        private TextBox conceptoIdText;
        private Button button5;
        private TextBox detalleText;
        private Label label4;
    }
}