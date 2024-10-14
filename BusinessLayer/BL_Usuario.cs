using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DateLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BL_Usuario
    {
        private DL_Usuario objdl_usuario = new DL_Usuario();

        public List<Usuario> getUsuarios()
        {
            return objdl_usuario.getUsuarios();
        }


    }
}
