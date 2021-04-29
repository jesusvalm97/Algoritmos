using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DragDropFileWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IDictionary<string, byte[]> Files = new Dictionary<string, byte[]>();
            
            for (int i = 0; i < Request.Form.Count; i++)
            {
                string name = string.Empty;
                byte[] bytes = null;

                if (Request.Form["FileDrop_hiddenName" + i] != null)
                {
                    name = Request.Form["FileDrop_hiddenName" + i];
                }

                if (Request.Form["FileDrop_hiddenBytes" + i] != null)
                {
                    bytes = System.Convert.FromBase64String(Request.Form["FileDrop_hiddenBytes" + i]);
                }

                if (!string.IsNullOrEmpty(name) && bytes != null)
                {
                    Files.Add(name, bytes);
                }
            }
        }
    }
}