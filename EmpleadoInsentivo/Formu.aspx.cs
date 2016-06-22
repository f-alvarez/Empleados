using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmpleadoInsentivo
{
    public partial class Formu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LinkedList<Empleado> empleados = new LinkedList<Empleado>();
            Empleado empleado1 = new Programador(5000,"pepe");
            Empleado empleado2 = new Analista(5000,"tito");

            //DataTable dt = new DataTable();

            empleados.AddLast(empleado1);
            empleados.AddLast(empleado2);

            foreach (var empleadito in empleados)
            {
                empleadito.calcularIncentivo();
               

            }

                 
       
        Lista.DataSource = empleados;
        Lista.DataBind();
           } 
        }


    }
