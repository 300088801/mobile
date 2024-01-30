using TimerPro.Custom;
namespace TimerPro;

public partial class MainPage : ContentPage
{
    TimerLogic oTimerLogic = new TimerLogic();
    bool isRunning;

	public MainPage()
	{
		InitializeComponent();
		Title = "Timer Pro";
	}

    void btnStart_Clicked(System.Object sender, System.EventArgs e)
    {
        btnStart.IsEnabled = false;
        btnStop.IsEnabled = true;
        isRunning = true;

        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () => {
            if(isRunning)
            {
                oTimerLogic.SetTickCount();
                lblDisplay.Text = oTimerLogic.GetFormattedString();
            }
            return isRunning;
        });      //how often, and then what do we want to call    every second we are going to call this nameless method
    }

    void btnStop_Clicked(System.Object sender, System.EventArgs e)
    {
        btnStart.IsEnabled = true;
        btnStop.IsEnabled = false;
        isRunning = false;
    }

    void btnReset_Clicked(System.Object sender, System.EventArgs e)
    {
        oTimerLogic.Reset();
        lblDisplay.Text = oTimerLogic.GetFormattedString();
    }
}


