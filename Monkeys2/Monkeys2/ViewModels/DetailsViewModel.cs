using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Monkeys2.Models;

namespace Monkeys2.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        private Monkey _monkey;
        public Monkey Monkey
        {
            get => _monkey;
            set
            {
                _monkey = value;
                NotifyPropertyChanged("SelectedMonkey");
            }
        }

        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

