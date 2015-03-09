/* Autor: Marlon Aldana
 * Fecha: 24/09/2014 - 25/09/2014 
 * Comentario: Formulario de búsqueda Navegador Hotel San Carlos
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class wfBuscar : Form
    {
        csEntidades Entidades = new csEntidades();
        private int giAltura = 12, giAlturaWf = 69, giCont = 0;
        private ArrayList alDatosSalida = new ArrayList();
        private string sNombreTabla = string.Empty;
        public bool bEjecutarBusqueda;
        ArrayList galCampos;
        
        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public ArrayList AlDatosSalida
        {
            get { return alDatosSalida; }
            set { alDatosSalida = value; }
        }
        
        public wfBuscar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vCreacionObjetos();
        }

        private void wfBuscar_Load(object sender, EventArgs e)
        {
            bEjecutarBusqueda = false;
            this.Text = "Buscar en tabla " + SNombreTabla;
            Entidades.SNombreTabla = SNombreTabla;
            galCampos = Entidades.alObtenerCamposTabla();
            this.Height = giAlturaWf;
            btnAgregar_Click(this, e);
        }

        private void vCreacionObjetos()
        {
            Point pCoordenadas = new Point();
            pCoordenadas.X = 12;
            pCoordenadas.Y = giAltura;
            Size sTamano = new Size();
            sTamano.Height = 21;
            sTamano.Width = 150;
            ComboBox cboCampos = new ComboBox();
            cboCampos.Tag = "cboCampos";
            cboCampos.Location = pCoordenadas;
            cboCampos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampos.Size = sTamano;
            foreach (string sCampo in galCampos)
            {
                cboCampos.Items.Add(sCampo);
            }
            if (cboCampos.Items.Count != 0)
            {
                cboCampos.SelectedIndex = 0;
            }
            cboCampos.Visible = true;
            ComboBox cboRelaciones = new ComboBox();
            cboRelaciones.Tag = "cboRelaciones";
            pCoordenadas.X = 168;
            cboRelaciones.Location = pCoordenadas;
            cboRelaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            sTamano.Width = 50;
            cboRelaciones.Size = sTamano;
            cboRelaciones.Items.Add("=");
            cboRelaciones.Items.Add("<>");
            cboRelaciones.Items.Add("<");
            cboRelaciones.Items.Add(">");
            cboRelaciones.Items.Add("<=");
            cboRelaciones.Items.Add(">=");
            cboRelaciones.SelectedIndex = 0;
            cboRelaciones.Visible = true;
            TextBox txtValores = new TextBox();
            txtValores.Tag = "txtValores";
            pCoordenadas.X = 224;
            txtValores.Location = pCoordenadas;
            sTamano.Width = 150;
            txtValores.Size = sTamano;
            txtValores.Visible = true;
            giAlturaWf += 29;
            giAltura += 29;
            this.Height = giAlturaWf;
            this.Controls.Add(cboCampos);
            this.Controls.Add(cboRelaciones);
            this.Controls.Add(txtValores);
            giCont++;
            if (giCont != 1) 
            {
                ComboBox cboTipo = new ComboBox();
                cboTipo.Tag = "cboTipo";
                pCoordenadas.X = 380;
                pCoordenadas.Y = pCoordenadas.Y - 29;
                cboTipo.Location = pCoordenadas;
                pCoordenadas.Y = pCoordenadas.Y + 29;
                cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                sTamano.Width = 50;
                cboTipo.Size = sTamano;
                cboTipo.Items.Add("AND");
                cboTipo.Items.Add("OR");
                cboTipo.SelectedIndex = 0;
                cboTipo.Visible = true;
                this.Controls.Add(cboTipo);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArrayList alCampos = new ArrayList();
            ArrayList alRelaciones = new ArrayList();
            ArrayList alTipo = new ArrayList();
            ArrayList alValores = new ArrayList();
            foreach (Control Control in Controls)
            {
                if (Control is ComboBox)
                {
                    ComboBox cboComboBoxes = (ComboBox)Control;
                    switch (cboComboBoxes.Tag.ToString())
                    {
                        case "cboCampos": alCampos.Add(cboComboBoxes.SelectedItem.ToString()); break;
                        case "cboRelaciones": alRelaciones.Add(cboComboBoxes.SelectedItem.ToString()); break;
                        case "cboTipo": alTipo.Add(cboComboBoxes.SelectedItem.ToString()); break;
                        default: break;
                    }
                }
                else
                {
                    if (Control is TextBox)
                    {
                        TextBox txtTextBoxes = (TextBox)Control;
                        alValores.Add(txtTextBoxes.Text);
                    }
                }
            }
            alDatosSalida.Add(alCampos);
            alDatosSalida.Add(alRelaciones);
            alDatosSalida.Add(alValores);
            alDatosSalida.Add(alTipo);
            bEjecutarBusqueda = true;
            this.Close();
        }
    }
}
