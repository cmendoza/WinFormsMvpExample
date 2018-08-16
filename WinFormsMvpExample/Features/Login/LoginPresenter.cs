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
            // TODO: validate against data store
            if (string.IsNullOrWhiteSpace(View.UserName) || string.IsNullOrWhiteSpace(View.Password))
            {
                View.ErrorMessage = "User name or password are required.";
                return;
            }

            if (View.UserName != "user" || View.Password != "password")
            {
                View.ErrorMessage = "User name and/or password are not valid.";
                return;
            }

            View.Close();
        }

        private void View_ExitPressed(object sender, EventArgs e) => View.Close();
    }
}
