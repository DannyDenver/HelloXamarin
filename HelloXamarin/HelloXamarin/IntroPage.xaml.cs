using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class IntroPage : ContentPage
        {
        public IntroPage()
            {
            InitializeComponent();
            }
        async void Handle_Clicked(object sender, System.EventArgs e)
            {
            await Navigation.PopModalAsync();
            }
        //prevent default back button behavior
        protected override bool OnBackButtonPressed()
            {
            return true;
            //return base.OnBackButtonPressed();
            }
        }
    }
