using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_gerencia
{
    partial class ventana_reporte_ventas_mensuales_grafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_reporte_ventas_mensuales_grafico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anofinalText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anoInicialText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clienteIdText = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.empleadoLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.empleadoIdText = new System.Windows.Forms.TextBox();
            this.radioSoloVentasCobradas = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoVentaComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 592);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1124, 66);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(936, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1156, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(468, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anofinalText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.anoInicialText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1120, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango años";
            // 
            // anofinalText
            // 
            this.anofinalText.BackColor = System.Drawing.Color.White;
            this.anofinalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anofinalText.Location = new System.Drawing.Point(429, 39);
            this.anofinalText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anofinalText.MaxLength = 4;
            this.anofinalText.Name = "anofinalText";
            this.anofinalText.Size = new System.Drawing.Size(147, 30);
            this.anofinalText.TabIndex = 18;
            this.anofinalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anofinalText_KeyDown);
            this.anofinalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Final year";
            // 
            // anoInicialText
            // 
            this.anoInicialText.BackColor = System.Drawing.Color.White;
            this.anoInicialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoInicialText.Location = new System.Drawing.Point(152, 39);
            this.anoInicialText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anoInicialText.MaxLength = 4;
            this.anoInicialText.Name = "anoInicialText";
            this.anoInicialText.Size = new System.Drawing.Size(147, 30);
            this.anoInicialText.TabIndex = 16;
            this.anoInicialText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anoInicialText_KeyDown);
            this.anoInicialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Initial year";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(445, 155);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Customer";
            // 
            // clienteIdText
            // 
            this.clienteIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.clienteIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdText.Location = new System.Drawing.Point(193, 160);
            this.clienteIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteIdText.Name = "clienteIdText";
            this.clienteIdText.Size = new System.Drawing.Size(243, 30);
            this.clienteIdText.TabIndex = 25;
            this.clienteIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clienteIdText_KeyDown);
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.Location = new System.Drawing.Point(197, 203);
            this.clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(159, 25);
            this.clienteLabel.TabIndex = 28;
            this.clienteLabel.Text = "customer name";
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoLabel.Location = new System.Drawing.Point(197, 294);
            this.empleadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(164, 25);
            this.empleadoLabel.TabIndex = 32;
            this.empleadoLabel.Text = "employee name";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(445, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Employee";
            // 
            // empleadoIdText
            // 
            this.empleadoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.empleadoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdText.Location = new System.Drawing.Point(193, 251);
            this.empleadoIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empleadoIdText.Name = "empleadoIdText";
            this.empleadoIdText.Size = new System.Drawing.Size(243, 30);
            this.empleadoIdText.TabIndex = 29;
            this.empleadoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empleadoIdText_KeyDown);
            // 
            // radioSoloVentasCobradas
            // 
            this.radioSoloVentasCobradas.AutoSize = true;
            this.radioSoloVentasCobradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSoloVentasCobradas.Location = new System.Drawing.Point(896, 155);
            this.radioSoloVentasCobradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSoloVentasCobradas.Name = "radioSoloVentasCobradas";
            this.radioSoloVentasCobradas.Size = new System.Drawing.Size(160, 24);
            this.radioSoloVentasCobradas.TabIndex = 33;
            this.radioSoloVentasCobradas.TabStop = true;
            this.radioSoloVentasCobradas.Text = "Only paid sales";
            this.radioSoloVentasCobradas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sale type";
            // 
            // tipoVentaComboBox
            // 
            this.tipoVentaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoVentaComboBox.FormattingEnabled = true;
            this.tipoVentaComboBox.Location = new System.Drawing.Point(193, 345);
            this.tipoVentaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoVentaComboBox.Name = "tipoVentaComboBox";
            this.tipoVentaComboBox.Size = new System.Drawing.Size(243, 24);
            this.tipoVentaComboBox.TabIndex = 145;
            this.tipoVentaComboBox.Tag = "";
            // 
            // ventana_reporte_ventas_mensuales_grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 673);
            this.Controls.Add(this.tipoVentaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioSoloVentasCobradas);
            this.Controls.Add(this.empleadoLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empleadoIdText);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clienteIdText);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_reporte_ventas_mensuales_grafico";
            this.Text = "ventana_reporte_ventas_mensuales_grafico";
            this.Load += new System.EventHandler(this.ventana_reporte_ventas_mensuales_grafico_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.clienteIdText, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.clienteLabel, 0);
            this.Controls.SetChildIndex(this.empleadoIdText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.empleadoLabel, 0);
            this.Controls.SetChildIndex(this.radioSoloVentasCobradas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tipoVentaComboBox, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox anofinalText;
        private Label label1;
        private TextBox anoInicialText;
        private Label label2;
        private Button button4;
        private Label label3;
        private TextBox clienteIdText;
        private Label clienteLabel;
        private Label empleadoLabel;
        private Button button5;
        private Label label5;
        private TextBox empleadoIdText;
        private RadioButton radioSoloVentasCobradas;
        private Label label6;
        private ComboBox tipoVentaComboBox;
    }
}