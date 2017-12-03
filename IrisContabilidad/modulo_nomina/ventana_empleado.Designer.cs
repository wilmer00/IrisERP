using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_nomina
{
    partial class ventana_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_empleado));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.claveText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cargoIdText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.departamentoIdText = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sucursalIdText = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nominaTipoIdText = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.sueldoText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.identificacionText = new System.Windows.Forms.TextBox();
            this.sucursalText = new System.Windows.Forms.TextBox();
            this.departamentoText = new System.Windows.Forms.TextBox();
            this.cargoText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.grupoUsuarioIdText = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.grupoUsuarioText = new System.Windows.Forms.TextBox();
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.nominaTipoText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.situacionIdText = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.situacionText = new System.Windows.Forms.TextBox();
            this.imagen_empleado = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.empresaIdText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rutaImagenText = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pasaporteText = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 703);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1236, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1048, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1268, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(517, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.pasaporteText);
            this.tabPage1.Controls.Add(this.rutaImagenText);
            this.tabPage1.Controls.Add(this.situacionText);
            this.tabPage1.Controls.Add(this.situacionIdText);
            this.tabPage1.Controls.Add(this.nominaTipoText);
            this.tabPage1.Controls.Add(this.grupoUsuarioText);
            this.tabPage1.Controls.Add(this.grupoUsuarioIdText);
            this.tabPage1.Controls.Add(this.cargoText);
            this.tabPage1.Controls.Add(this.departamentoText);
            this.tabPage1.Controls.Add(this.sucursalText);
            this.tabPage1.Controls.Add(this.identificacionText);
            this.tabPage1.Controls.Add(this.sueldoText);
            this.tabPage1.Controls.Add(this.nominaTipoIdText);
            this.tabPage1.Controls.Add(this.sucursalIdText);
            this.tabPage1.Controls.Add(this.departamentoIdText);
            this.tabPage1.Controls.Add(this.cargoIdText);
            this.tabPage1.Controls.Add(this.claveText);
            this.tabPage1.Controls.Add(this.nombreText);
            this.tabPage1.Controls.Add(this.usuarioText);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.imagen_empleado);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.activoCheck);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.fechaIngreso);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1228, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // usuarioText
            // 
            this.usuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioText.Location = new System.Drawing.Point(149, 231);
            this.usuarioText.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioText.MaxLength = 30;
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(336, 30);
            this.usuarioText.TabIndex = 12;
            // 
            // nombreText
            // 
            this.nombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreText.Location = new System.Drawing.Point(149, 97);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4);
            this.nombreText.MaxLength = 30;
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(336, 30);
            this.nombreText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Clave";
            // 
            // claveText
            // 
            this.claveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveText.Location = new System.Drawing.Point(149, 281);
            this.claveText.Margin = new System.Windows.Forms.Padding(4);
            this.claveText.MaxLength = 30;
            this.claveText.Name = "claveText";
            this.claveText.PasswordChar = '*';
            this.claveText.Size = new System.Drawing.Size(336, 30);
            this.claveText.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dpto.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sueldo";
            // 
            // cargoIdText
            // 
            this.cargoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.cargoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoIdText.Location = new System.Drawing.Point(149, 514);
            this.cargoIdText.Margin = new System.Windows.Forms.Padding(4);
            this.cargoIdText.Name = "cargoIdText";
            this.cargoIdText.Size = new System.Drawing.Size(187, 30);
            this.cargoIdText.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(345, 506);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 34;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // departamentoIdText
            // 
            this.departamentoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.departamentoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoIdText.Location = new System.Drawing.Point(149, 425);
            this.departamentoIdText.Margin = new System.Windows.Forms.Padding(4);
            this.departamentoIdText.Name = "departamentoIdText";
            this.departamentoIdText.Size = new System.Drawing.Size(187, 30);
            this.departamentoIdText.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(345, 416);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 46);
            this.button6.TabIndex = 36;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sucursal";
            // 
            // sucursalIdText
            // 
            this.sucursalIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.sucursalIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursalIdText.Location = new System.Drawing.Point(149, 335);
            this.sucursalIdText.Margin = new System.Windows.Forms.Padding(4);
            this.sucursalIdText.Name = "sucursalIdText";
            this.sucursalIdText.Size = new System.Drawing.Size(187, 30);
            this.sucursalIdText.TabIndex = 38;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(345, 326);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 46);
            this.button7.TabIndex = 39;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(529, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tipo nomina";
            // 
            // nominaTipoIdText
            // 
            this.nominaTipoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.nominaTipoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominaTipoIdText.Location = new System.Drawing.Point(679, 245);
            this.nominaTipoIdText.Margin = new System.Windows.Forms.Padding(4);
            this.nominaTipoIdText.Name = "nominaTipoIdText";
            this.nominaTipoIdText.Size = new System.Drawing.Size(187, 30);
            this.nominaTipoIdText.TabIndex = 41;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(868, 236);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 46);
            this.button8.TabIndex = 42;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sueldoText
            // 
            this.sueldoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoText.Location = new System.Drawing.Point(679, 335);
            this.sueldoText.Margin = new System.Windows.Forms.Padding(4);
            this.sueldoText.MaxLength = 30;
            this.sueldoText.Name = "sueldoText";
            this.sueldoText.Size = new System.Drawing.Size(257, 30);
            this.sueldoText.TabIndex = 43;
            this.sueldoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Identif.";
            // 
            // identificacionText
            // 
            this.identificacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificacionText.Location = new System.Drawing.Point(149, 142);
            this.identificacionText.Margin = new System.Windows.Forms.Padding(4);
            this.identificacionText.MaxLength = 30;
            this.identificacionText.Name = "identificacionText";
            this.identificacionText.Size = new System.Drawing.Size(336, 30);
            this.identificacionText.TabIndex = 45;
            // 
            // sucursalText
            // 
            this.sucursalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursalText.Location = new System.Drawing.Point(149, 374);
            this.sucursalText.Margin = new System.Windows.Forms.Padding(4);
            this.sucursalText.MaxLength = 30;
            this.sucursalText.Name = "sucursalText";
            this.sucursalText.ReadOnly = true;
            this.sucursalText.Size = new System.Drawing.Size(336, 30);
            this.sucursalText.TabIndex = 46;
            // 
            // departamentoText
            // 
            this.departamentoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoText.Location = new System.Drawing.Point(149, 464);
            this.departamentoText.Margin = new System.Windows.Forms.Padding(4);
            this.departamentoText.MaxLength = 30;
            this.departamentoText.Name = "departamentoText";
            this.departamentoText.ReadOnly = true;
            this.departamentoText.Size = new System.Drawing.Size(336, 30);
            this.departamentoText.TabIndex = 47;
            // 
            // cargoText
            // 
            this.cargoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoText.Location = new System.Drawing.Point(149, 554);
            this.cargoText.Margin = new System.Windows.Forms.Padding(4);
            this.cargoText.MaxLength = 30;
            this.cargoText.Name = "cargoText";
            this.cargoText.ReadOnly = true;
            this.cargoText.Size = new System.Drawing.Size(336, 30);
            this.cargoText.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(507, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Fecha ingreso";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Location = new System.Drawing.Point(679, 100);
            this.fechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.fechaIngreso.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(513, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 51;
            this.label12.Text = "Grup. usuario";
            // 
            // grupoUsuarioIdText
            // 
            this.grupoUsuarioIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.grupoUsuarioIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoUsuarioIdText.Location = new System.Drawing.Point(679, 142);
            this.grupoUsuarioIdText.Margin = new System.Windows.Forms.Padding(4);
            this.grupoUsuarioIdText.Name = "grupoUsuarioIdText";
            this.grupoUsuarioIdText.Size = new System.Drawing.Size(187, 30);
            this.grupoUsuarioIdText.TabIndex = 52;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(868, 133);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 46);
            this.button9.TabIndex = 53;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // grupoUsuarioText
            // 
            this.grupoUsuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoUsuarioText.Location = new System.Drawing.Point(679, 181);
            this.grupoUsuarioText.Margin = new System.Windows.Forms.Padding(4);
            this.grupoUsuarioText.MaxLength = 30;
            this.grupoUsuarioText.Name = "grupoUsuarioText";
            this.grupoUsuarioText.ReadOnly = true;
            this.grupoUsuarioText.Size = new System.Drawing.Size(257, 30);
            this.grupoUsuarioText.TabIndex = 54;
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(672, 560);
            this.activoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(79, 24);
            this.activoCheck.TabIndex = 55;
            this.activoCheck.Text = "Activo";
            this.activoCheck.UseVisualStyleBackColor = true;
            // 
            // nominaTipoText
            // 
            this.nominaTipoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominaTipoText.Location = new System.Drawing.Point(679, 284);
            this.nominaTipoText.Margin = new System.Windows.Forms.Padding(4);
            this.nominaTipoText.MaxLength = 30;
            this.nominaTipoText.Name = "nominaTipoText";
            this.nominaTipoText.ReadOnly = true;
            this.nominaTipoText.Size = new System.Drawing.Size(257, 30);
            this.nominaTipoText.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(559, 385);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 57;
            this.label13.Text = "Situación";
            // 
            // situacionIdText
            // 
            this.situacionIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.situacionIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacionIdText.Location = new System.Drawing.Point(679, 382);
            this.situacionIdText.Margin = new System.Windows.Forms.Padding(4);
            this.situacionIdText.Name = "situacionIdText";
            this.situacionIdText.Size = new System.Drawing.Size(187, 30);
            this.situacionIdText.TabIndex = 58;
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(868, 373);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 46);
            this.button10.TabIndex = 59;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // situacionText
            // 
            this.situacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacionText.Location = new System.Drawing.Point(679, 421);
            this.situacionText.Margin = new System.Windows.Forms.Padding(4);
            this.situacionText.MaxLength = 30;
            this.situacionText.Name = "situacionText";
            this.situacionText.ReadOnly = true;
            this.situacionText.Size = new System.Drawing.Size(257, 30);
            this.situacionText.TabIndex = 60;
            // 
            // imagen_empleado
            // 
            this.imagen_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_empleado.Location = new System.Drawing.Point(967, 100);
            this.imagen_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.imagen_empleado.Name = "imagen_empleado";
            this.imagen_empleado.Size = new System.Drawing.Size(247, 210);
            this.imagen_empleado.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empresaIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1205, 81);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(337, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Empleado";
            // 
            // empresaIdText
            // 
            this.empresaIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.empresaIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaIdText.Location = new System.Drawing.Point(141, 28);
            this.empresaIdText.Margin = new System.Windows.Forms.Padding(4);
            this.empresaIdText.Name = "empresaIdText";
            this.empresaIdText.Size = new System.Drawing.Size(187, 30);
            this.empresaIdText.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(616, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 25);
            this.label14.TabIndex = 63;
            this.label14.Text = "foto";
            // 
            // rutaImagenText
            // 
            this.rutaImagenText.BackColor = System.Drawing.Color.SkyBlue;
            this.rutaImagenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaImagenText.Location = new System.Drawing.Point(679, 468);
            this.rutaImagenText.Margin = new System.Windows.Forms.Padding(4);
            this.rutaImagenText.Name = "rutaImagenText";
            this.rutaImagenText.Size = new System.Drawing.Size(187, 30);
            this.rutaImagenText.TabIndex = 64;
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(868, 459);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 46);
            this.button11.TabIndex = 65;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 188);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 25);
            this.label16.TabIndex = 66;
            this.label16.Text = "Pasaporte";
            // 
            // pasaporteText
            // 
            this.pasaporteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasaporteText.Location = new System.Drawing.Point(149, 185);
            this.pasaporteText.Margin = new System.Windows.Forms.Padding(4);
            this.pasaporteText.MaxLength = 30;
            this.pasaporteText.Name = "pasaporteText";
            this.pasaporteText.Size = new System.Drawing.Size(336, 30);
            this.pasaporteText.TabIndex = 67;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Tomato;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(967, 318);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(247, 46);
            this.button15.TabIndex = 68;
            this.button15.Text = "Eliminar Foto";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 662);
            this.tabControl1.TabIndex = 9;
            // 
            // ventana_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 784);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_empleado";
            this.Text = "ventana_empleado";
            this.Load += new System.EventHandler(this.ventana_empleado_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage tabPage1;
        private Button button15;
        public TextBox pasaporteText;
        private TextBox rutaImagenText;
        public TextBox situacionText;
        private TextBox situacionIdText;
        public TextBox nominaTipoText;
        public TextBox grupoUsuarioText;
        private TextBox grupoUsuarioIdText;
        public TextBox cargoText;
        public TextBox departamentoText;
        public TextBox sucursalText;
        public TextBox identificacionText;
        public TextBox sueldoText;
        private TextBox nominaTipoIdText;
        private TextBox sucursalIdText;
        private TextBox departamentoIdText;
        private TextBox cargoIdText;
        public TextBox claveText;
        public TextBox nombreText;
        public TextBox usuarioText;
        private Label label16;
        private Button button11;
        private Label label14;
        private GroupBox groupBox1;
        private TextBox empresaIdText;
        private Label label2;
        private Button button4;
        private Panel imagen_empleado;
        private Button button10;
        private Label label13;
        private CheckBox activoCheck;
        private Button button9;
        private Label label12;
        private DateTimePicker fechaIngreso;
        private Label label11;
        private Label label10;
        private Button button8;
        private Label label9;
        private Button button7;
        private Label label8;
        private Button button6;
        private Button button5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label1;
        private Label label3;
        private TabControl tabControl1;
    }
}