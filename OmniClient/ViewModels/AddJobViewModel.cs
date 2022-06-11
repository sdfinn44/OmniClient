

namespace OmniClient.ViewModels;

public partial class AddJobViewModel : BaseViewModel
{
    JobsService jobsService;
    public AddJobViewModel(JobsService jobsService)
    {
        Title = "Add Job";
        this.jobsService = jobsService;
        job = new Job();
    }

    [ObservableProperty]
    Job job;
}
