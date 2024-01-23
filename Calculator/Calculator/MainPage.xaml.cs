namespace Calculator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Title = "Add Master Pro";
	}

    void Add_Clicked(System.Object sender, System.EventArgs e)
    {
        double firstNum;
        double secondNum;
        
        Double.TryParse(txtFirstNum.Text, out firstNum);
        Double.TryParse(txtSecondNum.Text, out secondNum);
        lblDisplay.Text = (firstNum + secondNum).ToString();
        

    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        txtFirstNum.Text = string.Empty;
        txtSecondNum.Text = string.Empty;
        lblDisplay.Text = "0";
        txtFirstNum.Focus();
    }
}


