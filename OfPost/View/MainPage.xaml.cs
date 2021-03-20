using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OfPost.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Sign In method
        void SignIn(object sender, EventArgs args)
        {
            //Navigation to next page
            Navigation.PushAsync(new TabPage());
        }
    }
}
