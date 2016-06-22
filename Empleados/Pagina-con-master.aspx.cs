using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{
    public partial class Pagina_con_master : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //tengo que acceder al label de la pagina master / acceder al control de la master
            // tengo que publicar en el codvigine de la master
            // etiqueta en cada pagina hija que va a usar esto
            // <%@ MasterType VirtualPath="~/Base.Master" %> para poder ver las propiedades de la master
            // Master. properti
                    }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

           Master.ModificarUsuarioLblAct = "Matias";
          // ((Label) Master.FindControl(lblUsuarioActual)).Text 

        }

    }
}