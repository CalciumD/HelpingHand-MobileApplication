namespace Helping_Hand;

public partial class SpeakingPage : ContentPage
{
	public SpeakingPage()
	{
		InitializeComponent();
	}

    private async void enterText_Completed(object sender, EventArgs e)
    {
		string s = ((Microsoft.Maui.Controls.InputView)sender).Text;
		await TextToSpeech.SpeakAsync(s);
    }


	public void addNum(int n, int s)
	{
		Console.WriteLine(n + s);
	}

}