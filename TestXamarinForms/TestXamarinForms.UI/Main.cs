using System;
using OKHOSTING.Core;
using OKHOSTING.UI;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Maps;

namespace TestXamarinForms.UI
{
    public class Main : Controller
    {
        protected override void OnStart()
        {
            IMap map = BaitAndSwitch.Create<IMap>();

            Page.Content = map;
        }
    }
}
