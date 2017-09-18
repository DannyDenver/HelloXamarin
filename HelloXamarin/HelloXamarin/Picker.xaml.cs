using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public class ContactMethod
        {
        public int Id { get; set; }
        public string Name { get; set; }
        }
    public partial class Picker : ContentPage
        {
        private IList<ContactMethod> _contactMethods;
        public Picker()
            {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach(var method in _contactMethods)
                {
                contactMethods.Items.Add(method.Name);
                }
            }
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
            {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = _contactMethods.Single(x => x.Name == name);
            DisplayAlert("Selection", name, "Ok");
            }
        private IList<ContactMethod> GetContactMethods()
            {
            return new List<ContactMethod>
                {
                new ContactMethod {Id = 1, Name = "SMS" },
                new ContactMethod {Id = 2, Name = "Email" }
                };
            }
        }
    }
