using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.modelos;
using IrisContabilidad.modulo_sistema;

namespace IrisContabilidad.modulo_contabilidad
{
    public partial class ventana_busqueda_banco : formBase
    {

        //objetos
        private banco banco;
        private singleton singleton = new singleton();

        //listas
        private List<banco> lista;


        //modelos
        private modeloBanco modeloBanco = new modeloBanco();
        modeloSistemaConfiguracion modeloSistema=new modeloSistemaConfiguracion();


        //variables 
        public bool mantenimiento = false;
        private int fila = 0;

        public ventana_busqueda_banco(bool mantenimiento=false)
        {
            InitializeComponent();
            this.tituloLabel.Text = this.Text;
            this.mantenimiento = mantenimiento;
            loadLista();
            traducirContenido();
        }

        public void traducirContenido()
        {
            try
            {
                singleton.sistema = modeloSistema.getSistemaConfiguracion();
                if (singleton.sistema.codigoIdiomaSistema == 1)
                {
                    //es
                    labelBuscar.Text = idiomas.Es_do.buscar;
                    codigoColumn.HeaderText = idiomas.Es_do.id;
                    telefono1Column.HeaderText = idiomas.Es_do.telefono;
                    telefono2Column.HeaderText = idiomas.Es_do.telefono;
                    activoColumn.HeaderText = idiomas.Es_do.activo;

                }
                else if (singleton.sistema.codigoIdiomaSistema == 2)
                {
                    //usa
                    labelBuscar.Text = idiomas.En_us.buscar;
                    codigoColumn.HeaderText = idiomas.En_us.id;
                    telefono1Column.HeaderText = idiomas.En_us.telefono;
                    telefono2Column.HeaderText = idiomas.En_us.telefono;
                    activoColumn.HeaderText = idiomas.En_us.activo;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error traducir contenido.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void loadLista()
        {
            try
            {
                //si la lista esta null se inicializa
                if (lista == null)
                {
                    lista = new List<banco>();
                    lista = modeloBanco.getListaCompleta(mantenimiento);
                }
                //se limpia el grid si tiene datos
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                }
                //se agrega todos los datos de la lista en el gridView
                lista.ForEach(x =>
                {
                    dataGridView1.Rows.Add(x.codigo, x.nombre, x.telefono1,x.telefono2,x.activo);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadLista.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public banco getObjeto()
        {
            try
            {
                //para pasar el objeto sucursal desde deonde se llamo
                fila = dataGridView1.CurrentRow.Index;
                banco = modeloBanco.getBancoById(Convert.ToInt16(dataGridView1.Rows[fila].Cells[0].Value.ToString()));
                return banco;
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
            if (MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void buscar()
        {
            try
            {
                lista = modeloBanco.getListaCompleta();
                lista = lista.FindAll(x => x.nombre.ToLower().Contains(nombreText.Text.ToLower()));
                loadLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando.: " + ex.ToString());
            }
        }
        
        private void ventana_busqueda_banco_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void nombreText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista = null;
            loadLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAction();
        }
    }
}
