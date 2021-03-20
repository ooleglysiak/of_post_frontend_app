using System;
using OfPost.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OfPost
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //initializations
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
