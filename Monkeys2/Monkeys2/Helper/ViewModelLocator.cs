using System;
using Monkeys2.Helpers;
using Monkeys2.ViewModels;

namespace Monkeys2.Helper
{
    public static class ViewModelLocator
    {
        static MonkeysViewModel monkeysVM;
        public static MonkeysViewModel MonkeysViewModel
        => monkeysVM ?? (monkeysVM = new MonkeysViewModel());

        static DetailsViewModel detailsVM;
        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));
    }
}
