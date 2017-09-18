using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class PersistentData : ContentPage
        {

        //void OnChange(object sender, System.EventArgs e)
        //    {

        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationsEnabled.On;

        //    Application.Current.SavePropertiesAsync(); //save even when it is not in sleep mode
        //    }

        protected override void OnDisappearing() //when navigating away from page
            {
            base.OnDisappearing();
            }
        public PersistentData()
            {
            InitializeComponent();

            BindingContext = Application.Current;

            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationsEnabled;


            //if (Application.Current.Properties.ContainsKey(TitleKey))
            //    title.Text = Application.Current.Properties[TitleKey].ToString();

            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //    notificationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];
            }
        }
    }
