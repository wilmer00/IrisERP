using IrisContabilidad.clases;
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
using IrisContabilidad.modelos;

namespace IrisContabilidad.modulo_nomina
{
    public partial class ventana_nomina : formBase
    {

        //objetos
        private nomina nomina;
        private nomina ultimaNomina;
        utilidades utilidades = new utilidades();
        private singleton singleton = new singleton();
        private empleado empleado;
        nomina_tipo tipoNomina;


        //modelos
        modeloNomina modeloNomina = new modeloNomina();
        modeloNominaTipo modeloTipoNomina = new modeloNominaTipo();

        public ventana_nomina()
        {
            InitializeComponent();
            empleado = singleton.getEmpleado();
            this.tituloLabel.Text = utilidades.GetTituloVentana(empleado, "Generate payroll/Generar nómina");
            this.Text = tituloLabel.Text;
            loadVentana();
        }

        public void loadVentana()
        {
            try
            {
                //limpiar el tipo de nomina
                tipoNomina = null;
                loadTipoNomina();

                if (nomina != null)
                {
                    //se cargan las fechas actuales de la nomina actual
                    fechaInicialText.Value = nomina.fecha_inicial;
                    fechaFinalText.Value = nomina.fecha_final;
                }
                else
                {
                    //se carga la fecha de la ultima nomina
                    //para saber si esta cerrada o no
                    ultimaNomina = modeloNomina.getUltimaNomina();
                    if (ultimaNomina.nomina_cerrada == true)
                    {
                        //la ultima nomina registrada esta cerrada
                        fechaInicialText.Value = ultimaNomina.fecha_inicial;
                        fechaFinalText.Value = ultimaNomina.fecha_final;
                        button1.Enabled = true;
                    }
                    else
                    {
                        //la ultima nomina registrada aun sigue abierta
                        MessageBox.Show("the last registered payroll is still open, before generating a new one, you must finish the active one/ la ultima nómina aun sigue abierta, antes de generar una nueva debe finalizar la activa", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fechaInicialText.Value = DateTime.Today;
                        fechaFinalText.Value = DateTime.Today;
                        button1.Enabled = false;
                    }
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
                //debe existir fecha inicial
                if (fechaInicialText.Text == "" || (Convert.ToDateTime(fechaInicialText.Value) == null))
                {
                    MessageBox.Show("The initial date is missing/Falta la fecha inicial", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fechaInicialText.Focus();
                    return false;
                }
                //debe existir fecha final
                if (fechaFinalText.Text == "" || (Convert.ToDateTime(fechaFinalText.Value)==null))
                {
                    MessageBox.Show("The final date is missing/Falta la fecha final", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fechaFinalText.Focus();
                    return false;
                }
                //tipo de nomina o puede estar vacio
                if (tipoNomina == null)
                {
                    MessageBox.Show("Missing the type of payroll/Falta seleccionar el tipo de nómina", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tipoNominaIdText.Focus();
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                nomina = null;
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
                if (nomina == null)
                {
                    //agrega
                    crear = true;
                    nomina = new nomina();
                    nomina.codigo = modeloNomina.getNext();
                    nomina.fecha_inicial = fechaInicialText.Value;
                    nomina.fecha_final = fechaFinalText.Value;
                    nomina.cod_empleado = empleado.codigo;
                    nomina.cod_tipo = tipoNomina.codigo;
                    nomina.cod_sucursal = empleado.codigo_sucursal;
                    nomina.activo = true;
                    nomina.nomina_cerrada = false;
                    nomina.codigo_empleado_cerrada = empleado.codigo;
                }
                
                if (crear)
                {
                    //agrega
                    if (modeloNomina.agregarNomina(nomina) == true)
                    {
                        nomina = null;
                        MessageBox.Show("Was added/Se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVentana();
                        
                    }
                    else
                    {
                        MessageBox.Show("Was not added/No se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ////actualiza
                    //if (modeloCargo.modificarCargo(cargo) == true)
                    //{
                    //    cargo = null;
                    //    loadVentana();
                    //    MessageBox.Show("Se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                nomina = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error GetAction.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void salir()
        {
            if (MessageBox.Show("Do you want to gou out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ventana_nomina_Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            try
            {
                nomina = null;
                tipoNomina = null;
                loadVentana();
            }
            catch (Exception ex)
            {
                nomina = null;
                MessageBox.Show("Error clean/Error Limpiar.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAction();
        }

        public void loadTipoNomina()
        {
            try
            {
                if(tipoNomina!=null)
                {
                    tipoNominaIdText.Text = tipoNomina.codigo.ToString();
                    TipoNominaText.Text = tipoNomina.nombre;
                }
                else
                {
                    tipoNominaIdText.Text = "";
                    TipoNominaText.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadTipoNomina.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventana_busqueda_tipo_nomina ventana = new ventana_busqueda_tipo_nomina();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                tipoNomina = ventana.getObjeto();
                loadTipoNomina();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
