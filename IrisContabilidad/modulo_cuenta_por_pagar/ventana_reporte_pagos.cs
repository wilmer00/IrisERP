using System;
using System.ComponentModel;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.modelos;
using IrisContabilidad.modulo_inventario;
using IrisContabilidad.modulo_sistema;

namespace IrisContabilidad.modulo_cuenta_por_pagar
{
    public partial class ventana_reporte_pagos : formBase
    {

        //objetos
        empleado empleadoSingleton;
        utilidades utilidades = new utilidades();
        singleton singleton = new singleton();
        empleado empleado;
        suplidor suplidor;
        private compra compra;

        //variables
        private DateTime fechaInicial;
        private DateTime fechaFinal;
        bool incluirRangoFechas = false;
        private bool incluirSoloCompraPagadas = false;
        private string tipoCompra = "";

        //modelos
        modeloSuplidor modeloSuplidor = new modeloSuplidor();
        modeloCompra modeloCompra=new modeloCompra();
        ModeloReporte modeloReporte=new ModeloReporte();

        //listas


        //Proceso
        private ventana_procesando procesando;
        private BackgroundWorker SincronizarProceso = new BackgroundWorker();

        public ventana_reporte_pagos()
        {
            InitializeComponent();
            empleadoSingleton = singleton.getEmpleado();
            this.tituloLabel.Text = utilidades.GetTituloVentana(empleadoSingleton, "payment purchase report/reporte de compra pagos");
            this.Text = tituloLabel.Text;
            loadVentana();

            SincronizarProceso.WorkerReportsProgress = true;
            SincronizarProceso.DoWork += LoadReporte;
            SincronizarProceso.ProgressChanged += ProcesoRun;
            SincronizarProceso.RunWorkerCompleted += ProcesoCompleto;
        }
        public void loadVentana()
        {
            try
            {
                //blanquear campos
                suplidor = null;
                loadSuplidor();
                compra = null;
                loadCompra();

                checkBoxSoloComprasPagadas.Checked = false;
                checkBoxIncluirRangoFechaVenta.Checked = false;
                fechaInicialText.Enabled = false;
                fechaFinalText.Enabled = false;
                fechaInicialText.Value = DateTime.Today;
                fechaFinalText.Value = DateTime.Today;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadVentana.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReporte(object sender, DoWorkEventArgs e)
        {
            SincronizarProceso.ReportProgress(10);
            try
            {
                modeloReporte.imprimirCompraPagosAgrupadoByCompra(compra, suplidor, tipoCompra, fechaInicial, fechaFinal, incluirRangoFechas, incluirSoloCompraPagadas);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadReporte.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesoRun(object sender, ProgressChangedEventArgs e)
        {
            if (procesando == null)
            {
                procesando = new ventana_procesando();
                procesando.ShowDialog();
            }
        }

        private void ProcesoCompleto(object sender, RunWorkerCompletedEventArgs e)
        {
            procesando.Close();
            procesando = null;
        }

        public void salir()
        {
            if (MessageBox.Show("Do you want to go out?/Desea salir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public bool validarGetAction()
        {
            try
            {
                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validarGetAction.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ventana_reporte_pagos_Load(object sender, EventArgs e)
        {

        }       

        private void button1_Click(object sender, EventArgs e)
        {
            SincronizarProceso.RunWorkerAsync();
        }
        
        public bool validarImpresion()
        {
            try
            {
                //validr que tenga suplidor
                if(suplidor==null)
                {
                    MessageBox.Show("You must select a supplier/Debe seleccionar un suplidor", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (tipoCompraComboBox.Text != "")
                {
                    tipoCompra = tipoCompraComboBox.Text;
                }
                if (checkBoxIncluirRangoFechaVenta.Checked == true)
                {
                    incluirRangoFechas = true;
                }
                else
                {
                    incluirRangoFechas = false;
                }
                if (checkBoxSoloComprasPagadas.Checked == true)
                {
                    incluirSoloCompraPagadas = true;
                }
                else
                {
                    incluirSoloCompraPagadas = false;
                }
                DateTime f1;
                DateTime f2;
                //if (DateTime.TryParse(fechaInicialText.Value, out f1) == false)
                //{
                //    MessageBox.Show("Error formato fecha incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    fechaInicialText.Focus();
                //    return false;
                //}
                //if (DateTime.TryParse(fechaFinalText.Value, out f1) == false)
                //{
                //    MessageBox.Show("Error formato fecha incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    fechaFinalText.Focus();
                //    return false;
                //}
                fechaInicial = Convert.ToDateTime(fechaInicialText.Value);
                fechaFinal = Convert.ToDateTime(fechaFinalText.Value);

                fechaInicial =Convert.ToDateTime(utilidades.getFechaEstadosUnidos(fechaInicial));
                fechaFinal = Convert.ToDateTime(utilidades.getFechaEstadosUnidos(fechaFinal));
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validarImpresion.: " + ex.ToString(), "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (validarImpresion() == false)
            {
                return;
            }
            SincronizarProceso.RunWorkerAsync();            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            tipoCompraComboBox.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadVentana();
        }

        public void loadSuplidor()
        {
            try
            {
                suplidorIdText.Text = "";
                suplidorLabel.Text = "";

                if (suplidor != null)
                {
                    suplidorIdText.Text = suplidor.codigo.ToString();
                    suplidorLabel.Text = suplidor.nombre+"-"+suplidor.rnc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadSuplidor.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadCompra()
        {
            try
            {
                compraIdText.Text = "";
                compraLabel.Text = "";

                if (compra != null)
                {
                    compraIdText.Text = compra.codigo.ToString();
                    compraLabel.Text = compra.numero_factura + "---" + suplidor.rnc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadCompra.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventana_busqueda_suplidor ventana=new ventana_busqueda_suplidor();
            ventana.Owner = this;
            ventana.ShowDialog();

            if (ventana.DialogResult == DialogResult.OK)
            {
                suplidor = ventana.getObjeto();
                loadSuplidor();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventana_busqueda_compra ventana=new ventana_busqueda_compra();
            ventana.Owner = this;
            ventana.ShowDialog();

            if (ventana.DialogResult == DialogResult.OK)
            {
                compra = ventana.getObjeto();
                loadCompra();
            }
        }

        private void checkBoxIncluirRangoFechaVenta_Click(object sender, EventArgs e)
        {
            fechaInicialText.Enabled = (bool) checkBoxIncluirRangoFechaVenta.Checked;
            fechaFinalText.Enabled = (bool)checkBoxIncluirRangoFechaVenta.Checked;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            suplidor = null;
            loadSuplidor();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            compra = null;
            loadCompra();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
