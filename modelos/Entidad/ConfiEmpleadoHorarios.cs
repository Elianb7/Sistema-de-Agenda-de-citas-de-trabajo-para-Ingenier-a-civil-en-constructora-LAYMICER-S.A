using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidad
{
    class ConfiEmpleadoHorarios
    {
        public int id_Confi { get; set; }
        public int id_Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public int id_Horarios { get; set; }

    }
}
