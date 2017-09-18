using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace HelloXamarin
    { 
    public class Post
        {
        public int Id { get;set;}
        public string Title { get; set; }
        public string Body { get; set; }
        }

    public partial class ConsumingAPIs : ContentPage
        {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";

        private HttpClient _client = new HttpClient();

        private ObservableCollection<Post> _posts;

        protected override async void OnAppearing()
            {
            var content = await _client.GetStringAsync(Url);

            var _posts = JsonConvert.DeserializeObject<List<Post>>(content);

            postsListView.ItemsSource = _posts;
                
            base.OnAppearing();
            }

        public ConsumingAPIs()
            {
            InitializeComponent();
            }
        }
    }
