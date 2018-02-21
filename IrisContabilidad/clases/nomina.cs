using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisContabilidad.clases
{
    public class nomina
    {
        public int codigo { get; set; }
        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_final { get; set; }
        public int cod_empleado { get; set; }
        public int cod_tipo { get; set; }
        public int cod_sucursal { get; set; }
        public bool activo { get; set; }
        public bool nomina_cerrada { get; set; }
        public int codigo_empleado_cerrada { get; set; }
    }
}
