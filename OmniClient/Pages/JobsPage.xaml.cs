namespace OmniClient.Pages;

public partial class JobsPage : ContentPage
{
	JobsViewModel viewModel;
	public JobsPage(JobsViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel;
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await viewModel.GetJobs();
    }
}	