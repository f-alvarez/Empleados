using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{
    public partial class Base : System.Web.UI.MasterPage
    {
        public string ModificarUsuarioLblAct
        {
            get { return lblUsuarioActual.Text; }
            set { lblUsuarioActual.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}