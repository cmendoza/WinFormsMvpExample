using System;
using System.Windows.Forms;
using WinFormsMvpExample.Infrastructure;

namespace WinFormsMvpExample
{
    public partial class Main : WinFormView, IMainView
    {
        public Main()
        {
            InitializeComponent();
        }

        public event EventHandler ViewShown
        {
            add => Shown += value;
            remove => Shown -= value;
        }

        public void CloseApplication() => Application.Exit();
    }
}
