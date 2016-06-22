using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleadoInsentivo
{
    public class Analista:Empleado
    {
        private float incentivo;

        public Analista(float sueldom, string nombre) {
            this.sueldo = sueldo;
            this.nombre = nombre;
        }

        public override void calcularIncentivo()
        {
            this.incentivo = sueldo * 2.4f;
        }
    }
}