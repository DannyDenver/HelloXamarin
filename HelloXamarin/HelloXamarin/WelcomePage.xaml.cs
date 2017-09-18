using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class WelcomePage : ContentPage
        {
        public WelcomePage()
            {
            InitializeComponent();
            }
        async void Handle_Clicked(object sender, System.EventArgs e)
            {
            await Navigation.PushModalAsync(new IntroPage());
            }
        }
    }
