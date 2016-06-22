using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados         // empleados referencia a las 2 a entidades y a repositorios
{
    public partial class Empleado_UI : System.Web.UI.Page
    {

        EmpleadoRepositorio EmpRepositorio = new EmpleadoRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            //listar empleados mostrarlos               // no funciona porque cargo la grilla y despues lo agrego 
            if (!IsPostBack)
            {
            CargarEmpleados();      // click derecho agregar refactori y el nombre
            }
            Response.Write(DateTime.Now.ToLongTimeString());
        }

        private void CargarEmpleados()              // creo esto
        {
            gvEmpleados.DataSource = EmpRepositorio.ObtenerTodos();
            gvEmpleados.DataBind();
        }

     //   public void EliminarEmpleado()
     //   {
      //      gvEmpleados.DataSource = EmpRepositorio.Obtener();

      //  }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int Legajo = Int32.Parse(TextBox1.Text);
            Empleado emp = EmpRepositorio.Obtener(Legajo);
            if (emp != null)
            {
                emp.Legajo = Legajo;
                emp.Nombre = TextBox2.Text;
                emp.Apellido = TextBox3.Text;
                EmpRepositorio.Modificar(emp);
                error.Visible = true;
            }
            else
            { 
                emp = new Empleado();
                emp.Legajo = Legajo;
                emp.Nombre = TextBox2.Text;
                emp.Apellido = TextBox3.Text;
                EmpRepositorio.Crear(emp);
                error.Visible = false;
                
            }

            CargarEmpleados();          // El navegador refresca la accion duplica

        }

         // List<string> Empleados = new List<string>();            <-- Queria que se llene con los legajos que tengo

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int Lega = Int32.Parse(TextBox4.Text);
            Empleado emp = EmpRepositorio.Obtener(Lega);
            if (emp != null)
            {
                EmpRepositorio.Eliminar(emp);
            }
            else
            {
                
            }
            CargarEmpleados();        
        }


        
        // Obtener por legajo           
        // modificar
        // legajo busca modifica nombre y apellido ---> legajo va a lista de intems


    }
}