using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Final.Clases
{
    internal class Materias
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Semestre { get; set; }
        public int Clase { get; set; }
    }
}
