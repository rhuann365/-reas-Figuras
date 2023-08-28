using System;
using System.Drawing;
using Herança_e_Polimorfismo_10.Entities.Enums;


namespace Herança_e_Polimorfismo_10.Entities {
     class Circle : Shape {
        private Enums.Color color1;

        public  double Radius { get; set; }

        public Circle(double radius, System.Drawing.Color color) : base(color) {

            Radius = radius;
        }

        public Circle(double radius, Enums.Color color) {
            Radius = radius;
            this.color1 = color1;
        }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }

    }
}
