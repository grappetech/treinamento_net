using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TreinaWeb
{
    public partial class About : Page
    {
        public int Soma { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Usuário de SMTP" + ConfigurationManager.AppSettings["smtpUser"];
            var cstring = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            Soma = 20 + 40;
        }
    }
}