namespace AndroidAppTemplate;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void Button_OnClicked(object? sender, EventArgs e)
    {
        other other = new other();
        other.change_words(LabelA);
    }
}