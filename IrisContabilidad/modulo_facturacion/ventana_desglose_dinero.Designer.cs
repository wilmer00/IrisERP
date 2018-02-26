﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_desglose_dinero
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.montoEfectivoText = new System.Windows.Forms.TextBox();
            this.montoTarjetaText = new System.Windows.Forms.TextBox();
            this.montoChequeText = new System.Windows.Forms.TextBox();
            this.montoDepositoText = new System.Windows.Forms.TextBox();
            this.montoDevueltoText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montoDescuentoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MontoTotalText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numeroChequeText = new System.Windows.Forms.TextBox();
            this.chequeBancoText = new System.Windows.Forms.TextBox();
            this.depositoBancoText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MontoItebisText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 652);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1346, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1158, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1378, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(580, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Credit/ Debit card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Check ($$)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Deposit ($$)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Amount to return";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // montoEfectivoText
            // 
            this.montoEfectivoText.BackColor = System.Drawing.Color.SkyBlue;
            this.montoEfectivoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoEfectivoText.Location = new System.Drawing.Point(255, 52);
            this.montoEfectivoText.Margin = new System.Windows.Forms.Padding(4);
            this.montoEfectivoText.Name = "montoEfectivoText";
            this.montoEfectivoText.Size = new System.Drawing.Size(415, 45);
            this.montoEfectivoText.TabIndex = 79;
            this.montoEfectivoText.Text = "0.00";
            this.montoEfectivoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoEfectivoText.TextChanged += new System.EventHandler(this.montoEfectivoText_TextChanged);
            this.montoEfectivoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoEfectivoText_KeyDown);
            this.montoEfectivoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.efectivoText_KeyPress);
            // 
            // montoTarjetaText
            // 
            this.montoTarjetaText.BackColor = System.Drawing.Color.SkyBlue;
            this.montoTarjetaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTarjetaText.Location = new System.Drawing.Point(927, 52);
            this.montoTarjetaText.Margin = new System.Windows.Forms.Padding(4);
            this.montoTarjetaText.Name = "montoTarjetaText";
            this.montoTarjetaText.Size = new System.Drawing.Size(415, 45);
            this.montoTarjetaText.TabIndex = 80;
            this.montoTarjetaText.Text = "0.00";
            this.montoTarjetaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoTarjetaText.TextChanged += new System.EventHandler(this.montoTarjetaText_TextChanged);
            this.montoTarjetaText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoTarjetaText_KeyDown);
            this.montoTarjetaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tarjetaText_KeyPress);
            // 
            // montoChequeText
            // 
            this.montoChequeText.BackColor = System.Drawing.Color.SkyBlue;
            this.montoChequeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoChequeText.Location = new System.Drawing.Point(241, 23);
            this.montoChequeText.Margin = new System.Windows.Forms.Padding(4);
            this.montoChequeText.Name = "montoChequeText";
            this.montoChequeText.Size = new System.Drawing.Size(415, 45);
            this.montoChequeText.TabIndex = 81;
            this.montoChequeText.Text = "0.00";
            this.montoChequeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoChequeText.TextChanged += new System.EventHandler(this.montoChequeText_TextChanged);
            this.montoChequeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoChequeText_KeyDown);
            this.montoChequeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chequeText_KeyPress);
            // 
            // montoDepositoText
            // 
            this.montoDepositoText.BackColor = System.Drawing.Color.SkyBlue;
            this.montoDepositoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoDepositoText.Location = new System.Drawing.Point(191, 23);
            this.montoDepositoText.Margin = new System.Windows.Forms.Padding(4);
            this.montoDepositoText.Name = "montoDepositoText";
            this.montoDepositoText.Size = new System.Drawing.Size(415, 45);
            this.montoDepositoText.TabIndex = 82;
            this.montoDepositoText.Text = "0.00";
            this.montoDepositoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoDepositoText.TextChanged += new System.EventHandler(this.montoDepositoText_TextChanged);
            this.montoDepositoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoDepositoText_KeyDown);
            this.montoDepositoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositoText_KeyPress);
            // 
            // montoDevueltoText
            // 
            this.montoDevueltoText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.montoDevueltoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoDevueltoText.Location = new System.Drawing.Point(912, 23);
            this.montoDevueltoText.Margin = new System.Windows.Forms.Padding(4);
            this.montoDevueltoText.Name = "montoDevueltoText";
            this.montoDevueltoText.ReadOnly = true;
            this.montoDevueltoText.Size = new System.Drawing.Size(408, 45);
            this.montoDevueltoText.TabIndex = 83;
            this.montoDevueltoText.Text = "0.00";
            this.montoDevueltoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoDevueltoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.devueltoText_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montoDescuentoText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1344, 92);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // montoDescuentoText
            // 
            this.montoDescuentoText.BackColor = System.Drawing.Color.Tomato;
            this.montoDescuentoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoDescuentoText.Location = new System.Drawing.Point(287, 23);
            this.montoDescuentoText.Margin = new System.Windows.Forms.Padding(4);
            this.montoDescuentoText.Name = "montoDescuentoText";
            this.montoDescuentoText.Size = new System.Drawing.Size(415, 45);
            this.montoDescuentoText.TabIndex = 86;
            this.montoDescuentoText.Text = "0.00";
            this.montoDescuentoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montoDescuentoText.TextChanged += new System.EventHandler(this.descuentoText_TextChanged);
            this.montoDescuentoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descuentoText_KeyDown);
            this.montoDescuentoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Discount amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MontoTotalText
            // 
            this.MontoTotalText.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MontoTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoTotalText.Location = new System.Drawing.Point(913, 157);
            this.MontoTotalText.Margin = new System.Windows.Forms.Padding(4);
            this.MontoTotalText.Name = "MontoTotalText";
            this.MontoTotalText.ReadOnly = true;
            this.MontoTotalText.Size = new System.Drawing.Size(408, 45);
            this.MontoTotalText.TabIndex = 86;
            this.MontoTotalText.Text = "0.00";
            this.MontoTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 85;
            this.label7.Text = "Grand Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numeroChequeText
            // 
            this.numeroChequeText.BackColor = System.Drawing.Color.SkyBlue;
            this.numeroChequeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroChequeText.Location = new System.Drawing.Point(241, 78);
            this.numeroChequeText.Margin = new System.Windows.Forms.Padding(4);
            this.numeroChequeText.Name = "numeroChequeText";
            this.numeroChequeText.Size = new System.Drawing.Size(415, 45);
            this.numeroChequeText.TabIndex = 87;
            this.numeroChequeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeroChequeText_KeyDown);
            this.numeroChequeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroChequeText_KeyPress);
            // 
            // chequeBancoText
            // 
            this.chequeBancoText.BackColor = System.Drawing.Color.SkyBlue;
            this.chequeBancoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeBancoText.Location = new System.Drawing.Point(241, 128);
            this.chequeBancoText.Margin = new System.Windows.Forms.Padding(4);
            this.chequeBancoText.MaxLength = 50;
            this.chequeBancoText.Name = "chequeBancoText";
            this.chequeBancoText.Size = new System.Drawing.Size(415, 45);
            this.chequeBancoText.TabIndex = 89;
            this.chequeBancoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chequeBancoText_KeyDown);
            // 
            // depositoBancoText
            // 
            this.depositoBancoText.BackColor = System.Drawing.Color.SkyBlue;
            this.depositoBancoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositoBancoText.Location = new System.Drawing.Point(191, 78);
            this.depositoBancoText.Margin = new System.Windows.Forms.Padding(4);
            this.depositoBancoText.MaxLength = 50;
            this.depositoBancoText.Name = "depositoBancoText";
            this.depositoBancoText.Size = new System.Drawing.Size(415, 45);
            this.depositoBancoText.TabIndex = 90;
            this.depositoBancoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depositoBancoText_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.montoChequeText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chequeBancoText);
            this.groupBox2.Controls.Add(this.numeroChequeText);
            this.groupBox2.Location = new System.Drawing.Point(20, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(691, 199);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "Bank name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 90;
            this.label8.Text = "Check number(#)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.montoDepositoText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.depositoBancoText);
            this.groupBox3.Location = new System.Drawing.Point(736, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(628, 199);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deposit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Bank name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.MontoItebisText);
            this.groupBox4.Controls.Add(this.MontoTotalText);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.montoDevueltoText);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(21, 427);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1343, 215);
            this.groupBox4.TabIndex = 93;
            this.groupBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 25);
            this.label11.TabIndex = 88;
            this.label11.Text = "Tax";
            // 
            // MontoItebisText
            // 
            this.MontoItebisText.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MontoItebisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoItebisText.Location = new System.Drawing.Point(70, 23);
            this.MontoItebisText.Margin = new System.Windows.Forms.Padding(4);
            this.MontoItebisText.Name = "MontoItebisText";
            this.MontoItebisText.ReadOnly = true;
            this.MontoItebisText.Size = new System.Drawing.Size(408, 45);
            this.MontoItebisText.TabIndex = 87;
            this.MontoItebisText.Text = "0.00";
            this.MontoItebisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ventana_desglose_dinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 734);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.montoTarjetaText);
            this.Controls.Add(this.montoEfectivoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ventana_desglose_dinero";
            this.Text = "ventana_desglose_dinero";
            this.Load += new System.EventHandler(this.ventana_desglose_dinero_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.montoEfectivoText, 0);
            this.Controls.SetChildIndex(this.montoTarjetaText, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox montoEfectivoText;
        private TextBox montoTarjetaText;
        private TextBox montoChequeText;
        private TextBox montoDepositoText;
        private TextBox montoDevueltoText;
        private GroupBox groupBox1;
        private TextBox montoDescuentoText;
        private Label label6;
        private TextBox MontoTotalText;
        private Label label7;
        private TextBox numeroChequeText;
        private TextBox chequeBancoText;
        private TextBox depositoBancoText;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label10;
        private GroupBox groupBox4;
        private Label label11;
        private TextBox MontoItebisText;
    }
}