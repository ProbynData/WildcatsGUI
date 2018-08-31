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
	public partial class ActivityFeedPage : TabbedPage
	{
		public ActivityFeedPage()
		{
			InitializeComponent ();
		}

        private void Begin_Button_Clicked(object sender, EventArgs e)
        {
            BoxHolder.Children.Clear();
            // Add in the method to load a job Script here
        }


    }
}