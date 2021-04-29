using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace TransactionDataBase.UI
{
    public class Global : OKHOSTING.UI.Net4.WebForms.Global
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);

            var config = new Class1();
            config.Start();
        }
    }
}