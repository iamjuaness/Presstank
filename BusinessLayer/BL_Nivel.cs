using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Nivel
    {
        DL_Nivel objdl_cargo = new DL_Nivel();

        public List<Nivel_Usuario> GetNiveles()
        {
            return objdl_cargo.GetNiveles();
        }
    }
}
