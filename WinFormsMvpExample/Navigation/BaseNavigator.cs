using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample.Navigation
{
    public abstract class BaseNavigator
    {
        public object DataContext { get; set; }

        public abstract void Show<TPresenter, TView>()
            where TPresenter : BasePresenter<TView>
            where TView : IView;

        public abstract void ShowModal<TPresenter, TView>()
            where TPresenter : BasePresenter<TView>
            where TView : IView;

        public abstract void ShowAsChild<TPresenter, TView>(IView parent)
            where TPresenter : BasePresenter<TView>
            where TView : IView;
    }
}