using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace guatefac
{
    public class Configuracion
    {

        public static String path = ConfigurationManager.AppSettings["RutaXML"].ToString();
        public static String pathRes = ConfigurationManager.AppSettings["RutaRespuestaXML"].ToString();
        public static String usuario = ConfigurationManager.AppSettings["USUARIO"].ToString();
        public static String nit = ConfigurationManager.AppSettings["NIT"].ToString();
        public static String password = ConfigurationManager.AppSettings["PASSWORD"].ToString();
        public static String maquina = ConfigurationManager.AppSettings["MAQUINA"].ToString();
        public static String establecimiento = ConfigurationManager.AppSettings["ESTABLECIMIENTO"].ToString();
        public static String auth_user = ConfigurationManager.AppSettings["CREDENCIALES_PRODUCCION_USUARIO"].ToString();
        public static String auth_password = ConfigurationManager.AppSettings["CREDENCIALES_PRODUCCION_PASSWORD"].ToString();

        public static string DOC = "";

    }
}