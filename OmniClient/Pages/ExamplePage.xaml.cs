namespace OmniClient.Pages;

public partial class ExamplePage : ContentPage
{
	ExampleViewModel viewModel;


    public ExamplePage(ExampleViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		await viewModel.GetExamples();
	}
}