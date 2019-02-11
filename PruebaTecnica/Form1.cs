using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PruebaTecnica
{
    public partial class Form1 : Form
    {
        public string c_estado;
        public string c_municipio;
        public string c_colonia;
        public Form1()
        {
            InitializeComponent();
            CargarLugarNac();
            CargarSexo();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec spPrueba_InsertRegistro" + "'" + txtNombre.Text + "','" +
                    txtAPaterno.Text + "','" + txtAMaterno.Text + "','" + txtFechaNac.Text + "','" + cmbSexo.SelectedItem.ToString() + "','" +
                    cmbLugarNac.SelectedItem.ToString() + "','" + txtCurp.Text + "','" + c_estado + "','" + c_municipio + "','" +
                    c_colonia + "','" + txtCalle.Text + "','" + txtNumero.Text + "','" + txtContacto.Text + "','" +
                    txtC_postal.Text + "'");

                DataSet ds = ConexionDB.Coneccion(cmd);

                var Codigo = ds.Tables[0].Rows[0]["idPersona"].ToString().Trim();
                if (Codigo != "" && Codigo != null)
                {
                    MessageBox.Show("TU REGISTRO FUE EXITOSO", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("TU REGISTRO FALLO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Faltan Campos Por Llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {
            cdFechaNac.Visible = true;
        }
        private void cdFechaNac_Selected(object sender, DateRangeEventArgs e)
        {
            string FechaNac;
            cdFechaNac.Visible = false;
            FechaNac = convertDate(cdFechaNac.SelectionStart.Date.Day.ToString()) + "/" +
                convertDate(cdFechaNac.SelectionStart.Date.Month.ToString()) + "/" +
                cdFechaNac.SelectionStart.Date.Year.ToString();

            txtFechaNac.Text = FechaNac;
        }
        public string convertDate(String valor)
        {
            int numero = Convert.ToInt16(valor);
            if (numero < 10)
            {
                valor = "0" + valor;
            }
            return valor;
        }
        DataSet DatosEntidar;
        public void CargarLugarNac()
        {
            try
            {
                string cmd = string.Format("exec spPrueba_GetEstado '7BDB4FED-AA3F-4096-ACBC-10A52432BFD0'");
                ComboboxItem ite = new ComboboxItem();
                DataSet ds = ConexionDB.Coneccion(cmd);

                ite.Text = "SELECCIONAR";
                ite.Value = 0;

                cmbLugarNac.Items.Add(ite);
                DatosEntidar = ds;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();

                    item.Text = ds.Tables[0].Rows[i]["Estado"].ToString();
                    item.Value = ds.Tables[0].Rows[i]["Corto"].ToString();
                    cmbLugarNac.Items.Add(item);
                }
            }
            catch (Exception error)
            {
                
            }
        }
        public void CargarSexo()
        {
            ComboboxItem ite = new ComboboxItem();
            string [] Datos = { "SELECCIONAR", "FEMENINO", "MASCULINO" };

            cmbSexo.DataSource = Datos;
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        CURPRFCGEN Lass_curp = new CURPRFCGEN();
        private void cmbLugarNac_Selected(object sender, EventArgs e)
        {
            string nombre, ape_Paterno, ape_Materno, fechaNac, sexo, LugarNac, sexoletra;
            nombre = txtNombre.Text;
            ape_Paterno = txtAPaterno.Text;
            ape_Materno = txtAMaterno.Text;
            fechaNac = txtFechaNac.Text;
            sexo = cmbSexo.SelectedItem.ToString();
            LugarNac = cmbLugarNac.SelectedItem.ToString();
            if(sexo=="FEMENINO")
            {
                sexoletra = "F";
            }
            else if(sexo == "MASCULINO")
            {
                sexoletra = "M";
            }
            else
            {
                sexoletra = "";
            }
            string corto = "";
            for (var i = 0; i < DatosEntidar.Tables[0].Rows.Count; i++)
            {
                if(DatosEntidar.Tables[0].Rows[i]["Estado"].ToString() == LugarNac)
                {
                    corto = DatosEntidar.Tables[0].Rows[i]["Corto"].ToString();
                    break;
                }
            }
            if (nombre != ""&& ape_Paterno != ""&& ape_Materno != "" && sexoletra != "" && fechaNac != "" && corto != ""  )
            {
                string curp_persona = Lass_curp.Get_CURP(nombre, ape_Paterno, ape_Materno, sexoletra, fechaNac, corto);
                txtCurp.Text = curp_persona;
            }
            else
            {
                MessageBox.Show("Aun faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void cargarcp()
        {
            try
            {
                string cmd = string.Format("exec spPrueba_BuscaCPByCP  '" + "" +txtC_postal.Text +"'");
                ComboboxItem ite = new ComboboxItem();
                DataSet ds = ConexionDB.Coneccion(cmd);

                txtEstado.Text= ds.Tables[0].Rows[0]["d_estado"].ToString();
                txtMunicipio.Text = ds.Tables[0].Rows[0]["D_mnpio"].ToString();
                txtColonia.Text = ds.Tables[0].Rows[0]["d_asenta"].ToString();
                c_estado = ds.Tables[0].Rows[0]["c_estado"].ToString();
                c_municipio = ds.Tables[0].Rows[0]["c_mnpio"].ToString();
                c_colonia = ds.Tables[0].Rows[0]["id_asenta_cpcons"].ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Aun no tiene un Codigo Postal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargarcp();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ValidarLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
