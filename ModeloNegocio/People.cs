using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class People
    {
        public static List<Datos.people> Get()
        {
           using (Datos.EmpresaXEntities db = new Datos.EmpresaXEntities())
            {
                return db.people.ToList();
            }
        }
    }
}
