using System;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample.Features.Login
{
    public sealed class LoginPresenter : BasePresenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) 
            : base(view)
        {
            view.ExitPressed += View_ExitPressed;
            view.SignInPressed += View_SignInPressed;
        }

        private void View_SignInPressed(object sender, EventArgs e)
        {
            View.Close();
        }

        private void View_ExitPressed(object sender, EventArgs e)
        {
            View.CloseApplication();
        }
    }
}
