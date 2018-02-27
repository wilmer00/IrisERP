using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_empresa
{
    partial class ventana_configuracion_comprobante_fiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_configuracion_comprobante_fiscal));
            this.numeroInicialText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultimoUsadoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroFinalText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comprobanteTipoText = new System.Windows.Forms.TextBox();
            this.comprobanteTipoIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cajaText = new System.Windows.Forms.TextBox();
            this.cajaIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 491);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(748, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(560, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(780, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(280, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numeroInicialText
            // 
            this.numeroInicialText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroInicialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroInicialText.Location = new System.Drawing.Point(227, 229);
            this.numeroInicialText.Margin = new System.Windows.Forms.Padding(4);
            this.numeroInicialText.MaxLength = 30;
            this.numeroInicialText.Name = "numeroInicialText";
            this.numeroInicialText.Size = new System.Drawing.Size(336, 30);
            this.numeroInicialText.TabIndex = 69;
            this.numeroInicialText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeroInicialText_KeyDown);
            this.numeroInicialText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroInicialText_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Initial number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultimoUsadoText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeroFinalText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numeroInicialText);
            this.groupBox1.Controls.Add(this.comprobanteTipoText);
            this.groupBox1.Controls.Add(this.comprobanteTipoIdText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cajaText);
            this.groupBox1.Controls.Add(this.cajaIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(744, 450);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // ultimoUsadoText
            // 
            this.ultimoUsadoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultimoUsadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoUsadoText.Location = new System.Drawing.Point(227, 353);
            this.ultimoUsadoText.Margin = new System.Windows.Forms.Padding(4);
            this.ultimoUsadoText.MaxLength = 30;
            this.ultimoUsadoText.Name = "ultimoUsadoText";
            this.ultimoUsadoText.Size = new System.Drawing.Size(336, 30);
            this.ultimoUsadoText.TabIndex = 79;
            this.ultimoUsadoText.Text = "0";
            this.ultimoUsadoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultimoUsadoText_KeyDown);
            this.ultimoUsadoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultimoUsadoText_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Last used";
            // 
            // numeroFinalText
            // 
            this.numeroFinalText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroFinalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroFinalText.Location = new System.Drawing.Point(227, 290);
            this.numeroFinalText.Margin = new System.Windows.Forms.Padding(4);
            this.numeroFinalText.MaxLength = 30;
            this.numeroFinalText.Name = "numeroFinalText";
            this.numeroFinalText.Size = new System.Drawing.Size(336, 30);
            this.numeroFinalText.TabIndex = 77;
            this.numeroFinalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeroFinalText_KeyDown);
            this.numeroFinalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroFinalText_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Final number";
            // 
            // comprobanteTipoText
            // 
            this.comprobanteTipoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprobanteTipoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprobanteTipoText.Location = new System.Drawing.Point(227, 166);
            this.comprobanteTipoText.Margin = new System.Windows.Forms.Padding(4);
            this.comprobanteTipoText.MaxLength = 9999;
            this.comprobanteTipoText.Name = "comprobanteTipoText";
            this.comprobanteTipoText.ReadOnly = true;
            this.comprobanteTipoText.Size = new System.Drawing.Size(336, 30);
            this.comprobanteTipoText.TabIndex = 75;
            // 
            // comprobanteTipoIdText
            // 
            this.comprobanteTipoIdText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprobanteTipoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.comprobanteTipoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprobanteTipoIdText.Location = new System.Drawing.Point(227, 126);
            this.comprobanteTipoIdText.Margin = new System.Windows.Forms.Padding(4);
            this.comprobanteTipoIdText.Name = "comprobanteTipoIdText";
            this.comprobanteTipoIdText.Size = new System.Drawing.Size(205, 30);
            this.comprobanteTipoIdText.TabIndex = 73;
            this.comprobanteTipoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprobanteTipoIdText_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Voucher type";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(441, 119);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 74;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cajaText
            // 
            this.cajaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cajaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaText.Location = new System.Drawing.Point(227, 70);
            this.cajaText.Margin = new System.Windows.Forms.Padding(4);
            this.cajaText.MaxLength = 9999;
            this.cajaText.Name = "cajaText";
            this.cajaText.ReadOnly = true;
            this.cajaText.Size = new System.Drawing.Size(336, 30);
            this.cajaText.TabIndex = 71;
            // 
            // cajaIdText
            // 
            this.cajaIdText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cajaIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.cajaIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaIdText.Location = new System.Drawing.Point(227, 30);
            this.cajaIdText.Margin = new System.Windows.Forms.Padding(4);
            this.cajaIdText.Name = "cajaIdText";
            this.cajaIdText.Size = new System.Drawing.Size(205, 30);
            this.cajaIdText.TabIndex = 18;
            this.cajaIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cajaIdText_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cashbox";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(441, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ventana_configuracion_comprobante_fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 572);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ventana_configuracion_comprobante_fiscal";
            this.Text = "ventana_configuracion_comprobante_fiscal";
            this.Load += new System.EventHandler(this.ventana_configuracion_comprobante_fiscal_Load);
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

        public TextBox numeroInicialText;
        private Label label3;
        private GroupBox groupBox1;
        public TextBox cajaText;
        private TextBox cajaIdText;
        private Label label2;
        private Button button4;
        public TextBox comprobanteTipoText;
        private TextBox comprobanteTipoIdText;
        private Label label1;
        private Button button5;
        public TextBox numeroFinalText;
        private Label label4;
        public TextBox ultimoUsadoText;
        private Label label5;
    }
}