using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Correo {  get; set; }
        public string Contrasenia { get; set; }
        public int ID_Nivel { get; set; }
    }
}
