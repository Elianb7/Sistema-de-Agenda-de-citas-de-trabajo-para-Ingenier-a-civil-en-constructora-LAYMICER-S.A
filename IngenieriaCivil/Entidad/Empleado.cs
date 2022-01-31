using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaCivil.Entidad
{
    class Empleado
    {
        public int id_Empleado { get; set; }
        public int id_Area { get; set; }
        public int id_Profecion { get; set; }
        public string NombreEmpleado { get; set; }
        public int RucEmpleado { get; set; }
        public int telefonoEmpleado { get; set; }
    }
}
