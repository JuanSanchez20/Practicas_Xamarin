using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        // Propiedad adicional para identificar si es un botón de acción
        public Action Action { get; set; }  // Action es una delegación que puede ejecutar una acción cuando se selecciona el ítem

        // Nueva propiedad para definir el color de fondo
        public Color BackgroundColor { get; set; }
    }
}
