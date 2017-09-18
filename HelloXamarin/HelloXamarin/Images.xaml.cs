using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class Images : ContentPage
        {
        public Images()
            {
            InitializeComponent();

            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri(""))

            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };

            //caching images
            //imageSource.CachingEnabled = true;
            // timespan
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            //image.Source = imageSource;

            ///image.Source = "http://..."

            //image cropped
            //image.Aspect = Aspect.AspectFill;

            //distort image picture
            //image.Aspect = Aspect.AspectFit;




            image.Source = ImageSource.FromFile("me_sledding.jpg");


            }
        }
    }
