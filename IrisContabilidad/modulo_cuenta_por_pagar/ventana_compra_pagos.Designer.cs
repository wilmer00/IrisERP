using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_cuenta_por_pagar
{
    partial class ventana_compra_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_compra_pagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.suplidorText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.suplidorIdText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPrductoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasVencimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroComprobanteFiscalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPendienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAbonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metoopagoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metodoPagoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montoAbonoText = new System.Windows.Forms.TextBox();
            this.totalPendienteText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalAbonadoText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.montoDescuentoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDescontadoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 731);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1452, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1264, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1484, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(632, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.suplidorText);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.suplidorIdText);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1448, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Supplier";
            // 
            // suplidorText
            // 
            this.suplidorText.BackColor = System.Drawing.Color.White;
            this.suplidorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidorText.Location = new System.Drawing.Point(128, 66);
            this.suplidorText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suplidorText.MaxLength = 200;
            this.suplidorText.Name = "suplidorText";
            this.suplidorText.ReadOnly = true;
            this.suplidorText.Size = new System.Drawing.Size(313, 30);
            this.suplidorText.TabIndex = 77;
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // suplidorIdText
            // 
            this.suplidorIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.suplidorIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidorIdText.Location = new System.Drawing.Point(128, 21);
            this.suplidorIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suplidorIdText.Name = "suplidorIdText";
            this.suplidorIdText.Size = new System.Drawing.Size(243, 30);
            this.suplidorIdText.TabIndex = 71;
            this.suplidorIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.suplidorIdText_KeyDown);
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
            this.Column1,
            this.metoopagoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1449, 416);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.fechaColumn.HeaderText = "Fecha";
            this.fechaColumn.Name = "fechaColumn";
            this.fechaColumn.ReadOnly = true;
            // 
            // diasVencimientoColumn
            // 
            this.diasVencimientoColumn.FillWeight = 70F;
            this.diasVencimientoColumn.HeaderText = "Dias ven.";
            this.diasVencimientoColumn.Name = "diasVencimientoColumn";
            this.diasVencimientoColumn.ReadOnly = true;
            // 
            // empleadoColumn
            // 
            this.empleadoColumn.FillWeight = 120F;
            this.empleadoColumn.HeaderText = "Empleado";
            this.empleadoColumn.Name = "empleadoColumn";
            this.empleadoColumn.ReadOnly = true;
            // 
            // TipoCompraColumn
            // 
            this.TipoCompraColumn.FillWeight = 80F;
            this.TipoCompraColumn.HeaderText = "Tipo compra";
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
            this.FechaLimiteColumn.HeaderText = "Fecha limite";
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
            this.MontoPendienteColumn.FillWeight = 80F;
            this.MontoPendienteColumn.HeaderText = "Pendiente";
            this.MontoPendienteColumn.Name = "MontoPendienteColumn";
            this.MontoPendienteColumn.ReadOnly = true;
            // 
            // MontoAbonoColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.MontoAbonoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.MontoAbonoColumn.FillWeight = 80F;
            this.MontoAbonoColumn.HeaderText = "Abonar";
            this.MontoAbonoColumn.Name = "MontoAbonoColumn";
            this.MontoAbonoColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "Descuento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // metoopagoColumn
            // 
            this.metoopagoColumn.FillWeight = 80F;
            this.metoopagoColumn.HeaderText = "Metodo pago";
            this.metoopagoColumn.Name = "metoopagoColumn";
            this.metoopagoColumn.ReadOnly = true;
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(1379, 160);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(85, 71);
            this.button19.TabIndex = 103;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(1284, 160);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(87, 71);
            this.button20.TabIndex = 102;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button20_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "Payment method";
            // 
            // metodoPagoComboBox
            // 
            this.metodoPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoPagoComboBox.FormattingEnabled = true;
            this.metodoPagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Deposito",
            "Cheque"});
            this.metodoPagoComboBox.Location = new System.Drawing.Point(197, 199);
            this.metodoPagoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metodoPagoComboBox.Name = "metodoPagoComboBox";
            this.metodoPagoComboBox.Size = new System.Drawing.Size(251, 24);
            this.metodoPagoComboBox.TabIndex = 104;
            this.metodoPagoComboBox.Tag = "";
            this.metodoPagoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metodoPagoComboBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "Payment amount";
            // 
            // montoAbonoText
            // 
            this.montoAbonoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoAbonoText.Location = new System.Drawing.Point(663, 195);
            this.montoAbonoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoAbonoText.Name = "montoAbonoText";
            this.montoAbonoText.Size = new System.Drawing.Size(204, 30);
            this.montoAbonoText.TabIndex = 107;
            this.montoAbonoText.Text = "0.00";
            this.montoAbonoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoAbonoText_KeyDown);
            this.montoAbonoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoAbonoText_KeyPress);
            // 
            // totalPendienteText
            // 
            this.totalPendienteText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalPendienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPendienteText.Location = new System.Drawing.Point(327, 662);
            this.totalPendienteText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalPendienteText.MaxLength = 200;
            this.totalPendienteText.Name = "totalPendienteText";
            this.totalPendienteText.ReadOnly = true;
            this.totalPendienteText.Size = new System.Drawing.Size(256, 45);
            this.totalPendienteText.TabIndex = 109;
            this.totalPendienteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(139, 671);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 25);
            this.label14.TabIndex = 108;
            this.label14.Text = "Total pendiente";
            // 
            // totalAbonadoText
            // 
            this.totalAbonadoText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalAbonadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbonadoText.Location = new System.Drawing.Point(1207, 662);
            this.totalAbonadoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalAbonadoText.MaxLength = 200;
            this.totalAbonadoText.Name = "totalAbonadoText";
            this.totalAbonadoText.ReadOnly = true;
            this.totalAbonadoText.Size = new System.Drawing.Size(256, 45);
            this.totalAbonadoText.TabIndex = 111;
            this.totalAbonadoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1033, 671);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Total abonado";
            // 
            // montoDescuentoText
            // 
            this.montoDescuentoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoDescuentoText.Location = new System.Drawing.Point(1013, 197);
            this.montoDescuentoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montoDescuentoText.Name = "montoDescuentoText";
            this.montoDescuentoText.Size = new System.Drawing.Size(204, 30);
            this.montoDescuentoText.TabIndex = 115;
            this.montoDescuentoText.Text = "0.00";
            this.montoDescuentoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoDescuentoText_KeyDown);
            this.montoDescuentoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoDescuentoText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 114;
            this.label5.Text = "Discount";
            // 
            // totalDescontadoText
            // 
            this.totalDescontadoText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalDescontadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDescontadoText.Location = new System.Drawing.Point(784, 662);
            this.totalDescontadoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalDescontadoText.MaxLength = 200;
            this.totalDescontadoText.Name = "totalDescontadoText";
            this.totalDescontadoText.ReadOnly = true;
            this.totalDescontadoText.Size = new System.Drawing.Size(240, 45);
            this.totalDescontadoText.TabIndex = 117;
            this.totalDescontadoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 671);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 116;
            this.label6.Text = "Total descuento";
            // 
            // ventana_compra_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 812);
            this.Controls.Add(this.totalDescontadoText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.montoDescuentoText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalAbonadoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPendienteText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.montoAbonoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metodoPagoComboBox);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_compra_pagos";
            this.Text = "ventana_compra_pagos";
            this.Load += new System.EventHandler(this.ventana_compra_pagos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ventana_compra_pagos_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button20, 0);
            this.Controls.SetChildIndex(this.button19, 0);
            this.Controls.SetChildIndex(this.metodoPagoComboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.montoAbonoText, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.totalPendienteText, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.totalAbonadoText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.montoDescuentoText, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.totalDescontadoText, 0);
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
        private TextBox suplidorText;
        private Button button5;
        private TextBox suplidorIdText;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button19;
        private Button button20;
        private Label label1;
        private ComboBox metodoPagoComboBox;
        private Label label3;
        private TextBox montoAbonoText;
        private TextBox totalPendienteText;
        private Label label14;
        private TextBox totalAbonadoText;
        private Label label4;
        private TextBox montoDescuentoText;
        private Label label5;
        private DataGridViewTextBoxColumn idPrductoColumn;
        private DataGridViewTextBoxColumn fechaColumn;
        private DataGridViewTextBoxColumn diasVencimientoColumn;
        private DataGridViewTextBoxColumn empleadoColumn;
        private DataGridViewTextBoxColumn TipoCompraColumn;
        private DataGridViewTextBoxColumn numeroComprobanteFiscalColumn;
        private DataGridViewTextBoxColumn FechaLimiteColumn;
        private DataGridViewTextBoxColumn MontoPendienteColumn;
        private DataGridViewTextBoxColumn MontoAbonoColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn metoopagoColumn;
        private TextBox totalDescontadoText;
        private Label label6;
    }
}