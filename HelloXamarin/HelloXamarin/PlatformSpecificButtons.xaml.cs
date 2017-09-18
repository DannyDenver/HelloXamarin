using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloXamarin
    {
    public partial class PlatformSpecificButtons : ContentPage
        {
        public PlatformSpecificButtons()
            {
            InitializeComponent();

            //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "Images/clock.png"
            //    ));    
            }
        }
    }
