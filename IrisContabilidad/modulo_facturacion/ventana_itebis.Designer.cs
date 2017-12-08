using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_itebis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_itebis));
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itbisIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.porcientoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(711, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(523, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(743, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(261, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(200, 284);
            this.activoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(79, 24);
            this.activoCheck.TabIndex = 70;
            this.activoCheck.Text = "Active";
            this.activoCheck.UseVisualStyleBackColor = true;
            this.activoCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activoCheck_KeyDown);
            // 
            // nombreText
            // 
            this.nombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreText.Location = new System.Drawing.Point(200, 159);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreText.MaxLength = 30;
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(336, 30);
            this.nombreText.TabIndex = 69;
            this.nombreText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itbisIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 81);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // itbisIdText
            // 
            this.itbisIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.itbisIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itbisIdText.Location = new System.Drawing.Point(184, 27);
            this.itbisIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itbisIdText.Name = "itbisIdText";
            this.itbisIdText.Size = new System.Drawing.Size(205, 30);
            this.itbisIdText.TabIndex = 18;
            this.itbisIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itbisIdText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tax ID";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(399, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // porcientoText
            // 
            this.porcientoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcientoText.Location = new System.Drawing.Point(200, 224);
            this.porcientoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porcientoText.MaxLength = 7;
            this.porcientoText.Name = "porcientoText";
            this.porcientoText.Size = new System.Drawing.Size(336, 30);
            this.porcientoText.TabIndex = 72;
            this.porcientoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.porcientoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.porcientoText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Percent";
            // 
            // ventana_itebis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 463);
            this.Controls.Add(this.porcientoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activoCheck);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_itebis";
            this.Text = "ventana_itebis";
            this.Load += new System.EventHandler(this.ventana_itebis_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nombreText, 0);
            this.Controls.SetChildIndex(this.activoCheck, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.porcientoText, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox activoCheck;
        public TextBox nombreText;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox itbisIdText;
        private Label label2;
        private Button button4;
        public TextBox porcientoText;
        private Label label1;
    }
}