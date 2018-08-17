using System;

using WinFormsMvpExample.Features.Login;
using WinFormsMvpExample.Infrastructure;
using WinFormsMvpExample.Navigation;

namespace WinFormsMvpExample.Features.Main
{
    public sealed class MainPresenter : BasePresenter<IMainView>
    {
        public MainPresenter(IMainView view) 
            : base(view)
        {
            view.ViewShown += View_ViewShown;
        }

        private void View_ViewShown(object sender, EventArgs e)
        {
            NavigationService.Navigator.ShowModal<LoginPresenter, ILoginView>();
            var signedin = NavigationService.Navigator.DataContext is bool && (bool)NavigationService.Navigator.DataContext;
            if (!signedin)
            {
                View.CloseApplication();
                return;
            }
        }
    }
}
