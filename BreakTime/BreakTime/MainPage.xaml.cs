namespace BreakTime;

public partial class MainPage : ContentPage
{
    int myTake;
    IDispatcherTimer MyTimer;
    int MyTicks, MyMinutes;
    bool isTimeUp, isOn;


	public MainPage()
	{
		InitializeComponent();
        
        MyTimer = Dispatcher.CreateTimer();
        MyTimer.Interval = TimeSpan.FromSeconds(1);
        MyTimer.Tick += MyTimer_Tick;
        isTimeUp = false;
	}

    private void MyTimer_Tick(object sender, EventArgs e)
    {
        if(isTimeUp==false)
        {
        MyTicks++;
        if(MyTicks == 60)
        {
            MyTicks = 0;
            MyMinutes++;

            if((myTake - MyMinutes)==0)
            {
                isTimeUp = true;
                lblDisplay.Text = "Time is Up!!!";
            }
        }
            lblDisplay.Text = (myTake - MyMinutes).ToString() + " Minutes Left";
        }
        else
        {
            if(isOn)
            {
                isOn = false;
                frm.Background = Colors.Red;
            }
            else
            {
                isOn = true;
                frm.Background = Colors.White;
            }
        }
    }

    public bool TimerLogic()
    {
        return true;
    }

    void btnFive_Clicked(System.Object sender, System.EventArgs e)
    {
        myTake = 1;
        isTimeUp = false;
        MyTimer.Start();

    }

    void btnTen_Clicked(System.Object sender, System.EventArgs e)
    {
        myTake = 10;
        isTimeUp = false;
        MyTimer.Start();
    }

    void btnFifteen_Clicked(System.Object sender, System.EventArgs e)
    {
        myTake = 15;
        isTimeUp = false;
        MyTimer.Start();
    }

    void btnReset_Clicked(System.Object sender, System.EventArgs e)
    {
        myTake = 0;
        MyTimer.Stop();
        MyTicks = 0;
        MyMinutes = 0;
        lblDisplay.Text = "Start Break Time";
        frm.Background = Colors.White;
    }
}


