using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleadoInsentivo
{
    public class Empleado
    {
        protected float sueldo;
        protected string nombre;
        public virtual void calcularIncentivo();
    }
}