using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrisContabilidad.clases;
using System.Data;
using System.Windows.Forms;

namespace IrisContabilidad.modelos
{
    public class modeloIngredientesVariacion
    {
        //objetos
        utilidades utilidades = new utilidades();


        private string sqlGeneral = "select codigo,nombre,activo,descripcion,nombre_abreviado from ingredientes_variacion where codigo > '0' ";

        //agregar 
        public bool agregarIngredienteVariacion(ingredientes_variacion ingredienteVariacion)
        {
            try
            {
                int activo = 0;
                //validar nombre
                string sql = sqlGeneral + " and nombre='" + ingredienteVariacion.nombre + "' and codigo!='" + ingredienteVariacion.codigo + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Existe un ingrediente con el mismo nombre que esta tratando de ingresar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //validar nombre abreviado
                sql = sqlGeneral + " and nombre_abreviado='"+ingredienteVariacion.nombre_abreviado+"' and codigo != '"+ingredienteVariacion.codigo+"'";
                ds = utilidades.ejecutarcomando_mysql(sql);
                if(ds.Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("Existe un ingrediente con el mismo nombre abreviado que esta tratando de ingresar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



                if (ingredienteVariacion.activo == true)
                {
                    activo = 1;
                }

                sql = "insert into ingredientes_variacion(codigo,nombre,activo,descripcion,nombre_abreviado) values('" + ingredienteVariacion.codigo + "','" + ingredienteVariacion.nombre + "','" + activo.ToString() + "','" + ingredienteVariacion.descripcion + "','"+ingredienteVariacion.nombre_abreviado+"')";
                //MessageBox.Show(sql);
                utilidades.ejecutarcomando_mysql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregarIngredienteVariacion.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //modificar
        public bool modificarIngredienteVariacion(ingredientes_variacion ingredienteVariacion)
        {
            try
            {
                int activo = 0;
                //validar nombre
                string sql = sqlGeneral + " and nombre='" + ingredienteVariacion.nombre + "' and codigo!='" + ingredienteVariacion.codigo + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Existe un ingrediente con el mismo nombre que esta tratando de ingresar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //validar nombre abreviado
                sql = sqlGeneral + " and nombre_abreviado='" + ingredienteVariacion.nombre_abreviado + "' and codigo != '" + ingredienteVariacion.codigo + "'";
                ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Existe un ingrediente con el mismo nombre abreviado que esta tratando de ingresar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



                if (ingredienteVariacion.activo == true)
                {
                    activo = 1;
                }
                sql = "update ingredientes_variacion  set nombre='" + ingredienteVariacion.nombre + "',activo='" + activo.ToString() + "',descripcion='" + ingredienteVariacion.descripcion + "',nombre_abreviado='"+ingredienteVariacion.nombre_abreviado+"' where codigo='" + ingredienteVariacion.codigo + "'";
                utilidades.ejecutarcomando_mysql(sql);
                //MessageBox.Show(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificarAlmacen.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //obtener el codigo siguiente
        public int getNext()
        {
            try
            {
                string sql = "select max(codigo)from ingredientes_variacion";
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

        //get objeto
        public ingredientes_variacion getIngredienteVariacionById(int id)
        {
            try
            {
                ingredientes_variacion ingredienteVariacion = new ingredientes_variacion();
                string sql = sqlGeneral + " and codigo='" + id + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ingredienteVariacion.codigo = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    ingredienteVariacion.nombre = ds.Tables[0].Rows[0][1].ToString();
                    ingredienteVariacion.activo = Convert.ToBoolean(ds.Tables[0].Rows[0][2]);
                    ingredienteVariacion.descripcion = ds.Tables[0].Rows[0][3].ToString();
                    ingredienteVariacion.nombre_abreviado = ds.Tables[0].Rows[0][4].ToString();
                }
                return ingredienteVariacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getIngredienteVariacionById.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //get lista completa
        public List<ingredientes_variacion> getListaCompleta(bool mantenimiento = false)
        {
            try
            {

                List<ingredientes_variacion> lista = new List<ingredientes_variacion>();
                string sql = "";
                sql = sqlGeneral;
                if (mantenimiento == false)
                {
                    sql += " and activo=1";
                }
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ingredientes_variacion ingredienteVariacion = new ingredientes_variacion();
                        ingredienteVariacion.codigo = Convert.ToInt16(row[0]);
                        ingredienteVariacion.nombre = row[1].ToString();
                        ingredienteVariacion.activo = Convert.ToBoolean(row[2].ToString());
                        ingredienteVariacion.descripcion = row[3].ToString();
                        ingredienteVariacion.nombre_abreviado = row[4].ToString();
                        lista.Add(ingredienteVariacion);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getListaCompleta.:" + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        //get lista completa por nombre
        public List<ingredientes_variacion> getListaByNombre(string nombre)
        {
            try
            {

                List<ingredientes_variacion> lista = new List<ingredientes_variacion>();
                string sql = "";
                sql = sqlGeneral;
                sql += " and activo=1";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ingredientes_variacion ingredienteVariacion = new ingredientes_variacion();
                        ingredienteVariacion.codigo = Convert.ToInt16(row[0]);
                        ingredienteVariacion.nombre = row[1].ToString();
                        ingredienteVariacion.activo = Convert.ToBoolean(row[2].ToString());
                        ingredienteVariacion.descripcion = row[3].ToString();
                        ingredienteVariacion.nombre_abreviado = row[4].ToString();
                        lista.Add(ingredienteVariacion);
                    }
                }
                lista = lista.FindAll(x => x.nombre.ToLower().Contains(nombre.ToLower()));
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getListaByNombre.:" + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        //get almacen by nombre
        public ingredientes_variacion getAlmacenByNombre(string nombre)
        {
            try
            {
                bool existe = false;
                List<ingredientes_variacion> lista = new List<ingredientes_variacion>();
                ingredientes_variacion ingredientesVariacion = new ingredientes_variacion();
                lista = getListaCompleta();
                lista.ForEach(x =>
                {
                    if (x.nombre.ToLower().Contains(nombre.ToLower()) && existe == false)
                    {
                        ingredientesVariacion.codigo = x.codigo;
                        ingredientesVariacion.nombre = x.nombre;
                        ingredientesVariacion.activo = x.activo;
                        ingredientesVariacion.descripcion = x.descripcion;
                        ingredientesVariacion.nombre_abreviado = x.nombre_abreviado;
                        existe = true;
                    }
                });
                if (existe == true)
                {
                    return ingredientesVariacion;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getIngredientesVariacionByNombre.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
