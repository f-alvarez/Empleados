using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{                       
    public partial class LabelTexto : System.Web.UI.UserControl
    {

        public string TextoLabel
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }

        public string TextoTextBox
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }   

    }
}