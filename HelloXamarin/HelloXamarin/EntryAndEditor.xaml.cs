using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class EntryAndEditor : ContentPage
        {
        public EntryAndEditor()
            {
            InitializeComponent();
            }
        void Handle_Completed(object sender, System.EventArgs e)
            {
            label_page.Text = "Completed";
            }
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
            {
            label_page.Text = e.NewTextValue;
            }
        }
    }
