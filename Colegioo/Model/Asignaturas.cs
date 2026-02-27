using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegioo.Model
{
    public class Asignaturas
    {
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string carrera { get; set; }


        public Asignaturas(string n, string d, string c)
        {
            nombre = n;
            descripcion = d;
            carrera = c;
        }
    }
}