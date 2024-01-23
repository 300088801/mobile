namespace Roman;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void Convert_Clicked(System.Object sender, System.EventArgs e)
    {
        Int32 input;
        bool isNumber;
        Converter converter = new Converter();

        isNumber = Int32.TryParse(txtInput.Text, out input);

        if(isNumber)
        {
            lblDisplay.Text = converter.NumberToRoman(input);
        }
        else
        {
            lblDisplay.Text = converter.RomanToNumber(txtInput.Text).ToString();
        }
    }

    void Clear_Clicked_1(System.Object sender, System.EventArgs e)
    {
        txtInput.Text = string.Empty;
        lblDisplay.Text = "0";
    }
}


