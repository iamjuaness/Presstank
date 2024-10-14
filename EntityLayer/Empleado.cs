using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Empleado
    {
        public int ID_Empleado { get; set; }
        public string Nombre { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Cargo { get; set; }
    }
}
