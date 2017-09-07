using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticateSample
{
    public partial class Authenticate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("The identity is" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "as shown"+"<br/>");
            Response.Write("The authentication is " + User.Identity.IsAuthenticated + "is this"+"<br/>");
            Response.Write("Autthentication Type is " + User.Identity.AuthenticationType + " as shown"+"<br/>");

        }
    }
}