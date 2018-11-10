using System;
using System.Collections.Generic;
using Monkeys2.Models;
using Monkeys2.ViewModels;
using Xamarin.Forms;

namespace Monkeys2.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Monkey monkey)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(monkey);
        }
    }
}

