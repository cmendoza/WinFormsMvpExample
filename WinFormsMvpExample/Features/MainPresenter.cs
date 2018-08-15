using System;
using WinFormsMvpExample.Features.Login;
using WinFormsMvpExample.Infrestructure;
using WinFormsMvpExample.Navigation;

namespace WinFormsMvpExample
{
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        public MainPresenter(IMainView view) 
            : base(view)
        {
            view.OnLoaded += View_OnLoaded;
        }

        private void View_OnLoaded(object sender, EventArgs e)
        {
            NavigationService.Navigator.ShowModal<LoginPresenter, ILoginView>();
        }
    }
}
