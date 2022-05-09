using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clsNEGPerson
    {
        clsDAOPerson daoPerson = new clsDAOPerson();
        
        public DataTable GetAll()
        {
            return daoPerson.GetAll();
        }
        public DataTable GetPerson(string nombre)
        {
            return daoPerson.Buscar(nombre);
        }
    }
}
