using Lands.ViewModels;

namespace Lands.Infrastructure 
{
    // Relaciona la página LoginPage con la MainViewModel
    public class InstanceLocator
    {
        #region Properties 
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion        

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
