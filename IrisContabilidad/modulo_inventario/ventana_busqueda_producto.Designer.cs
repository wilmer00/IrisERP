using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_inventario
{
    partial class ventana_busqueda_producto
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
            this.almacenRadionButton = new System.Windows.Forms.RadioButton();
            this.subCategoriaRadionButton = new System.Windows.Forms.RadioButton();
            this.categoriaRadionButton = new System.Windows.Forms.RadioButton();
            this.referenciaRadioButton = new System.Windows.Forms.RadioButton();
            this.nombreRadioButton = new System.Windows.Forms.RadioButton();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secuenciacolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenciaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 670);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1253, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1065, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1285, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(533, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.almacenRadionButton);
            this.groupBox1.Controls.Add(this.subCategoriaRadionButton);
            this.groupBox1.Controls.Add(this.categoriaRadionButton);
            this.groupBox1.Controls.Add(this.referenciaRadioButton);
            this.groupBox1.Controls.Add(this.nombreRadioButton);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1253, 133);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // almacenRadionButton
            // 
            this.almacenRadionButton.AutoSize = true;
            this.almacenRadionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.almacenRadionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacenRadionButton.Location = new System.Drawing.Point(740, 79);
            this.almacenRadionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.almacenRadionButton.Name = "almacenRadionButton";
            this.almacenRadionButton.Size = new System.Drawing.Size(117, 25);
            this.almacenRadionButton.TabIndex = 25;
            this.almacenRadionButton.TabStop = true;
            this.almacenRadionButton.Text = "Wareouse";
            this.almacenRadionButton.UseVisualStyleBackColor = true;
            // 
            // subCategoriaRadionButton
            // 
            this.subCategoriaRadionButton.AutoSize = true;
            this.subCategoriaRadionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subCategoriaRadionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategoriaRadionButton.Location = new System.Drawing.Point(548, 79);
            this.subCategoriaRadionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subCategoriaRadionButton.Name = "subCategoriaRadionButton";
            this.subCategoriaRadionButton.Size = new System.Drawing.Size(147, 25);
            this.subCategoriaRadionButton.TabIndex = 24;
            this.subCategoriaRadionButton.TabStop = true;
            this.subCategoriaRadionButton.Text = "Sub-Category";
            this.subCategoriaRadionButton.UseVisualStyleBackColor = true;
            // 
            // categoriaRadionButton
            // 
            this.categoriaRadionButton.AutoSize = true;
            this.categoriaRadionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoriaRadionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaRadionButton.Location = new System.Drawing.Point(396, 79);
            this.categoriaRadionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoriaRadionButton.Name = "categoriaRadionButton";
            this.categoriaRadionButton.Size = new System.Drawing.Size(108, 25);
            this.categoriaRadionButton.TabIndex = 23;
            this.categoriaRadionButton.TabStop = true;
            this.categoriaRadionButton.Text = "Category";
            this.categoriaRadionButton.UseVisualStyleBackColor = true;
            // 
            // referenciaRadioButton
            // 
            this.referenciaRadioButton.AutoSize = true;
            this.referenciaRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.referenciaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaRadioButton.Location = new System.Drawing.Point(237, 79);
            this.referenciaRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.referenciaRadioButton.Name = "referenciaRadioButton";
            this.referenciaRadioButton.Size = new System.Drawing.Size(119, 25);
            this.referenciaRadioButton.TabIndex = 22;
            this.referenciaRadioButton.TabStop = true;
            this.referenciaRadioButton.Text = "Reference";
            this.referenciaRadioButton.UseVisualStyleBackColor = true;
            // 
            // nombreRadioButton
            // 
            this.nombreRadioButton.AutoSize = true;
            this.nombreRadioButton.Checked = true;
            this.nombreRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nombreRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRadioButton.Location = new System.Drawing.Point(112, 79);
            this.nombreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreRadioButton.Name = "nombreRadioButton";
            this.nombreRadioButton.Size = new System.Drawing.Size(81, 25);
            this.nombreRadioButton.TabIndex = 21;
            this.nombreRadioButton.TabStop = true;
            this.nombreRadioButton.Text = "Name";
            this.nombreRadioButton.UseVisualStyleBackColor = true;
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
            this.ReferenciaColumn,
            this.CategoriaColumn,
            this.SubCategoriaColumn,
            this.activoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 489);
            this.dataGridView1.TabIndex = 28;
            // 
            // codigoColumn
            // 
            this.codigoColumn.FillWeight = 30F;
            this.codigoColumn.HeaderText = "ID";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            // 
            // secuenciacolumn
            // 
            this.secuenciacolumn.HeaderText = "Name";
            this.secuenciacolumn.Name = "secuenciacolumn";
            this.secuenciacolumn.ReadOnly = true;
            // 
            // ReferenciaColumn
            // 
            this.ReferenciaColumn.FillWeight = 50F;
            this.ReferenciaColumn.HeaderText = "Reference";
            this.ReferenciaColumn.Name = "ReferenciaColumn";
            this.ReferenciaColumn.ReadOnly = true;
            // 
            // CategoriaColumn
            // 
            this.CategoriaColumn.FillWeight = 60F;
            this.CategoriaColumn.HeaderText = "Category";
            this.CategoriaColumn.Name = "CategoriaColumn";
            this.CategoriaColumn.ReadOnly = true;
            // 
            // SubCategoriaColumn
            // 
            this.SubCategoriaColumn.FillWeight = 60F;
            this.SubCategoriaColumn.HeaderText = "sub-Category";
            this.SubCategoriaColumn.Name = "SubCategoriaColumn";
            this.SubCategoriaColumn.ReadOnly = true;
            // 
            // activoColumn
            // 
            this.activoColumn.FillWeight = 30F;
            this.activoColumn.HeaderText = "Active";
            this.activoColumn.Name = "activoColumn";
            this.activoColumn.ReadOnly = true;
            // 
            // ventana_busqueda_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_busqueda_producto";
            this.Text = "ventana_busqueda_producto";
            this.Load += new System.EventHandler(this.ventana_busqueda_producto_Load);
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
        private RadioButton nombreRadioButton;
        private RadioButton almacenRadionButton;
        private RadioButton subCategoriaRadionButton;
        private RadioButton categoriaRadionButton;
        private RadioButton referenciaRadioButton;
        private DataGridViewTextBoxColumn codigoColumn;
        private DataGridViewTextBoxColumn secuenciacolumn;
        private DataGridViewTextBoxColumn ReferenciaColumn;
        private DataGridViewTextBoxColumn CategoriaColumn;
        private DataGridViewTextBoxColumn SubCategoriaColumn;
        private DataGridViewTextBoxColumn activoColumn;
    }
}