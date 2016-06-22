using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Double;

namespace EmpleadoInsentivo
{
    public class Programador:Empleado
    {
        private float incentivo;

        public Programador(float sueldo, string nombre) {
            this.sueldo = sueldo;
            this.nombre = nombre;
        }

        override public void calcularIncentivo( ) 
        {
            this.incentivo = sueldo * 1.2f;
        }
    }
}