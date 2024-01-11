using Plugin.Maui.FormsMigration;

namespace AppPropertiesTestMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		if (LegacyApplication.Current.Properties.ContainsKey("test"))
		{
			var value = (string)LegacyApplication.Current.Properties["test"];
		}
		else
			throw new Exception("Key not present");
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


