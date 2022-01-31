using Microsoft.EntityFrameworkCore;
using Modelo.Entidad; 

namespace ModeloDB
{
    class AgendacionCitasDB: DbContext
    {
        //declaracion de las entidades del modelo
        public DbSet<Cliente> Cliente { get; set; }
        //Configuracion de conexion
    }
}
