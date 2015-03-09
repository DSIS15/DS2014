/* Autor: Andrea Pérez
 * Fecha: 20/09/2014 
 * Comentario: Programación de función alConsultarRegistro
 * Fecha: 22/09/2014
 * Comentario: Programación de función vInsertarRegistro
 */
/* Autor: Jeniffer López
 * Fecha: 21/09/2014 
 * Comentario: Programación de función vEliminarRegistro
 * Fecha: 23/09/2014
 * Comentario: Programación de función vModificarRegistro
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Navegador
{
    class csDatos
    {
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public ArrayList alConsultarRegistros(ArrayList alDatosEntrada)
        {
            string sQuery = "select * from " + sNombreTabla;
            ArrayList alDatosSalida = new ArrayList();
            if (alDatosEntrada != null)
            {  
                sQuery += " where ";
                ArrayList alCampos = (ArrayList)alDatosEntrada[0];
                ArrayList alRelaciones = (ArrayList)alDatosEntrada[1];
                ArrayList alValores = (ArrayList)alDatosEntrada[2];
                ArrayList alTipo = (ArrayList)alDatosEntrada[3];
                for (int iPosicion = 0; iPosicion < alCampos.Count; iPosicion++)
                {
                    sQuery += alCampos[iPosicion].ToString() + alRelaciones[iPosicion].ToString() + "'" + alValores[iPosicion].ToString() + "'";
                    if (iPosicion < alTipo.Count)
                    {
                        sQuery += " " + alTipo[iPosicion].ToString() + " ";
                    }
                }
            }
            alDatosSalida = ODBCconnector.csFunciones.alConsultar(sQuery);
            return alDatosSalida;
        }

        public void vEliminarRegistro(ArrayList alDatosEntrada)
        {
            string sQuery = "update " + sNombreTabla + " set ";
            TextBox txtCodigo = (TextBox)alDatosEntrada[0];
            TextBox txtEstado = (TextBox)alDatosEntrada[alDatosEntrada.Count - 1];
            sQuery += txtEstado.Tag.ToString() + "=0 where " + txtCodigo.Tag.ToString() + "=" + txtCodigo.Text;
            ODBCconnector.csFunciones.vEliminar(sQuery);
        }

        public void vInsertarRegistro(ArrayList alCampos, ArrayList alDatos)
        {
            string sQuery = "insert into " + sNombreTabla + " (";
            bool bComa = false;
            foreach (string sCampo in alCampos)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += "`" + sCampo + "`";
            }
            sQuery += ") values (";
            bComa = false;
            foreach (string sDato in alDatos)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += "'" + sDato + "'";
            }
            sQuery += ")";
            ODBCconnector.csFunciones.vInsertar(sQuery);
        }

        public void vModificarRegistro(ArrayList alDatos)
        {
            TextBox txtTextBoxes;
            string sQuery = "update " + sNombreTabla + " set ";
            bool bComa = false;
            for (int iPosicion = 1; iPosicion < alDatos.Count; iPosicion++)
            {
                txtTextBoxes = (TextBox)alDatos[iPosicion];
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += txtTextBoxes.Tag.ToString() + "='" + txtTextBoxes.Text + "'";
            }
            txtTextBoxes = (TextBox)alDatos[0];
            sQuery += " where " + txtTextBoxes.Tag.ToString() + "='" + txtTextBoxes.Text + "'";
            ODBCconnector.csFunciones.vModificar(sQuery);
        }
    }
}
