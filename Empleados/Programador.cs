using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados
{
    public class Programador:Empleado
    {
        private float incentivo;
        

        public Programador(float sueldo) {
            this.sueldo = sueldo;
        }

        public override void calcularIncentivo(){
            this.incentivo = this.sueldo * 2;    
        }
    }
}