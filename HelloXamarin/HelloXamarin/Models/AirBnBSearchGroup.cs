using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HelloXamarin.Models
    {
    public class AirBnBSearchGroup : ObservableCollection<BnBSearch>
        {
        public string Title { get; set; }
        public AirBnBSearchGroup(string title, IEnumerable<BnBSearch> searches = null): base(searches)
            {
            Title = title;
            }


        }
    }
