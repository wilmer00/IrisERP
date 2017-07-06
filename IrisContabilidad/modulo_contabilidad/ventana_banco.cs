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
    public partial class ventana_banco : formBase
    {


        //objetos
        singleton singleton = new singleton();
        utilidades utilidades = new utilidades();
        empleado empleado;
        private banco banco;


        //modelos
        modeloEmpleado modeloEmpleado = new modeloEmpleado();
        modeloBanco modeloBanco=new modeloBanco();
        modeloSistemaConfiguracion modeloSistema=new modeloSistemaConfiguracion();


        public ventana_banco()
        {
            InitializeComponent();
            empleado = singleton.getEmpleado();
            this.tituloLabel.Text = utilidades.GetTituloVentana(empleado, "ventana gastos");
            this.Text = tituloLabel.Text;
            loadVentana();
        }

        public void traducirContenido()
        {
            try
            {
                singleton.sistema = modeloSistema.getSistemaConfiguracion();
                if (singleton.sistema.codigoIdiomaSistema == 1)
                {
                    //es
                    label_banco.Text = idiomas.Es_do.banco;
                    label_nombre.Text = idiomas.Es_do.nombreBanco;
                    label_telefono1.Text = idiomas.Es_do.telefono;
                    label_telefono2.Text = idiomas.Es_do.telefono;
                    label_fax.Text = idiomas.Es_do.fax;
                    label_direccion.Text = idiomas.Es_do.direccion;
                    activoCheck.Text = idiomas.Es_do.activo;

                }
                else if (singleton.sistema.codigoIdiomaSistema == 2)
                {
                    //usa
                    label_banco.Text = idiomas.En_us.banco;
                    label_nombre.Text = idiomas.En_us.nombreBanco;
                    label_telefono1.Text = idiomas.En_us.telefono;
                    label_telefono2.Text = idiomas.En_us.telefono;
                    label_fax.Text = idiomas.En_us.fax;
                    label_direccion.Text = idiomas.En_us.direccion;
                    activoCheck.Text = idiomas.En_us.activo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error traducir contenido.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void loadVentana()
        {
            try
            {
                if (banco != null)
                {
                    //llena
                    bancoIdText.Text = banco.codigo.ToString();
                    nombreBancoText.Text = banco.nombre;
                    telefono1Text.Text = banco.telefono1;
                    telefono2Text.Text = banco.telefono2;
                    faxText.Text = banco.fax;
                    direccionText.Text = banco.direccion;
                    activoCheck.Checked = (bool)banco.activo;
                }
                else
                {
                    //limpia
                    bancoIdText.Text = "";
                    nombreBancoText.Text = "";
                    telefono1Text.Text = "";
                    telefono2Text.Text = "";
                    faxText.Text = "";
                    direccionText.Text = "";
                    activoCheck.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadVentana.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void salir()
        {
            if (MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public bool validarGetAction()
        {
            try
            {
                
                //validar numero factura
                if (nombreBancoText.Text == "")
                {
                    nombreBancoText.Focus();
                    nombreBancoText.SelectAll();
                    MessageBox.Show("Falta el nombre del banco", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validarGetAction.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void getAction()
        {
            try
            {
                //validando campos necesarios
                if (validarGetAction() == false)
                {
                    return;
                }

                if (MessageBox.Show("Desea guardar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                bool crear = false;
                //se instancia el empleado si esta nulo
                if (banco == null)
                {
                    banco = new banco();
                    crear = true;
                    banco.codigo = modeloBanco.getNext();
                    banco.activo = true;
                    
                }
                banco.nombre = nombreBancoText.Text;
                banco.telefono1 = telefono1Text.Text;
                banco.telefono2 = telefono2Text.Text;
                banco.fax = faxText.Text;
                banco.direccion = direccionText.Text;
               

                if (crear == true)
                {
                    //se agrega
                    if ((modeloBanco.agregarBanco(banco) == true))
                    {
                        loadVentana();
                        MessageBox.Show("Se agregó ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        banco = null;
                        MessageBox.Show("No se agregó ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                banco = null;
                MessageBox.Show("Error  getAction.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventana_banco_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            banco = null;
            loadVentana();
        }
    }
}
