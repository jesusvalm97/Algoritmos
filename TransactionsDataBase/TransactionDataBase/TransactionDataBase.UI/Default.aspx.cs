using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TransactionDataBase.UI
{
    public partial class Default : OKHOSTING.UI.Net4.WebForms.Page
    {
        public override void OnAppStart()
        {
            App = new OKHOSTING.UI.App();
        }
    }
}