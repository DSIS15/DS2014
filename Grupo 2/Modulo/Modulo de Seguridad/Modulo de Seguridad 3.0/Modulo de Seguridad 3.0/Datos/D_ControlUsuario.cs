/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo_de_Seguridad_3._0.Datos;
using Modulo_de_Seguridad_3._0.Entidades;
using System.Collections;
using System.Windows.Forms;
using ODBCconnector;
using System.Data.Odbc;

namespace Modulo_de_Seguridad_3._0.Datos
{
    internal class D_ControlUsuario: D_Conexion
    {
        private E_Usuario eUsuario = new E_Usuario();
        private E_Perfil ePerfil = new E_Perfil();
        private String sQuery = String.Empty;
        private ArrayList alResultados = new ArrayList();

        public bool bCerrarSesion()
        {
            try
            {
                sQuery = "UPDATE tabt_sgsesion SET sesact_ses = 0, fechfin_ses = NOW() WHERE cod_ses = " + ePerfil.CodigoSesion;
                csFunciones.vModificar(sQuery,false);
                return true;
            }
            catch
            {
                MessageBox.Show("No se pudo cerrar la sesion adecuadamente, Intente de nuevo");
                return false;
            }
        }

        public bool bObtenerNombre()
        {
            sQuery = "SELECT nom1_emp, nom2_emp, apell1_emp, apell2_emp FROM tabm_nnempleado WHERE cod_emp = " + ePerfil.CodigoEmpleado;
            alResultados = csFunciones.alConsultar(sQuery);
            try
            {
                if (alResultados.Count != 0)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        eUsuario.NombreUsuario = Datos[0] + " " + Datos[1] + " " + Datos[2] + " " + Datos[3];
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void vObtenerPrivilegio()
        {
            switch (ePerfil.CodigoEmpleado)
            {
                case 1: eUsuario.Privilegio = "Administrador Global"; break;
                case 2: eUsuario.Privilegio = "Administrador de Area"; break;
                case 3: eUsuario.Privilegio = "Digitador"; ; break;
                default: eUsuario.Privilegio = "(Sin Privilegio)"; break;
            }
        }

        public bool bObtenerPerfil()
        {
            sQuery = "SELECT nom_pfl FROM tabm_sgperfil WHERE cod_pfll = " + ePerfil.CodigoPerfil;
            alResultados = csFunciones.alConsultar(sQuery);
            try
            {
                if (alResultados.Count != 0)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        eUsuario.Perfil = Datos[0].ToString();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool bObtenerImagen()
        {
            sQuery = "SELECT foto_usr FROM tabm_sgusuario WHERE cod_usr = " + ePerfil.CodigoUsuario;
            if (bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand(sQuery, Conexion);
                    OdbcDataReader odReader = ocComando.ExecuteReader();
                    while (odReader.Read())
                    {
                        eUsuario.ImagenBytes = (byte[])odReader[0];
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener una imagen", "Error");
                }
            }
            return true;
        }

        public bool bObtenerNombreCorreo(String sCuenta)
        {
            sQuery = "SELECT nom1_emp, nom2_emp, apell1_emp, apell2_emp FROM tabm_nnempleado T1 INNER JOIN tabm_sgusuario T2 ON T1.cod_emp = T2.cod_emp WHERE cuenta_usr = \"" + sCuenta + "\"";
            alResultados = csFunciones.alConsultar(sQuery);
            try
            {
                if (alResultados.Count != 0)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        eUsuario.NombreUsuario = Datos[0] + " " + Datos[1] + " " + Datos[2] + " " + Datos[3];
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
