using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrisContabilidad.clases;

namespace IrisContabilidad.modelos
{
    public class modeloBanco
    {


        //objetos
        utilidades utilidades = new utilidades();


        private string sqlGeneral = "select codigo,nombre,activo,direccion,telefono1,telefono2,fax from banco where codigo >'0' ";

        //agregar 
        public bool agregarBanco(banco banco)
        {
            try
            {
                int activo = 0;
                //validar nombre
                string sql = sqlGeneral + " and nombre='" + banco.nombre + "' and codigo!='" + banco.codigo + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Existe un banco con ese nombre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (banco.activo == true)
                {
                    activo = 1;
                }

                sql = "insert into banco(codigo,nombre,activo,direccion,telefono1,telefono2,fax) values('" + banco.codigo + "','" + banco.nombre + "','" + activo + "','" + banco.direccion + "','"+banco.telefono1+"','"+banco.telefono2+"','"+banco.fax+"')";
                //MessageBox.Show(sql);
                utilidades.ejecutarcomando_mysql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregarBanco.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //modificar
        public bool modificarBanco(banco banco)
        {
            try
            {
                int activo = 0;
                //validar nombre
                string sql = sqlGeneral + " and nombre='" + banco.nombre + "' and codigo!='" + banco.codigo + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Existe un banco con ese nombre", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return false;
                }


                if (banco.activo == true)
                {
                    activo = 1;
                }
                sql = "update banco set nombre='" + banco.nombre + "',activo='" + activo + "',direccion='" + banco.direccion + "',telefono1='"+banco.telefono1+"',telefono2='"+banco.telefono2+"',fax='"+banco.fax+"' where codigo='" + banco.codigo + "'";
                utilidades.ejecutarcomando_mysql(sql);
                //MessageBox.Show(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificarBanco.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //obtener el codigo siguiente
        public int getNext()
        {
            try
            {
                string sql = "select max(codigo)from banco";
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
        public banco getBancoById(int id)
        {
            try
            {
                banco banco = new banco();
                string sql = sqlGeneral + " and codigo='" + id + "'";
                DataSet ds = utilidades.ejecutarcomando_mysql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    banco.codigo = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    banco.nombre = ds.Tables[0].Rows[0][1].ToString();
                    banco.activo = Convert.ToBoolean(ds.Tables[0].Rows[0][2]);
                    banco.direccion = Convert.ToString(ds.Tables[0].Rows[0][3]);
                    banco.telefono1 = Convert.ToString(ds.Tables[0].Rows[0][4]);
                    banco.telefono2 = Convert.ToString(ds.Tables[0].Rows[0][5]);
                    banco.fax = Convert.ToString(ds.Tables[0].Rows[0][6]);
                }
                return banco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getBancoById.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //get lista completa
        public List<banco> getListaCompleta(bool mantenimiento = false)
        {
            try
            {

                List<banco> lista = new List<banco>();
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
                        banco banco=new banco();
                        banco.codigo = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                        banco.nombre = ds.Tables[0].Rows[0][1].ToString();
                        banco.activo = Convert.ToBoolean(ds.Tables[0].Rows[0][2]);
                        banco.direccion = Convert.ToString(ds.Tables[0].Rows[0][3]);
                        banco.telefono1 = Convert.ToString(ds.Tables[0].Rows[0][4]);
                        banco.telefono2 = Convert.ToString(ds.Tables[0].Rows[0][5]);
                        banco.fax = Convert.ToString(ds.Tables[0].Rows[0][6]);
                        lista.Add(banco);
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

        //get banco by nombre
        public banco getBancoByNombre(string nombre)
        {
            try
            {
                bool existe = false;
                List<banco> lista = new List<banco>();
                banco banco=new banco();
                lista = getListaCompleta();
                foreach (var x in lista)
                {
                    if (x.nombre.ToLower().Contains(nombre.ToLower()) && existe == false)
                    {
                        banco =new banco();
                        banco.codigo = x.codigo;
                        banco.nombre = x.nombre;
                        banco.activo = x.activo;
                        banco.direccion = x.direccion;
                        banco.telefono1 = x.telefono1;
                        banco.telefono2 = x.telefono2;
                        banco.fax = x.fax;
                        existe = true;
                    }
                }
                if (existe == true)
                {
                    return banco;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getBancoByNombre.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



    }
}
