

using catSpin;

namespace AndroidAppTemplate;

public partial class SecondPage : ContentPage
{
    private other other = new other();
    public SecondPage()
    {
        InitializeComponent();
    }

    private void SendToPeak(object? sender, EventArgs e)
    {
        other.OpenLink("https://www.youtube.com/watch?v=iHGgvjlQUeY",this);
    }
}