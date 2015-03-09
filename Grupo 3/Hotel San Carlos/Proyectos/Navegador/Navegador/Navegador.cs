/* Autor: Jeniffer López
 * Fecha: 11/09/2014 
 * Comentario: Diseño de iconos 
 * Fecha: 13/09/2014 
 * Comentario: Actualización diseño de iconos
 * Fecha: 15/09/2014 
 * Comentario: Diseño del navegador
 * Fecha: 17/09/2014 
 * Comentario: Actualización diseño del navegador
 */
/* Autor: Anthony Molineros
 * Fecha: 13/09/2014 
 * Comentario: Diseño de botones
 * Fecha: 15/09/2014 
 * Comentario: Actualización diseño de botones
 * Fecha: 15/09/2014 
 * Comentario: Diseño del navegador
 * Fecha: 17/09/2014 
 * Comentario: Actualización diseño del navegador
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Navegador: UserControl
    {
        csNegocio Negocio = new csNegocio();
        csEntidades Entidades = new csEntidades();
        public event EventHandler btnNuevo_BeforeClick, btnNuevo_AfterClick;
        public event EventHandler btnGuardar_BeforeClick, btnGuardar_AfterClick;
        public event EventHandler btnBuscar_BeforeClick, btnBuscar_AfterClick;
        public event EventHandler btnModificar_BeforeClick, btnModificar_AfterClick;
        public event EventHandler btnEliminar_BeforeClick, btnEliminar_AfterClick;
        public event EventHandler btnLimpiar_BeforeClick, btnLimpiar_AfterClick;
        public event EventHandler btnRecargar_BeforeClick, btnRecargar_AfterClick;
        public event EventHandler btnImprimir_BeforeClick, btnImprimir_AfterClick;
        public event EventHandler btnPrimero_BeforeClick, btnPrimero_AfterClick;
        public event EventHandler btnAnterior_BeforeClick, btnAnterior_AfterClick;
        public event EventHandler btnSiguiente_BeforeClick, btnSiguiente_AfterClick;
        public event EventHandler btnUltimo_BeforeClick, btnUltimo_AfterClick;
        private ArrayList AlDatosEntrada = new ArrayList();
        private ArrayList alDatosSalida = new ArrayList();
        private string SNombreTabla = string.Empty;
        private int iCodigo = 0;
        private bool bModificarRegistro = false;
        private bool BEjecutarEvento = true;
        private int iContador = 0;
        
        public ArrayList alDatosEntrada
        {
            get { return AlDatosEntrada; }
            set { AlDatosEntrada = value; }
        }

        public bool bEjecutarEvento
        {
            get { return BEjecutarEvento; }
            set { BEjecutarEvento = value; }
        }
        public string sNombreTabla
        {
            get { return SNombreTabla; }
            set { SNombreTabla = value; }
        }

        public Navegador()
        {
            InitializeComponent();
            bModificarRegistro = false;
            iContador = 0;
        }

        public void vIniciarNavegador()
        {
            vValidarDatosEntrada();
            EventArgs e = new EventArgs();
            btnRecargar_Click(this, e);
        }

        private void vValidarDatosEntrada()
        {
            if (string.Compare(sNombreTabla, string.Empty) == 0)
            {
                MessageBox.Show("Ingrese el nombre de la tabla.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (alDatosEntrada.Count == 0)
                {
                    MessageBox.Show("Ingrese el Arraylist de alDatosEntrada.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void vActivarLimpiarTextBoxes(bool bActivar, bool bLimpiar)
        {
            foreach (TextBox TxtBoxes in alDatosEntrada)
            {
                TxtBoxes.Enabled = bActivar;
                if (bLimpiar)
                {
                    TxtBoxes.Text = string.Empty;
                }
            }      
        }

        protected virtual void vValidarEvento(EventHandler ehEvento, EventArgs eaE)
        {
            if (ehEvento != null)
            {
                ehEvento(this, eaE);
            }
        }

        private void vMostrarDatos()
        {
            if (alDatosSalida != null)
            {
                for (int iPosicion = 0; iPosicion < alDatosEntrada.Count; iPosicion++)
                {
                    TextBox txtTextBoxes = (TextBox)alDatosEntrada[iPosicion];
                    if (alDatosSalida.Count != 0)
                    {
                        ArrayList alDatos = (ArrayList)alDatosSalida[iContador];
                        txtTextBoxes.Text = alDatos[iPosicion].ToString();
                    }
                    else
                    {
                        txtTextBoxes.Text = string.Empty;
                    }
                }
            }
            vActivarLimpiarTextBoxes(false, false);
        }

        private void vRestriccionBotones(bool bEstado)
        {
            btnNuevo.Enabled = bEstado;
            btnBuscar.Enabled = bEstado;
            btnModificar.Enabled = bEstado;
            btnEliminar.Enabled = bEstado;
            btnRecargar.Enabled = bEstado;
            btnImprimir.Enabled = bEstado;
            btnPrimero.Enabled = bEstado;
            btnAnterior.Enabled = bEstado;
            btnSiguiente.Enabled = bEstado;
            btnUltimo.Enabled = bEstado;
            btnGuardar.Enabled = !bEstado;
            btnLimpiar.Enabled = !bEstado;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnNuevo_BeforeClick, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, true);
                vValidarEvento(btnNuevo_AfterClick, e);
                vRestriccionBotones(false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnGuardar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                Negocio.SNombreTabla = sNombreTabla;
                if (bModificarRegistro)
                {
                    TextBox txtCodigo = (TextBox)alDatosEntrada[0];
                    iCodigo = Convert.ToInt32(txtCodigo.Text);
                    Negocio.vModificarRegistro(alDatosEntrada);
                    bModificarRegistro = false;
                    vActivarLimpiarTextBoxes(false, false);
                }
                else
                {
                    Entidades.SNombreTabla = sNombreTabla;
                    iCodigo = Entidades.iObtenerCodigo();
                    Negocio.vInsertarRegistro(alDatosEntrada, iCodigo.ToString());
                    vActivarLimpiarTextBoxes(false, true);
                }
                btnRecargar_Click(this, e);
                if (iCodigo > 0)
                {
                    iContador = iCodigo - 1;
                }
                vMostrarDatos();
                vValidarEvento(btnGuardar_AfterClick, e);
                vRestriccionBotones(true);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnBuscar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                wfBuscar Buscar = new wfBuscar();
                Buscar.SNombreTabla = sNombreTabla;
                Buscar.ShowDialog();
                Negocio.SNombreTabla = sNombreTabla;
                if (Buscar.bEjecutarBusqueda)
                {
                    alDatosSalida = Negocio.alConsultarRegistro(Buscar.AlDatosSalida);
                    iContador = 0;
                    vMostrarDatos();
                    vValidarEvento(btnBuscar_AfterClick, e);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnModificar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, false);
                vValidarEvento(btnModificar_AfterClick, e);
                bModificarRegistro = true;
                vRestriccionBotones(false);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnEliminar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                Negocio.SNombreTabla = sNombreTabla;
                Negocio.vEliminarRegistro(alDatosEntrada);
                vActivarLimpiarTextBoxes(false, true);
                btnRecargar_Click(this, e);
                TextBox txtCodigo = (TextBox)alDatosEntrada[0];
                iCodigo = Convert.ToInt32(txtCodigo.Text);
                iContador = iCodigo - 1;
                vMostrarDatos();
                vValidarEvento(btnEliminar_AfterClick, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnLimpiar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, true);
                vValidarEvento(btnLimpiar_AfterClick, e);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnRecargar_BeforeClick, e);
            if (bEjecutarEvento)
            {
                Negocio.SNombreTabla = sNombreTabla;
                alDatosSalida = Negocio.alConsultarRegistro(null);
                vMostrarDatos();
                vValidarEvento(btnRecargar_AfterClick, e);
                vRestriccionBotones(true);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnImprimir_BeforeClick, e);
            if (bEjecutarEvento)
            {
                vValidarEvento(btnImprimir_AfterClick, e);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnPrimero_BeforeClick, e);
            if (bEjecutarEvento)
            {
                iContador = 0;
                vMostrarDatos();
                vValidarEvento(btnPrimero_AfterClick, e);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnAnterior_BeforeClick, e);
            if (bEjecutarEvento)
            {
                if (iContador > 0)
                {
                    iContador--;
                }
                vMostrarDatos();
                vValidarEvento(btnAnterior_AfterClick, e);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnSiguiente_BeforeClick, e);
            if (bEjecutarEvento)
            {
                if (iContador < alDatosSalida.Count - 1)
                {
                    iContador++;
                }
                vMostrarDatos();
                vValidarEvento(btnSiguiente_AfterClick, e);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            vValidarDatosEntrada();
            bEjecutarEvento = true;
            vValidarEvento(btnUltimo_BeforeClick, e);
            if (bEjecutarEvento)
            {
                iContador = alDatosSalida.Count - 1;
                vMostrarDatos();
                vValidarEvento(btnUltimo_AfterClick, e);
            }
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            vRestriccionBotones(true);
        }
    }
}
