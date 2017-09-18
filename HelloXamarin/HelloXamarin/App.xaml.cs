﻿using Android.Support.V4.App;
using Java.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class App : Application
        {
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";
        public App()
            {

            InitializeComponent();



            //MainPage = new NavigationPage(new ListPage()) {
            //    BarBackgroundColor=Color.Gray,
            //    BarTextColor=Color.White
            //    };
            MainPage = new Map();



       
        //MainPage = new NavigationPage(new WelcomePage());
        //MainPage = new NavigationPage(new PickerWNavigation());
        }

        protected override void OnStart()
            {
            // Handle when your app starts
            }

        protected override void OnSleep()
            {
            // Handle when your app sleeps
            }

        protected override void OnResume()
            {
            // Handle when your app resumes
            }

        public string Title
            {
            get
                {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
                   
                }
            set
                {
                Properties[TitleKey] = value;
                }
            }
        public bool NotificationsEnabled
            {
            get
                {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];
                return false;

                }
            set
                {
                Properties[NotificationsEnabledKey] = value;
                }
            }
        }
    }
