/* Autor: Kevin Gutiérrez
 * Fecha: 24/09/2014 
 * Comentario: Programación de función vEliminarRegistros
 * Fecha: 25/09/2014
 * Comentario: Programación de función vInsertarRegistros
 */
/* Autor: Daniel Moreno
 * Fecha: 26/09/2014 
 * Comentario: Programación de función alConsultarRegistros
 * Fecha: 27/09/2014
 * Comentario: Programación de función vModificarRegistros
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    class csNegocio
    {
        csDatos Datos = new csDatos();
        csEntidades Entidades = new csEntidades();
        private ArrayList alCampos;
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        private static bool bValidadTexto(string sTexto)
        {
            string sComparar = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ abcdefghijklmnñopqrstuvwxyz-_0123456789@.;:";
            bool bAceptado = true;
            for (int iPosicion = 0; iPosicion < sTexto.Length; iPosicion++)
            {
                if (!sComparar.Contains(sTexto[iPosicion]))
                {
                    bAceptado = false;
                }
            }
            return bAceptado;
        }

        public void vInsertarRegistro(ArrayList alDatosEntrada, string sCodigo)
        {
            Entidades.SNombreTabla = SNombreTabla;
            alCampos = Entidades.alObtenerCamposTabla();
            ArrayList alDatos = new ArrayList();
            if(alCampos != null)
            {
                bool bAceptado = true;
                if (alDatosEntrada.Count == alCampos.Count)
                {
                    foreach (TextBox TxtBoxes in alDatosEntrada)
                    {
                        if (!alCampos.Contains(TxtBoxes.Tag.ToString()))
                        {
                            bAceptado = false;
                        }
                        alDatos.Add(TxtBoxes.Text);
                    }
                    if (bAceptado)
                    {
                        Datos.SNombreTabla = SNombreTabla;
                        alDatos[0] = sCodigo;
                        Datos.vInsertarRegistro(alCampos, alDatos);
                    }
                    else
                    {
                        MessageBox.Show("Los datos no son aceptados.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no coiciden.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void vEliminarRegistro(ArrayList alDatosEntrada)
        {
            Entidades.SNombreTabla = SNombreTabla;
            alCampos = Entidades.alObtenerCamposTabla();
            if(alCampos != null)
            {
            bool bAceptado = true;
            if (alDatosEntrada.Count == alCampos.Count)
            {
                foreach (TextBox TxtBoxes in alDatosEntrada)
                {
                    if (!alCampos.Contains(TxtBoxes.Tag.ToString()))
                    {
                        bAceptado = false;
                    }
                }
                if (bAceptado)
                {
                    Datos.SNombreTabla = SNombreTabla;
                    Datos.vEliminarRegistro(alDatosEntrada);
                }
                else
                {
                    MessageBox.Show("Los datos no son aceptados.", "Hotel San Carlos", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos no coiciden.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            } 
        }

        public void vModificarRegistro(ArrayList alDatosEntrada)
        {
            Entidades.SNombreTabla = SNombreTabla;
            alCampos = Entidades.alObtenerCamposTabla();
            if (alCampos != null) 
            {
                bool bAceptado = true;
                if (alDatosEntrada.Count == alCampos.Count)
                {
                    foreach (TextBox TxtBoxes in alDatosEntrada)
                    {
                        if (!alCampos.Contains(TxtBoxes.Tag.ToString()))
                        {
                            bAceptado = false;
                        }
                    }
                    if (bAceptado)
                    {
                        Datos.SNombreTabla = SNombreTabla;
                        Datos.vModificarRegistro(alDatosEntrada);
                    }
                    else
                    {
                        MessageBox.Show("Los datos no son aceptados.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no coiciden.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public ArrayList alConsultarRegistro(ArrayList alDatosEntrada)
        {
            ArrayList alDatosSalida = new ArrayList();
            Datos.SNombreTabla = SNombreTabla;
            if (alDatosEntrada == null)
            {
                alDatosSalida = Datos.alConsultarRegistros(alDatosEntrada);
            }
            else
            {
                bool bAceptado = true;
                ArrayList alValores = (ArrayList)alDatosEntrada[2];
                foreach (string sValor in alValores)
                {
                    if (!bValidadTexto(sValor))
                    {
                        bAceptado = false;
                    }
                }
                if (bAceptado)
                {
                    alDatosSalida = Datos.alConsultarRegistros(alDatosEntrada);
                }
                else
                {
                    MessageBox.Show("Formatos de los valores estan incorrectos", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return alDatosSalida;
        }
    }
}
