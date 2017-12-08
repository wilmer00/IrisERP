using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_vendedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vendedorIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.empleadoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.porcientoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadoIdText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 400);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(703, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(515, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(735, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(257, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vendedorIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 81);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // vendedorIdText
            // 
            this.vendedorIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.vendedorIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorIdText.Location = new System.Drawing.Point(165, 23);
            this.vendedorIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vendedorIdText.Name = "vendedorIdText";
            this.vendedorIdText.Size = new System.Drawing.Size(205, 30);
            this.vendedorIdText.TabIndex = 18;
            this.vendedorIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vendedorIdText_KeyDown);
            this.vendedorIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vendedorIdText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seller";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(380, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empleadoText
            // 
            this.empleadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoText.Location = new System.Drawing.Point(187, 201);
            this.empleadoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empleadoText.MaxLength = 30;
            this.empleadoText.Name = "empleadoText";
            this.empleadoText.ReadOnly = true;
            this.empleadoText.Size = new System.Drawing.Size(336, 30);
            this.empleadoText.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Employee";
            // 
            // porcientoText
            // 
            this.porcientoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcientoText.Location = new System.Drawing.Point(187, 287);
            this.porcientoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porcientoText.MaxLength = 5;
            this.porcientoText.Name = "porcientoText";
            this.porcientoText.Size = new System.Drawing.Size(336, 30);
            this.porcientoText.TabIndex = 79;
            this.porcientoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.porcientoText_KeyDown);
            this.porcientoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.porcientoText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Percent (%)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empleadoIdText
            // 
            this.empleadoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.empleadoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdText.Location = new System.Drawing.Point(187, 154);
            this.empleadoIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empleadoIdText.Name = "empleadoIdText";
            this.empleadoIdText.Size = new System.Drawing.Size(205, 30);
            this.empleadoIdText.TabIndex = 24;
            this.empleadoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.empleadoIdText_KeyDown);
            this.empleadoIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empleadoIdText_KeyPress);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(401, 148);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(187, 351);
            this.activoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(79, 24);
            this.activoCheck.TabIndex = 80;
            this.activoCheck.Text = "Active";
            this.activoCheck.UseVisualStyleBackColor = true;
            this.activoCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activoCheck_KeyDown);
            this.activoCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activoCheck_KeyPress);
            // 
            // ventana_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 481);
            this.Controls.Add(this.activoCheck);
            this.Controls.Add(this.empleadoIdText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.porcientoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empleadoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_vendedor";
            this.Text = "ventana_vendedor";
            this.Load += new System.EventHandler(this.ventana_vendedor_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.empleadoText, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.porcientoText, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.empleadoIdText, 0);
            this.Controls.SetChildIndex(this.activoCheck, 0);
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
        private TextBox vendedorIdText;
        private Label label2;
        private Button button4;
        public TextBox empleadoText;
        private Label label3;
        public TextBox porcientoText;
        private Label label1;
        private TextBox empleadoIdText;
        private Button button5;
        private CheckBox activoCheck;
    }
}