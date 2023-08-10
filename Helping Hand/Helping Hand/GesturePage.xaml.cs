

namespace Helping_Hand;

public partial class GesturePage : ContentPage
{
	public GesturePage()
	{
		InitializeComponent();
	}

    private async void Hello_Clicked(object sender, EventArgs e)
    {
		await TextToSpeech.SpeakAsync("Hello");
    }

    private async void Goodbye_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Goodbye");
    }

    private async void Happy_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Happy");
    }

    private async void Sad_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Sad");
    }

    private async void Yes_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Yes");
    }

    private async void No_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("No");
    }

    private async void Thankyou_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Thank You");
    }

    private async void Please_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Please");
    }

    private async void Hungry_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Hungry");
    }

    private async void Thirsty_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Thirsty");
    }

    private async void You_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("You");
    }

    private async void Me_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.SpeakAsync("Me");
    }
}