using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Sucursal
    {
        public int ID_Sucursal { get; set; }
        public string Nombre_Sucursal { get; set; }
        public string Direccion { get; set; }
        public int ID_Municipio { get; set; }
    }
}
