using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante1
{
    class Platillo
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }

        public float Precio
        {
            get
            {
                return Precio;
            }
            set
            {
                if (value < 50)
                {
                    Precio = 50;
                }
                else
                {
                    Precio = value;
                }
            }
        }

        public List<Ingredientes> Ingredientes { get; set; }

        public Platillo()
        {
            Ingredientes = new List<Ingredientes>();
        }
    }
}