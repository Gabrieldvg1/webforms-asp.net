using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN
    {
        #region "Patron singleton"
        private static EmpleadoLN objEmpleado = null;
        private EmpleadoLN() { }
        public static EmpleadoLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }
            return objEmpleado;
        }

        #endregion

        public Empleado AccesoSistema(string user, string pass)
        {
            try
            {
                return EmpleadoDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
