using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class Geolocator : ContentPage
        {
        public Geolocator()
            {
            InitializeComponent();

            buttonGetGPS.Clicked += async (sender, args) =>
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;
                labelGPS.Text = "Getting GPS";

                var position = await locator.GetPositionAsync(timeoutMilliseconds: 5000);

                if (position == null)
                    {
                    labelGPS.Text = "null gps :(";
                    return;
                    }
                labelGPS.Text = string.Format("Time: {0} \nLat: {1} \nLong: {2} \n Altitude: {3} \nAltitude Accuracy: {4} \nAccuracy: {5} \n Heading: {6} \n Speed: {7}",
                  position.Timestamp, position.Latitude, position.Longitude,
            position.Altitude, position.AltitudeAccuracy, position.Accuracy, position.Heading, position.Speed);
            };   


         
            }
        }
    }
