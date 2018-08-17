using System.Windows.Forms;

namespace WinFormsMvpExample.Infrastructure
{
    public interface IView
    {
        void Show();
        void Close();
        DialogResult ShowDialog();

        IView ParentView { get; set; }
    }
}
