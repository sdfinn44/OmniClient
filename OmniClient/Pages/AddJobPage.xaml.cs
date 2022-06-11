namespace OmniClient.Pages;

public partial class AddJobPage : ContentPage
{
	AddJobViewModel viewModel;
	public AddJobPage(AddJobViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
    }
}