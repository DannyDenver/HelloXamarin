using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class TableView : ContentPage
        {
        public TableView()
            {
            InitializeComponent();
            }
        void Handle_Changed(object sender, EventArgs e)
            {
            DisplayAlert("Clicked", "You clicked", "Cancel");
            }
        }
    }
