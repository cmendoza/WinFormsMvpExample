using System;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample.Features.Login
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string Password { get; set; }

        event EventHandler SignInPressed;
        event EventHandler ExitPressed;

        void CloseApplication();
    }
}
