using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;

namespace DLL_Football_Manager
{
    public class csFunciones
    {
        private static string gsConexion = "DSN=Conexion;";
        public static OdbcDataReader gReader;
        public static string gsNivel;
        public static int giUsuario;
        
        /* Autor: Anthony Molineros
         * Fecha: 04/08/2014
         * Comentario: Función ValidarTexto(), utilizada para validar campos con base en una cadena de caracteres permitidos
         * Comentario: Función ValidarCredenciales(), utilizada para validar el usuario y contraseña en el login
         */
        public static void ValidarTexto(KeyPressEventArgs e, string sCadena)
        {
            sCadena = sCadena + (char)8;
            if (!sCadena.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public static int ValidarCredenciales(string sUsuario, string sContrasena)
        {
            try
            {
                giUsuario = 0;
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                string sValidar = "select a.cod_usr, b.nivel_nvl from tabm_usuario a, tabm_nivel b where a.cod_nvl=b.cod_nvl and a.usuario_usr='" + sUsuario + "' and a.contrasena_usr='" + sContrasena + "' and activo_usr=1";
                OdbcCommand sVal = new OdbcCommand(sValidar, sConexion);
                OdbcDataReader sReader = sVal.ExecuteReader();
                while (sReader.Read())
                {
                    giUsuario = sReader.GetInt32(0);
                    gsNivel = sReader.GetString(1);
                }
                sConexion.Close();
                if (giUsuario != 0)
                {
                    MessageBox.Show("Bienvenido " + sUsuario, "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertarControl("Login usuario " + sUsuario);
                    return 1;
                }
                else
                {
                    InsertarControl("Intento de acceder al sistema");
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /* Autor: Kevin Gutierrez
         * Fecha: 07/08/2014
         * Comentario: Función Insertar(), ingresa los datos del query a la base de datos estableciendo una comunicacion con la Bd y luego argumentando el Query
         */
        public static int ObtenerNoRegistro(string sCampo, string sTabla)
        {
            try
            {
                int iNumero = 0;
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                string sCons = "select count(" + sCampo + ") from " + sTabla + "";
                OdbcCommand sExp = new OdbcCommand(sCons, sConexion);
                OdbcDataReader sRd1 = sExp.ExecuteReader();
                while (sRd1.Read())
                {
                    iNumero = sRd1.GetInt32(0) + 1;
                }
                sConexion.Close();
                return iNumero;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int Insertar(string sQuery, string sTabla)
        {
            try
            {
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
                sExp.ExecuteNonQuery();
                sConexion.Close();
                InsertarControl("Insercion en tabla " + sTabla);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            } 
        }

        public static int Eliminar(string sQuery, string sTabla)
        {
            try
            {
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
                sExp.ExecuteNonQuery();
                sConexion.Close();
                InsertarControl("Eliminacion en tabla " + sTabla);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /* Autor: Anthony Molineros
         * Fecha: 09/08/2014
         * Comentario: Función ObtenerIP, utilizada para obtener la ip de la máquina
         * Comentario: Función ObtenerNombreMaquina, utilizada para obtener el nombre de la máquina
         */
        private static string ObtenerIP()
        {
            IPHostEntry iheHost;
            string sIP = "";
            iheHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in iheHost.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    sIP = ip.ToString();
                }
            }
            return sIP;
        }

        private static string ObtenerNombreMaquina(string sIP)
        {
            IPHostEntry iheHost = Dns.GetHostByAddress(sIP);
            string sNombreMaquina = iheHost.HostName;
            return sNombreMaquina;
        }

        /* Autor: Anthony Molineros
         * Fecha: 11/08/2014
         * Comentario: Función GenerarCombinaciones, utilizada para generar el fixture de un campeonato
         */
        public static int ObtenerArbitro(string sFecha)
        {
            try
            {
                int iArbitro = 0;
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                string sQuery = "select a.cod_emp from tabm_empleado a, tabm_tipoemp b where a.cod_temp=b.cod_temp and b.tipo_temp = 'Arbitro' and cod_emp not in (select cod_emp from tabm_partido where fechhora_ptd = '" + sFecha + "')";
                OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
                gReader = sExp.ExecuteReader();
                while (gReader.Read())
                {
                    iArbitro = gReader.GetInt32(0);
                }
                gReader.Close();

                sConexion.Close();
                InsertarControl("Consulta en tabla tabm_empleado");
                return iArbitro;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int ObtenerCancha(string sFecha)
        {
            try
            {
                int iCancha = 0;
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                string sQuery = "select cod_cha from tabm_cancha where cod_cha not in (select cod_cha from tabm_partido where fechhora_ptd = '" + sFecha + "')";
                OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
                gReader = sExp.ExecuteReader();
                while (gReader.Read())
                {
                    iCancha = gReader.GetInt32(0);
                }
                gReader.Close();

                sConexion.Close();
                InsertarControl("Consulta en tabla tabm_cancha");
                return iCancha;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int GenerarCombinaciones(int iCamp, string sFecha)
        {
            try
            {
                int iResp, iCodigo, iFlag, iArbitro = 0, iCancha = 0;
                string sQuery;
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                sQuery = "select distinct cod_eqp from tabt_dettjugador a where cod_camp=" + iCamp;
                OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
                OdbcDataReader myReader = sExp.ExecuteReader();
                List<int> Equipos = new List<int> { };
                while (myReader.Read())
                {
                    Equipos.Add(myReader.GetInt32(0));
                }
                myReader.Close();
                sConexion.Close();
                if (Equipos.Count % 2 == 1)
                {
                    iFlag = 1;
                    Equipos.Add(0);
                }
                else
                {
                    iFlag = 0;
                }
                int[,] Fixture;
                Fixture = new int[Equipos.Count - 1, Equipos.Count];
                int x, y, z;
                z = 0;
                for (x = 0; x < Equipos.Count - 1; x++)
                {
                    for (y = 0; y < Equipos.Count; y += 2)
                    {
                        Fixture[x, y] = Equipos[z];
                        if (z < Equipos.Count - 2)
                        {
                            z++;
                        }
                        else
                        {
                            z = 0;
                        }
                    }
                }
                for (x = 0; x < Equipos.Count - 1; x++)
                {
                    y = 1;
                    if (x % 2 == 0)
                    {
                        if (iFlag == 1)
                        {
                            Fixture[x, y] = 0;
                        }
                        else
                        {
                            Fixture[x, y] = Equipos[Equipos.Count - 1];
                        }
                    }
                    else
                    {
                        Fixture[x, y] = Fixture[x, y - 1];
                        if (iFlag == 1)
                        {
                            Fixture[x, y - 1] = 0;
                        }
                        else
                        {
                            Fixture[x, y - 1] = Equipos[Equipos.Count - 1];
                        }
                    }
                }
                z = Equipos.Count - 2;
                for (x = 0; x < Equipos.Count - 1; x++)
                {
                    for (y = 3; y < Equipos.Count; y += 2)
                    {
                        Fixture[x, y] = Equipos[z];
                        if (z > 0)
                        {
                            z--;
                        }
                        else
                        {
                            z = Equipos.Count - 2;
                        }
                    }
                }
                int w = 0;
                DateTime dtFecha = Convert.ToDateTime(sFecha);
                for (x = 0; x < Equipos.Count - 1; x++)
                {
                    for (y = 0; y < Equipos.Count; y += 2)
                    {
                        if (w < 3)
                        {
                            w++;
                        }
                        else
                        {
                            w = 0;
                            dtFecha = dtFecha.AddDays(1);
                        }
                        iArbitro = ObtenerArbitro(dtFecha.ToString("yyyy-MM-dd hh:mm:ss"));
                        iCancha = ObtenerCancha(dtFecha.ToString("yyyy-MM-dd hh:mm:ss"));
                        iCodigo = ObtenerNoRegistro("cod_ptd", "tabm_partido");
                        iResp = Insertar("insert into tabm_partido values (" + iCodigo + "," + iCamp + "," + iArbitro + "," + iCancha + "," + (x + 1) + ",'" + dtFecha.ToString("yyyy-MM-dd hh:mm:ss") + "'," + Fixture[x, y] + ",0,0," + Fixture[x, y + 1] + ",0)", "tabm_partido");
                    }
                }
                sQuery = "update tabm_campeonato set fechfin_camp ='" + dtFecha.ToString("yyyy-MM-dd hh:mm:ss") + "' where cod_camp =" + iCamp;
                iResp = Insertar(sQuery, "tabm_campeonato");
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /* Autor: Marlon Aldana
         * Fecha: 11/08/2014
         * Comentario: Función InsertarControl(), utilizada para insertar en la tabla Control las acciones realizadas en el programa, por fecha, ip_maquina,acción realizada.
         */
        public static void InsertarControl(string sAccion)
        {
            int iCodigo  = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_ctrl", "tabm_control");
            string sIP = DLL_Football_Manager.csFunciones.ObtenerIP();
            string sMaquina = DLL_Football_Manager.csFunciones.ObtenerNombreMaquina(sIP);
            try
            {
                OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
                sConexion.Open();
                OdbcCommand sExp = new OdbcCommand("insert into tabm_control values (" + iCodigo + "," + giUsuario + ",'" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + sAccion + "','" + sIP + "','" + sMaquina + "')", sConexion);
                sExp.ExecuteNonQuery();
                sConexion.Close();
            }
            catch (Exception e)
            {
            }
        }

        /* Autor: Kevin Gutierrez
         * Fecha: 26/08/2014
         * Comentario: Función ActualizarEstadisticas(), actualiza las estadísticas para la generación de los reportes de Goleadores
         * Autor: Kevin Gutierrez, Anthony Molineros
         * Fecha: 27/08/2014
         * Comentario: Acutalización de la función ActualizarEstadisticas
         * 
         */
        public static void ActualizarEstadisticas(int iCamp, int iJornada, int iLocal, int iVisitante, int iGolL, int iGolV)
        {
            OdbcConnection sConexion = new System.Data.Odbc.OdbcConnection(gsConexion);
            sConexion.Open();
            int iPJ = 0, iPG = 0, iPE = 0, iPP = 0, iGF = 0, iGC = 0, iJT = 0;
            string sQuery = "Select pj_dcamp, pg_dcamp, pe_dcamp, pp_dcamp, gf_dcamp, gc_dcamp, jornada_dcamp from tabt_dettcamp where cod_camp = " + iCamp + " and cod_eqp =" + iLocal + " order by jornada_dcamp desc limit 1";
            OdbcCommand sExp = new OdbcCommand(sQuery, sConexion);
            OdbcDataReader Reader = sExp.ExecuteReader();
            while (Reader.Read())
            {
                iPJ = Reader.GetInt32(0);
                iPG = Reader.GetInt32(1);
                iPE = Reader.GetInt32(2);
                iPP = Reader.GetInt32(3);
                iGF = Reader.GetInt32(4);
                iGC = Reader.GetInt32(5);
                iJT = Reader.GetInt32(6);
            }
            if (iJornada != 0)
            {
                if (iGolL > iGolV)
                {
                    iPG += 1;
                }
                else
                {
                    if (iGolL < iGolV)
                    {
                        iPP += 1;
                    }
                    else
                    {
                        iPE += 1;
                    }
                }
                iGF += iGolL;
                iGC += iGolV;
                iPJ += 1;
                iJT = iJornada;
            }
            else
            {
                iJT += 1;
            }
            OdbcCommand sCommand;
            int iCodigo = ObtenerNoRegistro("cod_dcamp", "tabt_dettcamp");
            sQuery = "insert into tabt_dettcamp values (" + iCodigo + "," + iCamp + "," + iLocal + "," + iJT + "," + iPJ + "," + iPG + "," + iPE + "," + iPP + "," + iGF + "," + iGC + ")";
            sCommand = new OdbcCommand(sQuery, sConexion);
            sCommand.ExecuteNonQuery();
            iPJ = 0; iPG = 0; iPE = 0; iPP = 0; iGF = 0; iGC = 0; iJT = 0;
            string sQuery2 = "Select pj_dcamp, pg_dcamp, pe_dcamp, pp_dcamp, gf_dcamp, gc_dcamp, jornada_dcamp from tabt_dettcamp where cod_camp = " + iCamp + " and cod_eqp = " + iVisitante + " order by jornada_dcamp desc limit 1";
            OdbcCommand sExp2 = new OdbcCommand(sQuery2, sConexion);
            OdbcDataReader Reader2 = sExp2.ExecuteReader();
            while (Reader2.Read())
            {
                iPJ = Reader2.GetInt32(0);
                iPG = Reader2.GetInt32(1);
                iPE = Reader2.GetInt32(2);
                iPP = Reader2.GetInt32(3);
                iGF = Reader2.GetInt32(4);
                iGC = Reader2.GetInt32(5);
                iJT = Reader2.GetInt32(6);
            }
            if (iJornada != 0)
            {
                if (iGolV > iGolL)
                {
                    iPG += 1;
                }
                else
                {
                    if (iGolV < iGolL)
                    {
                        iPP += 1;
                    }
                    else
                    {
                        iPE += 1;
                    }
                }
                iGF += iGolV;
                iGC += iGolL;
                iPJ += 1;
                iJT = iJornada;
            }
            else
            {
                iJT += 1;
            }
            OdbcCommand sCommand2;
            iCodigo = ObtenerNoRegistro("cod_dcamp", "tabt_dettcamp");
            sQuery = "insert into tabt_dettcamp values (" + iCodigo + "," + iCamp + "," + iVisitante + "," + iJT + "," + iPJ + "," + iPG + "," + iPE + "," + iPP + "," + iGF + "," + iGC + ")";
            sCommand2 = new OdbcCommand(sQuery, sConexion);
            sCommand2.ExecuteNonQuery();
            sConexion.Close();
        }
    }
}
