using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante1
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        public List<Platillo> Platillos { get; set; }

        public Menu()
        {
            Nombre = "Nuevo Menu";
            Platillos = new List<Platillo>();
        }
    }
}