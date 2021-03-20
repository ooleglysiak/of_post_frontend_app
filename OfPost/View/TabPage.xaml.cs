using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace OfPost.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : Xamarin.Forms.TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();
            //change position to bottom
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}
