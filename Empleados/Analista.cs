using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados
{   
    
    public class Analista : Empleado
    {
        private float incentivo;
        

        public Analista(float sueldo) {
            this.sueldo = sueldo;
        }

        public override void calcularIncentivo(){
            this.incentivo = this.sueldo * 2;    
        }
    }
}