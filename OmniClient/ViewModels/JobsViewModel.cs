namespace OmniClient.ViewModels;


public partial class JobsViewModel : BaseViewModel
{
    JobsService jobsService;
    public ObservableCollection<Job> Jobs { get; } = new();
    public JobsViewModel(JobsService jobsService)
    {
        Title = "Jobs";
        this.jobsService = jobsService;
    }

    [ObservableProperty]
    bool isRefreshing;

    [ICommand]
    public async Task GotoAddPage()
    {
        await Shell.Current.GoToAsync($"{nameof(AddJobPage)}", true);
    }

    [ICommand]
    public async Task GetJobs()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var jobs = await jobsService.GetJobs();
            if (!Jobs.Count.Equals(0))
                Jobs.Clear();

            jobs.ForEach(job => Jobs.Add(job));


        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!", $"Unable to get jobs; {ex.GetBaseException().Message}", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }

    }
}
