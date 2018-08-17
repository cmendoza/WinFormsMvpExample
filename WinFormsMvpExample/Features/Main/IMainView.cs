using System;

using WinFormsMvpExample.Infrastructure;

namespace WinFormsMvpExample.Features.Main
{
    public interface IMainView : IView
    {
        event EventHandler ViewShown;

        void CloseApplication();
    }
}