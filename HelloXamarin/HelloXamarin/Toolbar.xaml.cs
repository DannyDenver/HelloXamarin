using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class Toolbar : ContentPage
       
        {
        public Toolbar()
            {
            InitializeComponent();
            }
        void Handle_Activated(object sender, System.EventArgs e)
            {
            DisplayAlert("Activated", "ToolbarItem Activated", "Ok");
            }
        }
    }
