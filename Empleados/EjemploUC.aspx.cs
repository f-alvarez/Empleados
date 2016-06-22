using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{
    public partial class EjemploUC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var Nombre = UCNombre.TextoTextBox;
            var Apellido = UCApellido.TextoTextBox;
            sb.Append(Nombre);
            sb.Append(" ");
            sb.Append(Apellido);
            UCNombreCompleto.TextoTextBox = sb.ToString();




        }
    }
}