using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoEmpleado
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public TipoEmpleado()
        {

        }

        public TipoEmpleado(int ID, string Description, bool Estado)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }

    }
}
