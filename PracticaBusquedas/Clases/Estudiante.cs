using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBusquedas.Clases
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Nombre}";
        }
    }
}
