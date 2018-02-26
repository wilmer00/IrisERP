using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.modelos;
using Microsoft.Reporting.WinForms;

namespace IrisContabilidad.ventanas_comunes
{


    public partial class VisorReporteComun : Form
    {
        //objetos
        private singleton singleton = new singleton();
        private empleado empleado;
        sistemaConfiguracion sistemaConfiguracion;

        //modelos
        modeloEmpleado modeloEmpleado=new modeloEmpleado();
        modeloLogReporteGenerado modeloLogReporte=new modeloLogReporteGenerado();
        modeloSistemaConfiguracion modeloSistemaConfiguracion = new modeloSistemaConfiguracion();

        //variables
        bool imprimirDirectamente = false;

        
        public VisorReporteComun(String reporte, List<ReportDataSource> lista, List<ReportParameter> ListaReportParameter,bool agregarLog=false,bool imprimirDirecto=false)
        {
            InitializeComponent();
            this.empleado = singleton.getEmpleado();
            this.sistemaConfiguracion = modeloSistemaConfiguracion.getSistemaConfiguracion();
            GetLoad(reporte, lista, ListaReportParameter);
            if (agregarLog == true)
            {
                agregarLogReporte();
            } 
            //para imprimir en la impresora que este por defecto
            if(imprimirDirecto==true)
            {
                this.imprimirDirectamente = true;
            }
        }

        public void agregarLogReporte()
        {
            try
            {
                log_reportes_generados log=new log_reportes_generados();
                log.codigo = modeloLogReporte.getNext();
                log.codigoEmpleado = empleado.codigo;
                log.fecha = DateTime.Today;
                log.fechaHora = DateTime.Now;
                log.reporteGenerado = Reporte.LocalReport.ReportEmbeddedResource.ToString();
                modeloLogReporte.agregarLogReporteGenerado(log);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding the report log/Error agregando el log de reporte.: "+ex.ToString());
            }
        }

        private void GetLoad(String reporte, List<ReportDataSource> lista, List<ReportParameter> ListaReportParameter)
        {
            Reporte.LocalReport.ReportEmbeddedResource = reporte;
            lista.ForEach(x =>
            {
                 Reporte.LocalReport.DataSources.Add(x);
            });
            if(ListaReportParameter!=null)
            {
                Reporte.LocalReport.SetParameters(ListaReportParameter);
            }
        }

        private void visor_reporte_Load(object sender, EventArgs e)
        {
            Reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //saber el nombre del printer por defecto
            #region
            if (this.imprimirDirectamente == true)
            {
                if (sistemaConfiguracion.nombreImpresoraRolloDefecto == Reporte.PrinterSettings.DefaultPageSettings.PrinterSettings.PrinterName)
                {
                    //MessageBox.Show("el printer por defecto es igual al almacenado en el sistema");
                }
                else
                {
                    MessageBox.Show("The printer stored in the system is not the default one/El printer guardado en el sistema, no es el que esta por defecto");
                }
            }
            //
            #endregion

            this.Reporte.RefreshReport();
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
