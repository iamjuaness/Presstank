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
        DL_Nivel objdl_nivel = new DL_Nivel();

        public List<Nivel_Usuario> GetNiveles()
        {
            return objdl_nivel.GetNiveles();
        }

        public Nivel_Usuario GetNivelByID(int id)
        {
            return objdl_nivel.GetNivelByID(id);
        }
    }
}
