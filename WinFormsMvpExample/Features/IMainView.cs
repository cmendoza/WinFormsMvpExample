using System;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample
{
    public interface IMainView : IView
    {
        event EventHandler ViewShown;

        void CloseApplication();
    }
}