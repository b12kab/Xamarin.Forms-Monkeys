Xamarin.Forms-Monkeys
=====================
This is a fork of the original Monkeys project at [https://github.com/jamesmontemagno/Xamarin.Forms-Monkeys](https://github.com/jamesmontemagno/Xamarin.Forms-Monkeys)

## Original project problems

It's got that great XamlCTask error that happens with older projects compiled with Visual Studio Mac, making it useless for me as it was.

I don't need the CarouselView example or the Archive, so I removed those. I've upgraded it to use Xamarin Forms 3 as well.

### Fix

In order to actually get this to work with the Xaml compiler, I removed the project and started a new one and copied the files from the old one into the new one.

This was created using VS 2017 Mac version 7.6.8.

### Other project problems

The problem with the original (and most other examples) using [IsGroupingEnabled](https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.ListView.IsGroupingEnabled?view=xamarin-forms) and [GroupDisplayBinding](https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.ListView.GroupDisplayBinding?view=xamarin-forms) that they don't use a MVVC example, which I (and I think most others) need. So I also changed it over to that.

There isn't much out there on XAML grouping that isn't done after 2015 that is self explanitory. Hopefully this will help you out.