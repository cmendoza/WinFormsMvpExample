using System;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample
{
    public interface IMainView : IView
    {
        event EventHandler OnLoaded;
    }
}
