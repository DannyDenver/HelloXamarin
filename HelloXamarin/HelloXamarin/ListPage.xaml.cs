using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class ListPage : ContentPage
        {
        private ObservableCollection<HelloXamarin.Models.Property> _property;

        List<HelloXamarin.Models.Property> GetProperties(string searchText = null)
            {
            var properties = new List<HelloXamarin.Models.Property>
                {
                new Models.Property {Address="3734 N Fillmore St, Denver, CO 80205", ImageURL = "http://lorempixel.com/100/100/city/1", bathrooms=1, bedrooms=3, contact="Wisdome Real Estate", contact_number= "7203303738", price=379000 },
                new Models.Property {Address="2626 Colorado Blvd, Denver, CO 80207", ImageURL = "http://lorempixel.com/100/100/city/2", bathrooms=2, bedrooms=5, contact="Wisdome Real Estate", contact_number= "7203303738", price=525000 },
                new Models.Property {Address="4795 Columbine St # 0, Denver, CO 80216", ImageURL = "http://lorempixel.com/100/100/city/3", bathrooms=1, bedrooms=2, contact="=", contact_number= "-", price=149900 },
                new Models.Property {Address="2603 N Vine St, Denver, CO 80205", ImageURL = "http://lorempixel.com/100/100/city/4", bathrooms=4, bedrooms=3, contact="Owner", contact_number= "-", price=685000 },
                };
            if (String.IsNullOrWhiteSpace(searchText)) return properties;


            return properties.Where(x => x.Address.Contains(searchText)).ToList();
            }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
            {
            var searched_property =  GetProperties(e.NewTextValue);

            listView.ItemsSource = searched_property;


            }

        void Call_Clicked(object sender, System.EventArgs e)
            {

            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as HelloXamarin.Models.Contact;

            DisplayAlert("Call", contact.Name, "OK");

            }
        void Delete_Clicked(object sender, System.EventArgs e)
            {
            var property = (sender as MenuItem).CommandParameter as HelloXamarin.Models.Property;
            _property.Remove(property);
            }


        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            }
        void Handle_Refreshing(object sender, Xamarin.Forms.ItemTappedEventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            }
        void Handle_TextChanged(object sender, Xamarin.Forms.ItemTappedEventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            }
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
            {
            //var contact = e.SelectedItem as HelloXamarin.Models.Contact;
            //DisplayAlert("Selected", contact.Name, "OK");

            if (e.SelectedItem == null)
                return;
            var property = e.SelectedItem as HelloXamarin.Models.Property;
            await Navigation.PushAsync(new ContactDetails(property));
            listView.SelectedItem = null;
            
            }
        public ListPage()
            {
            InitializeComponent();



            //_contacts = new ObservableCollection<HelloXamarin.Models.ContactGroup>
            //    {

            //    new Models.ContactGroup("M", "M")
            //        {
            //    new Models.Contact { Name ="Mosh", ImageURL= "http://lorempixel.com/100/100/people/1", Status="Hey lets talk"},
            //             },
            //    new Models.ContactGroup("J", "J")
            //        {
            //    new Models.Contact { Name ="John", ImageURL="http://lorempixel.com/100/100/people/4", Status= "Working"}
            //                        },
            //    new Models.ContactGroup("D","D")
            //        {
            //        new Models.Contact { Name ="Danny",ImageURL= "http://lorempixel.com/100/100/people/2", Status="Active"},
            //        },
            //    new Models.ContactGroup("Friend", "Friend")
            //        {
            //    new Models.Contact { Name ="Chris", ImageURL="http://lorempixel.com/100/100/people/3", Status="Busy"},

            //        }

            var _contacts = new ObservableCollection<HelloXamarin.Models.Contact>
                {
                new Models.Contact {Name="Danny", ImageURL = "http://lorempixel.com/100/100/people/1", Status="Busy" },
                new Models.Contact { Name ="Chris", ImageURL="http://lorempixel.com/100/100/people/3", Status="Busy"},
                new Models.Contact { Name ="John", ImageURL="http://lorempixel.com/100/100/people/4", Status= "Working"}
                };



            listView.ItemsSource = GetProperties();
            }
        }
    }
