using Colegioo.Interface;
using Colegioo.Model;
using System.Collections.Generic;

namespace Colegioo.Repository
{
    public class ClasesRepository : IClasesRepository  
    {
        private List<Asignaturas> asignaturas = new List<Asignaturas>();

      
        public List<Asignaturas> GetAll()
        {
            asignaturas.Add(new Asignaturas("Matemáticas", "Clase General", "Ing Civil"));
            asignaturas.Add(new Asignaturas("Español", "Clase General", "Psicología"));
            asignaturas.Add(new Asignaturas("Programación I", "Clase de Carrera", "Ing Sistemas"));
            asignaturas.Add(new Asignaturas("Redes", "Clase Carrera", "Ing Sistemas"));
            asignaturas.Add(new Asignaturas("Física", "Clase General", "Ing Ambiental"));

            return asignaturas;
        }
    }
}