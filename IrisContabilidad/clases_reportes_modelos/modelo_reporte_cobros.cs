using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.clases_reportes;
using IrisContabilidad.modelos;

namespace IrisContabilidad.clases_reportes_modelos
{
    public class modelo_reporte_cobros
    {
        public reporte_cobros_encabezado getReporteCobrosEncabezado(empleado empleado,cliente cliente,venta venta,string tipoVenta,Boolean incluirRangoFechaVenta,DateTime fechaInicialVenta,DateTime fechaFinalVenta,bool soloVentasPagadas)
        {
            try
            {
                venta_vs_cobros ventaCobro = new venta_vs_cobros();
                reporte_cobros_encabezado reporteEncabezado = new reporte_cobros_encabezado();
                reporte_cobros_detalle reporteDetalle;
                List<venta_vs_cobros_detalles> listaVentaCobros = new List<venta_vs_cobros_detalles>();
                listaVentaCobros = new modeloCobro().getListaVentaCobrosDetalleCompleta();
                venta venta2 = new venta();//par comprar dentro de ciclos
                cliente cliente2 = new cliente();//para comprara dentro de ciclos

                reporteEncabezado.listaDetalle = new List<reporte_cobros_detalle>();

                empresa empresa=new empresa();
                empresa = new modeloEmpresa().getEmpresaByEmpleadoId(empleado.codigo);
                
                sucursal sucursal=new sucursal();
                sucursal = new modeloSucursal().getSucursalById(empleado.codigo_sucursal);

                List<cliente> listaCliente=new List<cliente>();
                listaCliente = new modeloCliente().getListaCompleta();

                List<venta> listaVenta=new List<venta>();
                listaVenta = new modeloVenta().getListaCompleta();

                //llenando el encabezado
                reporteEncabezado.empleadoImpresion = empleado.nombre;
                //reporteEncabezado.fecha_impresion = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                reporteEncabezado.fecha_impresion = DateTime.Now.ToString();
                reporteEncabezado.empresa = empresa.nombre;
                reporteEncabezado.direccion = sucursal.direccion;
                reporteEncabezado.rnc = empresa.rnc;
                reporteEncabezado.telefonos = sucursal.telefono1 + " - " + sucursal.telefono2;

                //filtrando por cliente
                if (cliente != null)
                {
                    listaVentaCobros = listaVentaCobros.FindAll(x => (venta2 = new modeloVenta().getVentaById(x.codigo_venta)).codigo_cliente == cliente.codigo).ToList();
                    //listaVenta = listaVenta.FindAll(x => x.codigo_cliente == cliente.codigo);
                }
                //filtrando por venta
                if (venta != null)
                {
                    listaVentaCobros = listaVentaCobros.FindAll(x => x.codigo == venta.codigo);
                    //listaVenta = listaVenta.FindAll(x => x.codigo == venta.codigo);
                }
                //filtrando por tipo venta
                if (tipoVenta != "")
                {
                    listaVentaCobros = listaVentaCobros.FindAll(x => (venta2 = new modeloVenta().getVentaById(x.codigo_venta)).tipo_venta.ToLower().Contains(tipoVenta.ToLower())).ToList();
                    //listaVenta = listaVenta.FindAll(x => tipoVenta.ToLower().Contains(x.tipo_venta.ToLower()));
                }

                //rango fechas ventas
                if (incluirRangoFechaVenta == true)
                {
                    listaVentaCobros = listaVentaCobros.FindAll(x => ((ventaCobro = new modeloCobro().getVentaCobroById(x.codigo_cobro)).fecha.Date >= fechaInicialVenta.Date) && ((ventaCobro = new modeloCobro().getVentaCobroById(x.codigo_cobro)).fecha.Date <= fechaFinalVenta.Date)).ToList();
                    //listaVenta = listaVenta.FindAll(x => (ventaCobro = new modeloCobro().getVentaCobroByVentaId(x.codigo)).fecha.Date >= fechaInicialVenta.Date && (ventaCobro = new modeloCobro().getVentaCobroByVentaId(x.codigo)).fecha.Date <= fechaFinalVenta.Date).ToList();
                    //listaVenta = listaVenta.FindAll(x => x.fecha >= fechaInicialVenta.Date && x.fecha <= fechaFinalVenta.Date);
                }

                //si solo son ventas pagadas
                if (soloVentasPagadas == true)
                {
                    listaVentaCobros = listaVentaCobros.FindAll(x => (venta2 = new modeloVenta().getVentaById(x.codigo_venta)).pagada == true).ToList();
                    //listaVenta = listaVenta.FindAll(x => x.pagada == true);
                }


                listaVentaCobros.ToList().ForEach(x => {
                    reporteDetalle = new reporte_cobros_detalle(x.codigo_venta);
                    reporteEncabezado.listaDetalle.Add(reporteDetalle);
                });

                reporteEncabezado.listaDetalle = reporteEncabezado.listaDetalle.OrderByDescending(x => x.idVenta).ToList();

                return reporteEncabezado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getReporteCobrosEncabezado"+ex.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
