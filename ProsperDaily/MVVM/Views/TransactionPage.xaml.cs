using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class TransactionPage : ContentPage
{
	public TransactionPage()
	{
		InitializeComponent();
		BindingContext = new TransactionViewModel();

        //This code is used to remove the Entry Line
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderLessEntry), (handler, view) =>
        {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);            
#endif
        });
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        var currentVM = 
            (TransactionViewModel)BindingContext;
        var message = 
            currentVM.SaveTransaction();
        await DisplayAlert("Info", message, "Ok");
        await Navigation.PopToRootAsync();
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    
}