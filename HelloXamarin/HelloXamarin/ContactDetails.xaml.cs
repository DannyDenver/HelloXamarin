using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class ContactDetails : ContentPage
        {
        public ContactDetails(HelloXamarin.Models.Property property)
            {
            if (property == null) throw new ArgumentNullException();

            BindingContext = property;

            InitializeComponent();
            }
        }
    }
