using Lands.Views;

using Xamarin.Forms;

namespace Lands
{
	public partial class App : Application
	{
        #region Constructors    
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage()); // NavigationPage para navegar entre paginas (rayita arriba donde va el título)
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
