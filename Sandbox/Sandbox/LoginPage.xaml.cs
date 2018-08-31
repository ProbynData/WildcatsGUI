using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sandbox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private UserData currentUser;

        public LoginPage()
        {
            InitializeComponent();
            // Code to deal with login page navigation below
            NavigationPage.SetHasNavigationBar(this, false);


            buttonLogin.Clicked += async (object sender, EventArgs e) =>
            {

                await Navigation.PushAsync(new ActivityFeedPage());
                // Take in overload here from the login details.
                currentUser = new UserData();
            };

       


        }





    }
}