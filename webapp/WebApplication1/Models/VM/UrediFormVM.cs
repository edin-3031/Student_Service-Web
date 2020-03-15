using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EF;


namespace WebApplication1.Models.VM
{
    public class UrediFormVM
    {
        public List<Polaznik> listaPolaznika;
        public List<Administracija> listaAdministracije;
    }

    public class podaci
    {
        public List<UrediFormVM> row;
    }
}
