namespace Example;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTQ4NzM4M0AzMjMxMmUzMTJlMzMzNWM4bEVGeTl4VEQwZldwcm5nWDhsS0NkTjdTRDJvdlpHc1Z4dWhCanBEMGc9");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
