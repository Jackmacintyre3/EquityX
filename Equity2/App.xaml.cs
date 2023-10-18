namespace Equity2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // Change the application page to NewPage1 and the application runs indicating that there is an error in the MainPage.xaml file.
            //MainPage = new NewPage1();
        }
    }
}