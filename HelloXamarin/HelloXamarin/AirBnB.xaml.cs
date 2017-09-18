using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class AirBnB : ContentPage
        {
        private ObservableCollection<HelloXamarin.Models.BnBSearch> _search;

        List<HelloXamarin.Models.BnBSearch> GetSearches(string searchText = null)
            {
            var searches = new List<HelloXamarin.Models.BnBSearch>
                {
                new Models.BnBSearch { location ="Orland, FL", startDate = new DateTime(2016,11,11), endDate = new DateTime(2016,12,26) },
                new Models.BnBSearch { location ="Jacksonville, FL", startDate = new DateTime(2016,11,11), endDate = new DateTime(2016,12,26) },
                new Models.BnBSearch { location ="Miami, FL", startDate = new DateTime(2016,11,11), endDate = new DateTime(2016,12,26) },
                };
            if (String.IsNullOrWhiteSpace(searchText)) return searches;


            return searches.Where(x => x.location.Contains(searchText)).ToList();
            }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
            {
            var searches = GetSearches(e.NewTextValue);

            listView.ItemsSource = searches;
            }

        void Call_Clicked(object sender, System.EventArgs e)
            {

            var menuItem = sender as MenuItem;
            var search = menuItem.CommandParameter as HelloXamarin.Models.BnBSearch;

            DisplayAlert("Call", search.location, "OK");

            }
        void Delete_Clicked(object sender, System.EventArgs e)
            {
            var search = (sender as MenuItem).CommandParameter as HelloXamarin.Models.BnBSearch;
            _search.Remove(search);
            }


        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            }
        void Handle_Refreshing(object sender, System.EventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            listView.ItemsSource = GetSearches();
            listView.EndRefresh();
            }
        void Handle_TextChanged(object sender, Xamarin.Forms.ItemTappedEventArgs e)
            {
            //var contact = e.Item as HelloXamarin.Models.Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            }
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
            {
            var search = e.SelectedItem as HelloXamarin.Models.BnBSearch;
            DisplayAlert("Selected", search.location, "OK");
            
            }
        public AirBnB()
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



            listView.ItemsSource = GetSearches();
            }
        }
    }
