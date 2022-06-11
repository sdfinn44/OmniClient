namespace OmniClient;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ExamplePage), typeof(ExamplePage));
        Routing.RegisterRoute(nameof(AddJobPage), typeof(AddJobPage));
    }
}
