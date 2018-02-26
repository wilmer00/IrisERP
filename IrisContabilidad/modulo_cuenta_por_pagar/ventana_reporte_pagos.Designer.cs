using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_cuenta_por_pagar
{
    partial class ventana_reporte_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_reporte_pagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoCompraComboBox = new System.Windows.Forms.ComboBox();
            this.compraLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.compraIdText = new System.Windows.Forms.TextBox();
            this.suplidorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.suplidorIdText = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaInicialText = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalText = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIncluirRangoFechaVenta = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSoloComprasPagadas = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 646);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1010, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(822, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1042, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(412, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tipoCompraComboBox);
            this.groupBox1.Controls.Add(this.compraLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.compraIdText);
            this.groupBox1.Controls.Add(this.suplidorLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.suplidorIdText);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1006, 249);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 99;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 98;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Purchase\'s type";
            // 
            // tipoCompraComboBox
            // 
            this.tipoCompraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCompraComboBox.FormattingEnabled = true;
            this.tipoCompraComboBox.Items.AddRange(new object[] {
            "",
            "CONTADO",
            "COTIZACION",
            "CREDITO",
            "PEDIDO"});
            this.tipoCompraComboBox.Location = new System.Drawing.Point(198, 201);
            this.tipoCompraComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoCompraComboBox.Name = "tipoCompraComboBox";
            this.tipoCompraComboBox.Size = new System.Drawing.Size(313, 24);
            this.tipoCompraComboBox.TabIndex = 84;
            this.tipoCompraComboBox.Tag = "";
            // 
            // compraLabel
            // 
            this.compraLabel.AutoSize = true;
            this.compraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraLabel.Location = new System.Drawing.Point(177, 159);
            this.compraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.compraLabel.Name = "compraLabel";
            this.compraLabel.Size = new System.Drawing.Size(213, 25);
            this.compraLabel.TabIndex = 83;
            this.compraLabel.Text = "numero compra label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Purchase";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(433, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 81;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // compraIdText
            // 
            this.compraIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.compraIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraIdText.Location = new System.Drawing.Point(181, 110);
            this.compraIdText.Margin = new System.Windows.Forms.Padding(4);
            this.compraIdText.Name = "compraIdText";
            this.compraIdText.Size = new System.Drawing.Size(243, 30);
            this.compraIdText.TabIndex = 80;
            // 
            // suplidorLabel
            // 
            this.suplidorLabel.AutoSize = true;
            this.suplidorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidorLabel.Location = new System.Drawing.Point(177, 70);
            this.suplidorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suplidorLabel.Name = "suplidorLabel";
            this.suplidorLabel.Size = new System.Drawing.Size(163, 25);
            this.suplidorLabel.TabIndex = 79;
            this.suplidorLabel.Text = "supplier\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Supplier";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(433, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 74;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // suplidorIdText
            // 
            this.suplidorIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.suplidorIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidorIdText.Location = new System.Drawing.Point(181, 21);
            this.suplidorIdText.Margin = new System.Windows.Forms.Padding(4);
            this.suplidorIdText.Name = "suplidorIdText";
            this.suplidorIdText.Size = new System.Drawing.Size(243, 30);
            this.suplidorIdText.TabIndex = 71;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(838, 431);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 50);
            this.button6.TabIndex = 96;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaInicialText);
            this.groupBox2.Controls.Add(this.fechaFinalText);
            this.groupBox2.Controls.Add(this.checkBoxIncluirRangoFechaVenta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxSoloComprasPagadas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1006, 133);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase\'s date";
            // 
            // fechaInicialText
            // 
            this.fechaInicialText.Location = new System.Drawing.Point(146, 78);
            this.fechaInicialText.Name = "fechaInicialText";
            this.fechaInicialText.Size = new System.Drawing.Size(244, 22);
            this.fechaInicialText.TabIndex = 100;
            // 
            // fechaFinalText
            // 
            this.fechaFinalText.Location = new System.Drawing.Point(733, 77);
            this.fechaFinalText.Name = "fechaFinalText";
            this.fechaFinalText.Size = new System.Drawing.Size(246, 22);
            this.fechaFinalText.TabIndex = 101;
            // 
            // checkBoxIncluirRangoFechaVenta
            // 
            this.checkBoxIncluirRangoFechaVenta.AutoSize = true;
            this.checkBoxIncluirRangoFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIncluirRangoFechaVenta.Location = new System.Drawing.Point(24, 33);
            this.checkBoxIncluirRangoFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIncluirRangoFechaVenta.Name = "checkBoxIncluirRangoFechaVenta";
            this.checkBoxIncluirRangoFechaVenta.Size = new System.Drawing.Size(201, 24);
            this.checkBoxIncluirRangoFechaVenta.TabIndex = 90;
            this.checkBoxIncluirRangoFechaVenta.Text = "Include date\'s range";
            this.checkBoxIncluirRangoFechaVenta.UseVisualStyleBackColor = true;
            this.checkBoxIncluirRangoFechaVenta.Click += new System.EventHandler(this.checkBoxIncluirRangoFechaVenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Initial date";
            // 
            // checkBoxSoloComprasPagadas
            // 
            this.checkBoxSoloComprasPagadas.AutoSize = true;
            this.checkBoxSoloComprasPagadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSoloComprasPagadas.Location = new System.Drawing.Point(561, 33);
            this.checkBoxSoloComprasPagadas.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSoloComprasPagadas.Name = "checkBoxSoloComprasPagadas";
            this.checkBoxSoloComprasPagadas.Size = new System.Drawing.Size(203, 24);
            this.checkBoxSoloComprasPagadas.TabIndex = 91;
            this.checkBoxSoloComprasPagadas.Text = "Only paid purchases";
            this.checkBoxSoloComprasPagadas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "final date";
            // 
            // ventana_reporte_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ventana_reporte_pagos";
            this.Text = "ventana_reporte_pagos";
            this.Load += new System.EventHandler(this.ventana_reporte_pagos_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label1;
        private Button button6;
        private CheckBox checkBoxSoloComprasPagadas;
        private GroupBox groupBox2;
        private CheckBox checkBoxIncluirRangoFechaVenta;
        private Label label5;
        private Label label6;
        private Label label4;
        private ComboBox tipoCompraComboBox;
        private Label compraLabel;
        private Label label3;
        private Button button4;
        private TextBox compraIdText;
        private Label suplidorLabel;
        private Label label2;
        private Button button5;
        private TextBox suplidorIdText;
        private DateTimePicker fechaInicialText;
        private DateTimePicker fechaFinalText;
    }
}