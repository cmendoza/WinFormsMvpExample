using System;
using WinFormsMvpExample.Infrastructure;

namespace WinFormsMvpExample.Features.Login
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string Password { get; set; }
        string ErrorMessage { get; set; }

        event EventHandler SignInPressed;
        event EventHandler ExitPressed;
    }
}
