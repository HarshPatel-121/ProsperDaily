using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

    private async void AddTrasaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TransactionPage());
    }

    //This method is used to show new Transaction in 'DashboardPage. after we clicked on '+' button on Dashboard
    protected override void OnAppearing() 
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}