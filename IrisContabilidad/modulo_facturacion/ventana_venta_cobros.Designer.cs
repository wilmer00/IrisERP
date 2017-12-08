using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_venta_cobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_venta_cobros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCobradoText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPendienteText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.montoAbonoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metodoPagoComboBox = new System.Windows.Forms.ComboBox();
            this.button20 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.clienteIdText = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.idPrductoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasVencimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroComprobanteFiscalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPendienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAbonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metoopagoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 660);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1361, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1173, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1393, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(587, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 124;
            this.label5.Text = "Change (F2)";
            // 
            // totalCobradoText
            // 
            this.totalCobradoText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalCobradoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCobradoText.Location = new System.Drawing.Point(1115, 598);
            this.totalCobradoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalCobradoText.MaxLength = 200;
            this.totalCobradoText.Name = "totalCobradoText";
            this.totalCobradoText.ReadOnly = true;
            this.totalCobradoText.Size = new System.Drawing.Size(256, 45);
            this.totalCobradoText.TabIndex = 123;
            this.totalCobradoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(941, 607);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 122;
            this.label4.Text = "Total abonado";
            // 
            // totalPendienteText
            // 
            this.totalPendienteText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalPendienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPendienteText.Location = new System.Drawing.Point(676, 598);
            this.totalPendienteText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalPendienteText.MaxLength = 200;
            this.totalPendienteText.Name = "totalPendienteText";
            this.totalPendienteText.ReadOnly = true;
            this.totalPendienteText.Size = new System.Drawing.Size(256, 45);
            this.totalPendienteText.TabIndex = 121;
            this.totalPendienteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(489, 607);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 25);
            this.label14.TabIndex = 120;
            this.label14.Text = "Total pendiente";
            // 
            // montoAbonoText
            // 
            this.montoAbonoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoAbonoText.Location = new System.Drawing.Point(783, 201);
            this.montoAbonoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoAbonoText.Name = "montoAbonoText";
            this.montoAbonoText.Size = new System.Drawing.Size(233, 30);
            this.montoAbonoText.TabIndex = 119;
            this.montoAbonoText.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 118;
            this.label3.Text = "Charge amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "Charge method";
            // 
            // metodoPagoComboBox
            // 
            this.metodoPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoPagoComboBox.FormattingEnabled = true;
            this.metodoPagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Deposito",
            "Cheque"});
            this.metodoPagoComboBox.Location = new System.Drawing.Point(178, 206);
            this.metodoPagoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metodoPagoComboBox.Name = "metodoPagoComboBox";
            this.metodoPagoComboBox.Size = new System.Drawing.Size(251, 24);
            this.metodoPagoComboBox.TabIndex = 116;
            this.metodoPagoComboBox.Tag = "";
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(1191, 161);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(87, 71);
            this.button20.TabIndex = 115;
            this.button20.UseVisualStyleBackColor = true;
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
            this.idPrductoColumn,
            this.fechaColumn,
            this.diasVencimientoColumn,
            this.empleadoColumn,
            this.TipoCompraColumn,
            this.numeroComprobanteFiscalColumn,
            this.FechaLimiteColumn,
            this.MontoPendienteColumn,
            this.MontoAbonoColumn,
            this.metoopagoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 352);
            this.dataGridView1.TabIndex = 114;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clienteText);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.clienteIdText);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1355, 119);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Customer";
            // 
            // clienteText
            // 
            this.clienteText.BackColor = System.Drawing.Color.White;
            this.clienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteText.Location = new System.Drawing.Point(128, 66);
            this.clienteText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteText.MaxLength = 200;
            this.clienteText.Name = "clienteText";
            this.clienteText.ReadOnly = true;
            this.clienteText.Size = new System.Drawing.Size(313, 30);
            this.clienteText.TabIndex = 77;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(380, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 74;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // clienteIdText
            // 
            this.clienteIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.clienteIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdText.Location = new System.Drawing.Point(128, 21);
            this.clienteIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteIdText.Name = "clienteIdText";
            this.clienteIdText.Size = new System.Drawing.Size(243, 30);
            this.clienteIdText.TabIndex = 71;
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(1287, 161);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(85, 71);
            this.button19.TabIndex = 125;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // idPrductoColumn
            // 
            this.idPrductoColumn.FillWeight = 50F;
            this.idPrductoColumn.HeaderText = "ID";
            this.idPrductoColumn.Name = "idPrductoColumn";
            this.idPrductoColumn.ReadOnly = true;
            // 
            // fechaColumn
            // 
            this.fechaColumn.FillWeight = 70F;
            this.fechaColumn.HeaderText = "Date";
            this.fechaColumn.Name = "fechaColumn";
            this.fechaColumn.ReadOnly = true;
            // 
            // diasVencimientoColumn
            // 
            this.diasVencimientoColumn.HeaderText = "Expiration days";
            this.diasVencimientoColumn.Name = "diasVencimientoColumn";
            this.diasVencimientoColumn.ReadOnly = true;
            // 
            // empleadoColumn
            // 
            this.empleadoColumn.FillWeight = 120F;
            this.empleadoColumn.HeaderText = "Employee";
            this.empleadoColumn.Name = "empleadoColumn";
            this.empleadoColumn.ReadOnly = true;
            // 
            // TipoCompraColumn
            // 
            this.TipoCompraColumn.HeaderText = "Purchase type";
            this.TipoCompraColumn.Name = "TipoCompraColumn";
            this.TipoCompraColumn.ReadOnly = true;
            // 
            // numeroComprobanteFiscalColumn
            // 
            this.numeroComprobanteFiscalColumn.FillWeight = 120F;
            this.numeroComprobanteFiscalColumn.HeaderText = "NCF";
            this.numeroComprobanteFiscalColumn.Name = "numeroComprobanteFiscalColumn";
            this.numeroComprobanteFiscalColumn.ReadOnly = true;
            // 
            // FechaLimiteColumn
            // 
            this.FechaLimiteColumn.FillWeight = 70F;
            this.FechaLimiteColumn.HeaderText = "Deadline";
            this.FechaLimiteColumn.Name = "FechaLimiteColumn";
            this.FechaLimiteColumn.ReadOnly = true;
            // 
            // MontoPendienteColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.MontoPendienteColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.MontoPendienteColumn.HeaderText = "Pending";
            this.MontoPendienteColumn.Name = "MontoPendienteColumn";
            this.MontoPendienteColumn.ReadOnly = true;
            // 
            // MontoAbonoColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.MontoAbonoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.MontoAbonoColumn.HeaderText = "Pay";
            this.MontoAbonoColumn.Name = "MontoAbonoColumn";
            this.MontoAbonoColumn.ReadOnly = true;
            // 
            // metoopagoColumn
            // 
            this.metoopagoColumn.FillWeight = 80F;
            this.metoopagoColumn.HeaderText = "Charge method";
            this.metoopagoColumn.Name = "metoopagoColumn";
            this.metoopagoColumn.ReadOnly = true;
            // 
            // ventana_venta_cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 741);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalCobradoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPendienteText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.montoAbonoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metodoPagoComboBox);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_venta_cobros";
            this.Text = "ventana_venta_cobros";
            this.Load += new System.EventHandler(this.ventana_venta_cobros_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button20, 0);
            this.Controls.SetChildIndex(this.metodoPagoComboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.montoAbonoText, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.totalPendienteText, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.totalCobradoText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button19, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private TextBox totalCobradoText;
        private Label label4;
        private TextBox totalPendienteText;
        private Label label14;
        private TextBox montoAbonoText;
        private Label label3;
        private Label label1;
        private ComboBox metodoPagoComboBox;
        private Button button20;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox clienteText;
        private Button button5;
        private TextBox clienteIdText;
        private Button button19;
        private DataGridViewTextBoxColumn idPrductoColumn;
        private DataGridViewTextBoxColumn fechaColumn;
        private DataGridViewTextBoxColumn diasVencimientoColumn;
        private DataGridViewTextBoxColumn empleadoColumn;
        private DataGridViewTextBoxColumn TipoCompraColumn;
        private DataGridViewTextBoxColumn numeroComprobanteFiscalColumn;
        private DataGridViewTextBoxColumn FechaLimiteColumn;
        private DataGridViewTextBoxColumn MontoPendienteColumn;
        private DataGridViewTextBoxColumn MontoAbonoColumn;
        private DataGridViewTextBoxColumn metoopagoColumn;
    }
}