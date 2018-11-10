using Monkeys2.Helpers;
using Monkeys2.Models;
using Monkeys2.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Monkeys2.ViewModels
{
    public class MonkeysViewModel : INotifyPropertyChanged
    {
        INavigation _navigation;

        public MonkeysViewModel(INavigation navigation)
        {
            _navigation = navigation;
            PopulateList();
        }

        public int MonkeyCount => MonkeyHelper.Monkeys.Count;
        /* new - normal MVVC items */

        void PopulateList()
        {
            MonkeysList = new ObservableCollection<GroupedMonkeys>();

            foreach (var item in MonkeyHelper.Monkeys)
            {
                // Attempt to find any existing groups where theg group key matches 
                // the first char of our item's key.
                var myGroup = MonkeysList.FirstOrDefault(g => g.Heading == item.NameSort);

                // If the list group does not exist, we create it.
                if (myGroup == null)
                {
                    myGroup = new GroupedMonkeys(item.NameSort);
                    myGroup.Add(item);
                    MonkeysList.Add(myGroup);
                }
                else
                { // If the group does exist, we simply add the item to the existing group.
                    myGroup.Add(item);
                }
            }
        }

        async void ShowDetail(Monkey monkey)
        {
            await _navigation.PushAsync(new DetailsPage(monkey));
        }

        private ObservableCollection<GroupedMonkeys> _monkeyList;
        public ObservableCollection<GroupedMonkeys> MonkeysList
        {
            get => _monkeyList;
            set
            {
                _monkeyList = value;
                NotifyPropertyChanged("MonkeysList");
            }
        }

        private Monkey _selectedMonkey;
        public Monkey SelectedMonkey
        {
            get
            {
                return _selectedMonkey;
            }
            set
            {
                if (value != null)
                {
                    _selectedMonkey = value;
                    NotifyPropertyChanged("SelectedMonkey");
                    ShowDetail(_selectedMonkey);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
