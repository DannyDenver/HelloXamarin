using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class RoundedImage : ContentPage
        {
        public RoundedImage()
            {
            InitializeComponent();

            //round.Source = ImageSource.FromFile("me_sledding.jpg");

            new CircleImage
                {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 150,
                WidthRequest = 150,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"))
                };
            }
        }
    }
