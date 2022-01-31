using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaCivil.Entidad
{
    class Citas
    {
        public int id_Cita { get; set; }
        public int id_Cliente { get; set; }
        public int idConfiEmpleadoHorario { get; set; }
        public int id_TipoCita { get; set; }
        public int id_Pago { get; set; }
        public string DescripcionCita { get; set; }
        public decimal Costo { get; set; }
    }
}
