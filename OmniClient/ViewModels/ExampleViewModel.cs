

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniClient.ViewModels;

public partial class ExampleViewModel: BaseViewModel
{
    ExampleService exampleService;
    public ObservableCollection<Example> Examples { get; } = new();
    public ExampleViewModel(ExampleService exampleService)
    {
        Title = "Examples";
        this.exampleService = exampleService;
    }
    [ObservableProperty]
    bool isRefreshing;

    

    [ICommand]
    public async Task GetExamples()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var examples = await exampleService.GetExamples();
            if (!Examples.Count.Equals(0))
                Examples.Clear();

            examples.ForEach(example => Examples.Add(example));


        } catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!", $"Unable to get examples; {ex.GetBaseException().Message}", "OK");
        } finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }

    }

}
