using IrisContabilidad.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisContabilidad.modelos
{
    public class modeloNomina
    {
        //objetos
        utilidades utilidades = new utilidades();

        private string sqlGeneral = "select codigo,fecha_inicial,fecha_final,cod_empleado,cod_tipo,cod_sucursal,activo,nomina_cerrada,cod_empleado_cerrada from nomina where codigo>'0' ";

        //agregar 
        public bool agregarNomina(nomina nomina)
        {
            try
            {
                int activo = 0;
                int nominaCerrada = 0;
                //validar fecha no existan empalme de fechas
                string sql = sqlGeneral + " and ('" + nomina.fecha_inicial.ToString("yyyy-MM-dd") + "' between fecha_inicial and fecha_final) || ('" + nomina.fecha_final.ToString("yyyy-MM-dd") + "' between fecha_inicial and fecha_final) and nomina_cerrada = '1';";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Payroll splice detected/Empalme fecha de nomina detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



                if (nomina.activo == true)
                {
                    activo = 1;
                }
                if(nomina.nomina_cerrada==true)
                {
                    nominaCerrada = 1;
                }


                sql = "insert into nomina(codigo,fecha_inicial,fecha_final,cod_empleado,cod_tipo,cod_sucursal,activo,nomina_cerrada,cod_empleado_cerrada) values('"+nomina.codigo+ "', '" + nomina.fecha_inicial.ToString("yyyy-MM-dd") + "', '"+nomina.fecha_final.ToString("yyyy-MM-dd")+ "', '" + nomina.cod_empleado + "', '" + nomina.cod_tipo + "', '" + nomina.cod_sucursal + "', '"+activo.ToString()+"', '"+nominaCerrada.ToString()+ "', '" + nomina.codigo_empleado_cerrada + "');";
                //MessageBox.Show(sql);
                utilidades.ejecutarcomando_mysql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add payroll/Error agregarNomina.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //modificar
        public bool modificarNomina(nomina nomina)
        {
            try
            {
                //validar que la nomina que llego no este cerrada
                if(nomina.nomina_cerrada==true)
                {
                    MessageBox.Show("The payroll is closed and can not be modified/ La nomina esta cerrada y no puede ser modificada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("contact the support to perform this operation/Contacte al soporte para poder realizar esta operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //int activo = 0;
                //int nominaCerrada = 0;
                ////validar fecha no existan empalme de fechas
                //string sql = sqlGeneral + " and ('"+nomina.fecha_inicial.ToString("yyyy-MM-dd")+ "' between fecha_inicial and fecha_final) || ('" + nomina.fecha_final.ToString("yyyy-MM-dd") + "' between fecha_inicial and fecha_final) and nomina_cerrada = '1';";
                //DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    MessageBox.Show("Payroll splice detected/Empalme fecha de nomina detectado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

                //if (nomina.activo == true)
                //{
                //    activo = 1;
                //}
                //if (nomina.nomina_cerrada == true)
                //{
                //    nominaCerrada = 1;
                //}
                //sql = "update nomina  where codigo='" + nomina.codigo + "'";
                //utilidades.ejecutarcomando_mysql(sql);
                ////MessageBox.Show(sql);
                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modifying payroll/Error modificarNomina.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //obtener el codigo siguiente
        public int getNext()
        {
            try
            {
                string sql = "select max(codigo)from nomina";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                //int id = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                int id = 0;
                if (ds.Tables[0].Rows[0][0].ToString() == null || ds.Tables[0].Rows[0][0].ToString() == "")
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                }
                id += 1;
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getNext.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //obtener la ultima nomina cerrada
        public nomina getUltimaNominaCerrada()
        {
            try
            {
                string sql = sqlGeneral+ " and nomina_cerrada='1' order by codigo desc limit 1";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                nomina nomina;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    /*
                     * select codigo,fecha_inicial,fecha_final,
                     * cod_empleado,cod_tipo,cod_sucursal,activo,
                     * nomina_cerrada,cod_empleado_cerrada from nomina;
                     */
                    nomina = new nomina();
                    nomina.codigo = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                    nomina.fecha_inicial = Convert.ToDateTime(ds.Tables[0].Rows[0][1].ToString());
                    nomina.fecha_final = Convert.ToDateTime(ds.Tables[0].Rows[0][2].ToString());
                    nomina.cod_empleado= Convert.ToInt16(ds.Tables[0].Rows[0][3].ToString());
                    nomina.cod_tipo= Convert.ToInt16(ds.Tables[0].Rows[0][4].ToString());
                    nomina.cod_sucursal= Convert.ToInt16(ds.Tables[0].Rows[0][5].ToString());
                    nomina.activo= Convert.ToBoolean(ds.Tables[0].Rows[0][6].ToString());
                    nomina.nomina_cerrada= Convert.ToBoolean(ds.Tables[0].Rows[0][7].ToString());
                    nomina.codigo_empleado_cerrada= Convert.ToInt16(ds.Tables[0].Rows[0][8].ToString());

                    return nomina;
                }

                return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error getNext.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //obtener la ultima nomina
        public nomina getUltimaNomina()
        {
            try
            {
                string sql = sqlGeneral + " order by codigo desc limit 1";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                nomina nomina;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    /*
                     * select codigo,fecha_inicial,fecha_final,
                     * cod_empleado,cod_tipo,cod_sucursal,activo,
                     * nomina_cerrada,cod_empleado_cerrada from nomina;
                     */
                    nomina = new nomina();
                    nomina.codigo = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                    nomina.fecha_inicial = Convert.ToDateTime(ds.Tables[0].Rows[0][1].ToString());
                    nomina.fecha_final = Convert.ToDateTime(ds.Tables[0].Rows[0][2].ToString());
                    nomina.cod_empleado = Convert.ToInt16(ds.Tables[0].Rows[0][3].ToString());
                    nomina.cod_tipo = Convert.ToInt16(ds.Tables[0].Rows[0][4].ToString());
                    nomina.cod_sucursal = Convert.ToInt16(ds.Tables[0].Rows[0][5].ToString());
                    nomina.activo = Convert.ToBoolean(ds.Tables[0].Rows[0][6].ToString());
                    nomina.nomina_cerrada = Convert.ToBoolean(ds.Tables[0].Rows[0][7].ToString());
                    nomina.codigo_empleado_cerrada = Convert.ToInt16(ds.Tables[0].Rows[0][8].ToString());

                    return nomina;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getNext.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
