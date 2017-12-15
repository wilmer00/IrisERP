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
using IrisContabilidad.clases;
using IrisContabilidad.modelos;

namespace IrisContabilidad.modulo_inventario
{
    public partial class ventana_ingredientes_variacion : formBase
    {

        //objetos
        ingredientes_variacion ingredienteVariacion;
        utilidades utilidades = new utilidades();
        private singleton singleton = new singleton();
        private empleado empleado;

        //modelos
        modeloIngredientesVariacion modeloIngredienteVariacion = new modeloIngredientesVariacion();

        public ventana_ingredientes_variacion()
        {
            InitializeComponent();
            empleado = singleton.getEmpleado();
            this.tituloLabel.Text = utilidades.GetTituloVentana(empleado, "Ingredientes variacion");
            this.Text = tituloLabel.Text;
            loadVentana();
        }

        public void loadVentana()
        {
            try
            {
                if (ingredienteVariacion != null)
                {
                    //tiene dato
                    ingredienteText.Focus();
                    ingredienteText.SelectAll();

                    ingredienteIdText.Text = ingredienteVariacion.codigo.ToString();
                    ingredienteText.Text = ingredienteVariacion.nombre.ToString();
                    nombreAbreviadoText.Text = ingredienteVariacion.nombre_abreviado.ToString();
                    descripcionText.Text = ingredienteVariacion.descripcion;
                    activoCheck.Checked = Convert.ToBoolean(ingredienteVariacion.activo);
                }
                else
                {
                    //no tiene dato
                    ingredienteIdText.Focus();
                    ingredienteIdText.SelectAll();

                    ingredienteIdText.Text = "";
                    ingredienteText.Text = "";
                    nombreAbreviadoText.Text = "";
                    descripcionText.Text = "";
                    activoCheck.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadVentana.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarGetAction()
        {
            try
            {
                if (ingredienteText.Text == "")
                {
                    ingredienteText.Focus();
                    ingredienteText.SelectAll();
                    MessageBox.Show("Falta el nombre del ingrediente ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (nombreAbreviadoText.Text == "")
                {
                    ingredienteText.Focus();
                    ingredienteText.SelectAll();
                    MessageBox.Show("Falta el nombre abreviado del ingrediente ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



                return true;
            }
            catch (Exception ex)
            {
                ingredienteVariacion = null;
                MessageBox.Show("Error ValidarGetAction.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void GetAction()
        {
            try
            {

                if (MessageBox.Show("Desea guardar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (!ValidarGetAction())
                {
                    return;
                }


                bool crear = false;
                if (ingredienteVariacion == null)
                {
                    //agrega
                    crear = true;
                    ingredienteVariacion = new ingredientes_variacion();
                    ingredienteVariacion.codigo = modeloIngredienteVariacion.getNext();
                }
                ingredienteVariacion.nombre = ingredienteText.Text;
                ingredienteVariacion.nombre_abreviado = nombreAbreviadoText.Text;
                ingredienteVariacion.descripcion = descripcionText.Text;
                ingredienteVariacion.activo = Convert.ToBoolean(activoCheck.Checked);

                if (crear)
                {
                    //agrega
                    if (modeloIngredienteVariacion.agregarIngredienteVariacion(ingredienteVariacion) == true)
                    {
                        ingredienteVariacion = null;
                        loadVentana();
                        MessageBox.Show("Se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ingredienteVariacion = null;
                        MessageBox.Show("No se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //actualiza
                    if (modeloIngredienteVariacion.modificarIngredienteVariacion(ingredienteVariacion) == true)
                    {
                        ingredienteVariacion = null;
                        loadVentana();
                        MessageBox.Show("Se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                ingredienteVariacion = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error GetAction.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void salir()
        {
            if (MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ventana_ingredientes_variacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAction();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventana_busqueda_ingredientes_variacion ventana = new ventana_busqueda_ingredientes_variacion(true);
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                ingredienteVariacion = ventana.getObjeto();
                loadVentana();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingredienteVariacion = null;
            loadVentana();
        }
    }
}
