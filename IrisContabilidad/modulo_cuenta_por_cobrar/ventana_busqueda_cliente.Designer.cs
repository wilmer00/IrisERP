using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_cuenta_por_pagar
{
    partial class ventana_busqueda_cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTelefono = new System.Windows.Forms.RadioButton();
            this.radioButtonCatgoria = new System.Windows.Forms.RadioButton();
            this.radioButtonRnc = new System.Windows.Forms.RadioButton();
            this.radioButtonCedula = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secuenciacolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rncColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 577);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1237, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1049, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1269, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(525, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTelefono);
            this.groupBox1.Controls.Add(this.radioButtonCatgoria);
            this.groupBox1.Controls.Add(this.radioButtonRnc);
            this.groupBox1.Controls.Add(this.radioButtonCedula);
            this.groupBox1.Controls.Add(this.radioButtonNombre);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1233, 113);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonTelefono
            // 
            this.radioButtonTelefono.AutoSize = true;
            this.radioButtonTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTelefono.Location = new System.Drawing.Point(615, 63);
            this.radioButtonTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonTelefono.Name = "radioButtonTelefono";
            this.radioButtonTelefono.Size = new System.Drawing.Size(116, 24);
            this.radioButtonTelefono.TabIndex = 25;
            this.radioButtonTelefono.Text = "Telephone";
            this.radioButtonTelefono.UseVisualStyleBackColor = true;
            // 
            // radioButtonCatgoria
            // 
            this.radioButtonCatgoria.AutoSize = true;
            this.radioButtonCatgoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCatgoria.Location = new System.Drawing.Point(461, 63);
            this.radioButtonCatgoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCatgoria.Name = "radioButtonCatgoria";
            this.radioButtonCatgoria.Size = new System.Drawing.Size(105, 24);
            this.radioButtonCatgoria.TabIndex = 24;
            this.radioButtonCatgoria.Text = "Category";
            this.radioButtonCatgoria.UseVisualStyleBackColor = true;
            // 
            // radioButtonRnc
            // 
            this.radioButtonRnc.AutoSize = true;
            this.radioButtonRnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRnc.Location = new System.Drawing.Point(365, 63);
            this.radioButtonRnc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonRnc.Name = "radioButtonRnc";
            this.radioButtonRnc.Size = new System.Drawing.Size(59, 24);
            this.radioButtonRnc.TabIndex = 23;
            this.radioButtonRnc.Text = "TIN";
            this.radioButtonRnc.UseVisualStyleBackColor = true;
            this.radioButtonRnc.CheckedChanged += new System.EventHandler(this.radioButtonRnc_CheckedChanged);
            // 
            // radioButtonCedula
            // 
            this.radioButtonCedula.AutoSize = true;
            this.radioButtonCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCedula.Location = new System.Drawing.Point(240, 63);
            this.radioButtonCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCedula.Name = "radioButtonCedula";
            this.radioButtonCedula.Size = new System.Drawing.Size(67, 24);
            this.radioButtonCedula.TabIndex = 22;
            this.radioButtonCedula.Text = "SSN";
            this.radioButtonCedula.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Checked = true;
            this.radioButtonNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNombre.Location = new System.Drawing.Point(108, 63);
            this.radioButtonNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(78, 24);
            this.radioButtonNombre.TabIndex = 21;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Name";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // nombreText
            // 
            this.nombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreText.Location = new System.Drawing.Point(108, 23);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(527, 30);
            this.nombreText.TabIndex = 20;
            this.nombreText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColumn,
            this.secuenciacolumn,
            this.cedulaColumn,
            this.rncColumn,
            this.categoriaColumn,
            this.telefonoColumn,
            this.activoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 411);
            this.dataGridView1.TabIndex = 28;
            // 
            // codigoColumn
            // 
            this.codigoColumn.FillWeight = 30F;
            this.codigoColumn.HeaderText = "Id";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            // 
            // secuenciacolumn
            // 
            this.secuenciacolumn.HeaderText = "Name";
            this.secuenciacolumn.Name = "secuenciacolumn";
            this.secuenciacolumn.ReadOnly = true;
            // 
            // cedulaColumn
            // 
            this.cedulaColumn.FillWeight = 80F;
            this.cedulaColumn.HeaderText = "SSN";
            this.cedulaColumn.Name = "cedulaColumn";
            this.cedulaColumn.ReadOnly = true;
            // 
            // rncColumn
            // 
            this.rncColumn.FillWeight = 80F;
            this.rncColumn.HeaderText = "TIN";
            this.rncColumn.Name = "rncColumn";
            this.rncColumn.ReadOnly = true;
            // 
            // categoriaColumn
            // 
            this.categoriaColumn.FillWeight = 110F;
            this.categoriaColumn.HeaderText = "Category";
            this.categoriaColumn.Name = "categoriaColumn";
            this.categoriaColumn.ReadOnly = true;
            // 
            // telefonoColumn
            // 
            this.telefonoColumn.HeaderText = "Telephone";
            this.telefonoColumn.Name = "telefonoColumn";
            this.telefonoColumn.ReadOnly = true;
            // 
            // activoColumn
            // 
            this.activoColumn.FillWeight = 30F;
            this.activoColumn.HeaderText = "Active";
            this.activoColumn.Name = "activoColumn";
            this.activoColumn.ReadOnly = true;
            // 
            // ventana_busqueda_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_busqueda_cliente";
            this.Text = "ventana_busqueda_cliente";
            this.Load += new System.EventHandler(this.ventana_busqueda_cliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ventana_busqueda_cliente_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nombreText;
        private Label label3;
        private DataGridView dataGridView1;
        private RadioButton radioButtonTelefono;
        private RadioButton radioButtonCatgoria;
        private RadioButton radioButtonRnc;
        private RadioButton radioButtonCedula;
        private RadioButton radioButtonNombre;
        private DataGridViewTextBoxColumn codigoColumn;
        private DataGridViewTextBoxColumn secuenciacolumn;
        private DataGridViewTextBoxColumn cedulaColumn;
        private DataGridViewTextBoxColumn rncColumn;
        private DataGridViewTextBoxColumn categoriaColumn;
        private DataGridViewTextBoxColumn telefonoColumn;
        private DataGridViewTextBoxColumn activoColumn;
    }
}