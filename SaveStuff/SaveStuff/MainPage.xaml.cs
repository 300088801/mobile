namespace SaveStuff;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        Preferences.Set("UserName", txtUserName.Text);
        //saving stuff to the config file
    }

    void Read_Clicked(System.Object sender, System.EventArgs e)
    {
        txtUserName.Text = Preferences.Get("UserName", "");
    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        txtUserName.Text = string.Empty;
    }
}


