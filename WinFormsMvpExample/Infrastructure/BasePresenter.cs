
namespace WinFormsMvpExample.Infrastructure
{
    public abstract class BasePresenter<TView>
        where TView : IView
    {
        public TView View { get; }

        protected BasePresenter(TView view) => View = view;
    }
}
