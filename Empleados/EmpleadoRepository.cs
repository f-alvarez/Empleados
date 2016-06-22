using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados
{
    public class EmpleadoRepository
    {
        private LinkedList<Empleado> empleados = new LinkedList<Empleado>;

        public void agregarEmpleado(Empleado e) {
            this.empleados.AddLast(e);
        }
    }
}