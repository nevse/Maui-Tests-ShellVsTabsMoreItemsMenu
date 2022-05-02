namespace BugInTabbedUIMoreItems;

public partial class MainPage2 : ContentPage
{
	int count = 0;

	public MainPage2()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

