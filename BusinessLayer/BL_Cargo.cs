using DateLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Cargo
    {
        DL_Cargo objdl_cargo = new DL_Cargo();

        public List<Cargo> GetCargos()
        {
            return objdl_cargo.GetCargos();
        }

        public Cargo GetCargo(int id)
        {
            return objdl_cargo.GetCargo(id);
        }
    }
}
