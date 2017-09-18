using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class PickerWNavigation : ContentPage
        {
        public PickerWNavigation()
            {
            InitializeComponent();
            }
        void Handle_Tapped(object sender, System.EventArgs e)
            {

            ///picker with navigation 
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
            }
        }
    }
