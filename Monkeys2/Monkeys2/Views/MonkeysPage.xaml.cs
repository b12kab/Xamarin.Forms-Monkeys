using System;
using System.Collections.Generic;
using Monkeys2.ViewModels;
using Xamarin.Forms;
using Monkeys2.Models;

namespace Monkeys2.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel(Navigation);
        }

        //void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //=> ((ListView)sender).SelectedItem = null;

        //void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var monkey = ((ListView)sender).SelectedItem as Monkey;
        //    if (monkey == null)
        //        return;

        //    // show detail
        //    Navigation.PushAsync(new DetailsPage(monkey));
        //}
    }
}

