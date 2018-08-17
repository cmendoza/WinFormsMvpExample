using System;
using WinFormsMvpExample.Infrastructure;

namespace WinFormsMvpExample
{
    public interface IMainView : IView
    {
        event EventHandler ViewShown;

        void CloseApplication();
    }
}