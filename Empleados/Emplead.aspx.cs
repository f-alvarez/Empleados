using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{
    public partial class Emplead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LinkedList<Empleado> empleados = new LinkedList<Empleado>();
            Empleado empleado1 = new Programador(5000);
            Empleado empleado2 = new Analista(5000);

            empleados.AddLast(empleado1);
            empleados.AddLast(empleado2);

            foreach (var empleadito in empleados)
            {
                empleadito.calcularIncentivo();
            }

            GridView1.DataSource = empleados;
            GridView1.DataBind();
        }

        
    }
}