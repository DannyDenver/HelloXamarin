﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class ContactMethodsPage : ContentPage
        {
        public ContactMethodsPage()
            {
            InitializeComponent();

            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
            }
        public ListView ContactMethods { get { return listView; }}
        }
    }

