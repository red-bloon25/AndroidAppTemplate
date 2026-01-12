using catSpin;

namespace AndroidAppTemplate;

public partial class MainPage : ContentPage
{
    other other = new other();
    // that removes the need to add the (other other = new other();) thing to every method
    public MainPage()
    {
        InitializeComponent();
        other.ask_for_notifaction();
    }


    private void Button_OnClicked(object? sender, EventArgs e)
    {
        other.change_words(LabelA);
    }

    private async void send_notification(object? sender, EventArgs e)
    {
        other.create_notirfactions("title", "this is the message :3");
        await Task.Delay(5000);
        other.create_notirfactions_with_vibration("this one vibrates"," this one vibrates the phone",1000);
    }
}