namespace MauiPictureMatchGame;

public partial class MainPage : ContentPage
{

	private string[] dogeImages = { "cheems.jpg", "doge.jpg", "shiba_leash.jpg", "cheems.jpg", "doge.jpg", "shiba_leash.jpg" };
    private ImageSource defaultImage = "dotnet_bot.jpg";
    private ImageButton[] imgButtons = new ImageButton[6];
	public MainPage()
	{
		InitializeComponent();
        imgButtons[0] = Card0;
        imgButtons[1] = Card1;
        imgButtons[2] = Card2;
        imgButtons[3] = Card3;
        imgButtons[4] = Card4;
        imgButtons[5] = Card5;
        ResetCards();
    }

	private void Card0_Clicked(object sender, EventArgs e)
	{
        ImageButton btn = (ImageButton)sender;
		//ImageSource currentImage = btn.Source;
        if (btn.Source == defaultImage)
        {
            btn.Source = "cheems.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }

    private void Card1_Clicked(object sender, EventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.Source == defaultImage)
        {
            btn.Source = "cheems.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }

    private void Card2_Clicked(object sender, EventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.Source == defaultImage)
        {
            btn.Source = "doge.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }

    private void Card3_Clicked(object sender, EventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.Source == defaultImage)
        {
            btn.Source = "doge.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }

    private void Card4_Clicked(object sender, EventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.Source == defaultImage)
        {
            btn.Source = "shiba_leash.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }

    private void Card5_Clicked(object sender, EventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.Source == defaultImage)
        {
            btn.Source = "shiba_leash.jpg";
        }
        else
        {
            btn.Source = defaultImage;
        }
    }
    private void ResetCards()
    {
        foreach(ImageButton btn in imgButtons)
        {
            btn.Source = defaultImage;
        }
    }
}


