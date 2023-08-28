using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_Polimorfismo_10.Entities {
     abstract class Shape {
        private Enums.Color color;

        public Color Color { get; set; }

 

        public Shape(Color color) {
            Color = color;
        }

        protected Shape(Enums.Color color) {
            this.color = color;
        }

        public abstract double Area();

    }
}
