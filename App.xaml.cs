namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? ActivationState)
        {
            var window = base.CreateWindow(ActivationState);    
            window.Width = 400;  // Set the width of the window
            window.Height = 600; // Set the height of the window
            return window;  // Handle when your app starts
        }

    }
}
