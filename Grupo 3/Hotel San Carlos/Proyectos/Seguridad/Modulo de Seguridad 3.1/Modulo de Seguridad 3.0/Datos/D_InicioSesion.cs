using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODBCconnector;
using Modulo_de_Seguridad_3._0.Entidades;
using System.Collections;
using System.Net;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Presentacion;

namespace Modulo_de_Seguridad_3._0.Datos
{
    internal class D_InicioSesion
    {
        private ArrayList alApps = new ArrayList();
        private ArrayList alResultados = new ArrayList();
        private IPHostEntry ipHostName;
        private E_Perfil ePerfil = new E_Perfil();
        private E_Usuario eUsuario = new E_Usuario();
        private E_DatosPublicos eDatosPublicos = new E_DatosPublicos();
        private String sQuery = String.Empty;



        public bool bBuscarUsuario(String sUser, String sPass)
        {
            sQuery = "SELECT cod_usr, cuenta_usr, cod_emp FROM tabm_sgusuario WHERE cuenta_usr = '" + sUser + "' AND pass_usr = '" + sPass + "'";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE estado_usr = 1";
                ArrayList alResp = csFunciones.alConsultar(sQuery);
                if (alResp.Count != 0)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        ePerfil.CodigoUsuario = Convert.ToInt32(Datos[0]);
                        eDatosPublicos.iCodigoUsuario = Convert.ToInt32(Datos[0]);
                        eUsuario.Cuenta = Datos[1].ToString();
                        ePerfil.CodigoEmpleado = Convert.ToInt32(Datos[2]);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("La cuenta no esta actualmente activa, comunisique con su administrador", "Hotel San Carlos");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña Incorrectos", "Hotel San Carlos");
                return false;
            }
        }

        public bool bComprobarFuente()
        {
            sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE  ipdir_usr = '%.%.%.%' ";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count == 0)
            {
                bool bBandera = false;
                ipHostName = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostName.AddressList)
                {
                    sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE ipdir_usr = \"" + ip.ToString() + "\"";
                    alResultados = csFunciones.alConsultar(sQuery);
                    if (alResultados.Count != 0)
                    {
                        bBandera = true;
                        break;
                    }
                    else
                    {
                        bBandera = false;
                    }
                }
                if (bBandera == false) { MessageBox.Show("La dirección del equipo no corresponde con la cuenta", "Hotel San Carlos"); }
                return bBandera;
            }
            else
            {
                return true;
            }
        }

        public bool bObtenerPrivilegio()
        {
            sQuery = "SELECT T1.cod_priv FROM tabm_sgusuario T1 INNER JOIN tabm_sgprivilegio T2 ON T1.cod_priv = T2.cod_priv WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND estado_priv = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoUsuario = Convert.ToInt32(Datos[0]);
                    eDatosPublicos.iCodigoPrivilegio = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else
            {
                MessageBox.Show("El Privilegio no esta disponible en este momento", "Hotel San Carlos");
                return false;
            }
        }

        public bool bBuscarSesionesAbiertas()
        {
            sQuery = "SELECT cod_ses FROM tabt_sgsesion WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND cod_ses IN (SELECT cod_ses FROM tabt_sgsesion WHERE fechfin_ses = 0000-00-00 AND sesact_ses = 1 )";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count == 0)
            {
                return bCrearNuevaSesion();
            }
            else
            {
                foreach (ArrayList Dato in alResultados)
                {
                    ePerfil.CodigoSesion = Convert.ToInt32(Dato[0]);
                }
                MessageBox.Show("Esta cuenta tiene actualmente una sesion abierta", "Hotel San Carlos");
                return bContinuarSesion();
            }
        }

        public bool bContinuarSesion()
        {
            if (MessageBox.Show("Deseas continuar la sesión anterior?" +
                Environment.NewLine + "Si continua se cargaran los datos de la sesion" +
                Environment.NewLine + "Si contesta No, se creara una nueva sesion", "Hotel San Carlos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                sQuery = "UPDATE tabt_sgsesion SET sesact_ses = 0, fechfin_ses = NOW() WHERE cod_ses = " + ePerfil.CodigoSesion;
                csFunciones.vModificar(sQuery,false);
                return bCrearNuevaSesion() ;
            }
        }

        public bool bCrearNuevaSesion()
        {
            try
            {
                sQuery = "SELECT cod_ses FROM tabt_sgsesion WHERE cod_usr = " + ePerfil.CodigoUsuario;
                alResultados = csFunciones.alConsultar(sQuery);
                if (alResultados.Count != 0)
                {
                    sQuery = "SELECT MAX(cod_ses) FROM tabt_sgsesion WHERE cod_usr = " + ePerfil.CodigoUsuario;
                    alResultados = csFunciones.alConsultar(sQuery);
                    foreach (ArrayList Dato in alResultados)
                    {
                        ePerfil.CodigoSesion = Convert.ToInt32(Dato[0]) + 1;
                        sQuery = "INSERT INTO tabt_sgsesion (cod_usr,cod_ses,fechinic_ses,fechfin_ses,sesact_ses) VALUES (" + ePerfil.CodigoUsuario + "," + ePerfil.CodigoSesion + ",NOW(),'0000-00-00',1)";
                        csFunciones.vInsertar(sQuery,false);
                    }
                }
                else
                {
                    ePerfil.CodigoSesion = 1;
                    sQuery = "INSERT INTO tabt_sgsesion (cod_usr,cod_ses,fechinic_ses,fechfin_ses,sesact_ses) VALUES (" + ePerfil.CodigoUsuario + ",1,NOW(),'0000-00-00',1)";
                    csFunciones.vInsertar(sQuery,false);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la sesion " + ex.ToString(), "Hotel San Carlos");
                return false;
            }
        }

        public bool bObtenerPerfilUsuario()
        {
          /*  sQuery = "SELECT cod_pusr FROM tabt_sgperfiusuario WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND estado_plfusr = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoPerfilUsuario = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else
            {
                MessageBox.Show("El Perfil de esta cuenta no esta disponible", "Hotel San Carlos");
                return false;
            }*/
            return true;
        }

        public bool bObtenerPerfil()
        {
           /* sQuery = "SELECT cod_pfll FROM tabt_sgperfiusuario  WHERE cod_pusr = " + ePerfil.CodigoPerfilUsuario + " AND estado_plfusr = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoPerfil = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else
            {
                MessageBox.Show("El Perfil de esta cuenta no esta disponible", "Hotel San Carlos");
                return false;
            }*/
            return true;
        }

        public bool bBuscarAplicaciones()
        {
           /* sQuery = "SELECT T2.nomapp_app, T1.cod_app, T1.select_papp, T1.insert_paap, T1.delete_papp, T1.update_papp, T1.imprimir_papp FROM tabt_sgperfilapp T1 INNER JOIN tabm_sgaplicacion T2 ON T1.cod_app = T2.cod_app WHERE T1.id_perfil = \"" + ePerfil.CodigoPerfil + "\" AND T2.cod_app IN (SELECT T3.cod_app FROM tabm_sgaplicacion T3 INNER JOIN tabt_sgperfilapp T4 ON T3.cod_app = T4.cod_app WHERE T3.estado_app = 1 AND T4.estado_papp = 1)";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    E_Aplicaciones App = new E_Aplicaciones();
                    App.CodigoAplicacion = Convert.ToInt32(Datos[1]);
                    App.NombreAplicacion = Datos[0].ToString();
                    App.PrivilegiosAplicacion.Add("SLC", Convert.ToInt32(Datos[2]));
                    App.PrivilegiosAplicacion.Add("INS", Convert.ToInt32(Datos[3]));
                    App.PrivilegiosAplicacion.Add("DEL", Convert.ToInt32(Datos[4]));
                    App.PrivilegiosAplicacion.Add("UPD", Convert.ToInt32(Datos[5]));
                    App.PrivilegiosAplicacion.Add("IMP", Convert.ToInt32(Datos[6]));
                    alApps.Add(App);
                }
                eDatosPublicos.alAplicaciones = alApps;
                vBuscarAplicacionesPersonales();
                return true;
            }
            else
            {
                MessageBox.Show("Error al obtener las aplicaciones", "Hotel San Carlos");
                return false;
            }*/
            return true;
        }

        private void vBuscarAplicacionesPersonales()
        {
            try
            {
                sQuery = "SELECT T2.cod_app, T2.nomapp_app,T1.insert_aappp,T1.select_aappp,T1.delete_aappp,T1.update_aappp,T1.imprimir_aappp FROM tabt_sgasignapppersonal T1 INNER JOIN tabm_sgaplicacion T2 ON T1.cod_app = T2.cod_app WHERE T1.cod_usr = " + ePerfil.CodigoUsuario;
                alResultados = csFunciones.alConsultar(sQuery);
                if (alResultados.Count != 0)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        E_Aplicaciones App = new E_Aplicaciones();
                        App.CodigoAplicacion = Convert.ToInt32(Datos[1]);
                        App.NombreAplicacion = Datos[0].ToString();
                        App.PrivilegiosAplicacion.Add("SLC", Convert.ToInt32(Datos[2]));
                        App.PrivilegiosAplicacion.Add("INS", Convert.ToInt32(Datos[3]));
                        App.PrivilegiosAplicacion.Add("DEL", Convert.ToInt32(Datos[4]));
                        App.PrivilegiosAplicacion.Add("UPD", Convert.ToInt32(Datos[5]));
                        App.PrivilegiosAplicacion.Add("IMP", Convert.ToInt32(Datos[6]));
                        alApps.Add(App);
                    }
                    eDatosPublicos.alAplicacionesPersonales = alApps;
                }
            }
            catch { }
        }

        public bool bObtenerPregunta(String sUser)
        {
            sQuery = "SELECT T2.nom_preg, T1.resp_usr, T1.pass_usr, T1.correo_usr FROM tabm_sgusuario T1 INNER JOIN tabm_sgpregunta T2 ON T1.cod_preg = T2.cod_preg WHERE T1.cuenta_usr = \"" + sUser + "\"";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                wfRecuperarPass wfRecuPass = new wfRecuperarPass();
                foreach (ArrayList Dato in alResultados)
                {
                    wfRecuPass.Pregunta = Dato[0].ToString();
                    wfRecuPass.Respuesta = Dato[1].ToString();
                    wfRecuPass.Password = Dato[2].ToString();
                    wfRecuPass.Correo = Dato[3].ToString();
                    wfRecuPass.Cuenta = sUser;
                }
                return true;
            }
            else
            {
                return false;
            }          
        }
    }
}
