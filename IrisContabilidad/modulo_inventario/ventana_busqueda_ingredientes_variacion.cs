using IrisContabilidad.clases;
using IrisContabilidad.modelos;
using IrisContabilidad.modulo_sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_inventario
{
    public partial class ventana_busqueda_ingredientes_variacion : formBase
    {

        //objetos
        private ingredientes_variacion ingredienteVariacion;        

        //listas
        private List<ingredientes_variacion> Lista;

        //modelos
        private modeloIngredientesVariacion modeloIngredienteVariacion = new modeloIngredientesVariacion();
        modeloSucursal modeloSucursal = new modeloSucursal();

        //variables 
        public bool mantenimiento = false;
        private int fila = 0;


        public ventana_busqueda_ingredientes_variacion(bool mantenimiento=false)
        {
            InitializeComponent();
            this.tituloLabel.Text = this.Text;
            this.mantenimiento = mantenimiento;
            loadLista();
        }
       
        public void loadLista()
        {
            try
            {
                //si la lista esta null se inicializa
                if (Lista == null)
                {
                    Lista = new List<ingredientes_variacion>();
                    Lista = modeloIngredienteVariacion.getListaCompleta(mantenimiento);
                }
                //se limpia el grid si tiene datos
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                }
                
                //se organiza la lista por orden alfabetico
                Lista = Lista.OrderBy(x => x.nombre).ToList();

                //se agrega todos los datos de la lista en el gridView
                Lista.ForEach(x =>
                {
                    dataGridView1.Rows.Add(x.codigo, x.nombre,x.nombre_abreviado,x.descripcion, x.activo);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadLista.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ingredientes_variacion getObjeto()
        {
            try
            {
                //para pasar el objeto sucursal desde deonde se llamo
                fila = dataGridView1.CurrentRow.Index;
                ingredienteVariacion = modeloIngredienteVariacion.getIngredienteVariacionById(Convert.ToInt16(dataGridView1.Rows[fila].Cells[0].Value.ToString()));
                return ingredienteVariacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getObjeto.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void getAction()
        {
            this.DialogResult = DialogResult.OK;
            getObjeto();
            this.Close();
        }

        public void Salir()
        {
            if (MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ventana_busqueda_ingredientes_variacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lista = null;
            loadLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void nombreText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Lista = modeloIngredienteVariacion.getListaCompleta();
                    Lista = Lista.FindAll(x => x.nombre.ToLower().Contains(nombreText.Text.ToLower()));
                    loadLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando.: " + ex.ToString());
            }
        }

    }
}
