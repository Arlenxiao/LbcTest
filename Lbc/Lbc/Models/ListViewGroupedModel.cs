using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc.Models {

    /// <summary>
    /// http://danielhindrikes.se/xamarin/grouping-a-listview-xamarin-forms/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [ImplementPropertyChanged]
    public class ListViewGroupedModel<T> {
        public ObservableCollection<ListViewGroup<T>> Groups {
            get;
            set;
        }
    }

    [ImplementPropertyChanged]
    public class ListViewGroup<T> : ObservableCollection<T> {

        public ListViewGroup(IEnumerable<T> datas) {
            if (datas == null)
                return;

            foreach (var data in datas)
                this.Add(data);
        }
        public string Title {
            get;
            set;
        }
        public string ShortTitle {
            get;
            set;
        }
    }
}
